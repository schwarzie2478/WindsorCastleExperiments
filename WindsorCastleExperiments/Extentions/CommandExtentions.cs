using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Extentions
{
    public static class CommandExtentions
    {
        public static IWindsorContainer AddCommandsAndProcesses(this IWindsorContainer container, Assembly assembly)
        {
            container.Register(Classes.FromAssembly(assembly).BasedOn<ICommand>().WithServiceAllInterfaces().LifestyleTransient());
            return container;
        }
    }
}
