using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Diagnostics;

namespace LoadTestAssembly.IOC
{
    public class AssemblyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //I want to register them as fallbacks
            var regs = Classes.FromThisAssembly()
                .Where(t => typeof(IWork).IsAssignableFrom(t))
                .Unless(t => typeof(ILazy).IsAssignableFrom(t))
                .WithServiceFirstInterface();
            regs.Configure(
                reg => 
                    reg.IsFallback()
                );
            container.Register(
                regs
                );
            var lazyregs = Classes.FromThisAssembly()
                .Where(t => typeof(IWork).IsAssignableFrom(t))
                .If(t => typeof(ILazy).IsAssignableFrom(t))
                .WithServiceFirstInterface();
            lazyregs.Configure(
                reg =>
                    reg.IsDefault()
            );
            container.Register(
                lazyregs
                );

            //The default IWork is now Lazy Worker
            var worker = container.Resolve<IWork>();
            if (typeof(ILazy).IsAssignableFrom(worker.GetType()))
            {
                Debug.WriteLine("LazyWorker is selected");
            }

            
        }
    }
}
