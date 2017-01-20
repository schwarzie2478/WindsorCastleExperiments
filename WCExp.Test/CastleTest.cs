using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using WindsorCastleExperiments.Interfaces;
using WindsorCastleExperiments.Implementations;
using System.Diagnostics;
using System.Collections.Generic;
using Castle.Facilities.TypedFactory;
using System.Reflection;
using Castle.Windsor.Installer;
using LoadTestAssembly;

namespace WCExp.Test
{
    [TestClass]
    public class CastleTest
    {
        [TestMethod]
        public void TestContainer()
        {
            var container = SetupContainer();

            //DefaultNamingConventions
            var worker = container.Resolve<IWork>("LoadTestAssembly.StandardWorker");
            worker.WorkABit();

            //ICommand`2 default registrations and 
            var cmd =  container.Resolve<ICommand<Func<int,bool>, bool>>("WindsorCastleExperiments.Implemenations.DoNothingCommand`2");
            cmd.ExecuteAction( i =>  i == 0);
        }
        [TestMethod]
        public void TestChangeRegistration()
        {
            var container = SetupContainer();

            //override StandardWorker to point to BusyWorker

            //container.Register(
            //    Component
            //    .For<IWork>().OverWrite()
            //    .ImplementedBy<LoadTestAssembly.BusyWorker>()
            //    .Named("LoadTestAssembly.StandardWorker"));


            //worker should be BusyWorker now
            var worker = container.Resolve<IWork>("LoadTestAssembly.StandardWorker");
            worker.WorkABit();
            var uworker = container.Resolve<IWork>("LoadTestAssembly.UnknownWorker");
            uworker.WorkABit();

            
        }

        private void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            var  para = new object[1];
            para[0] = key;
            Debug.WriteLine("Registering {0}",para);
        }

        [TestMethod]
        public void TestTypes()
        {
            var type1 = Type.GetType("WindsorCastleExperiments.Implementations.DoNothingCommand`2, WindsorCastleExperiments");
            var type2 = typeof(WindsorCastleExperiments.Implementations.DoNothingCommand<,>);
            if(type1.Equals(type2))
            {
                return;
            }
            Assert.Fail("Types differ");
        }
        [TestMethod]
        public void TestMethod1()
        {
            WindsorContainer container = SetupContainer();


            var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand<Person, List<Person>>("GetAllCommandOriginal");
            Debug.WriteLine(((object)cmd).GetType().FullName);
            var result = root.CommandManager.ExecuteCommand<Person, List<Person>> (cmd,new Person() );

            Assert.IsTrue(cmd.IsSucceeded);

        }
        [TestMethod]
        public void TestMethodGetOneCommand()
        {
            WindsorContainer container = SetupContainer();

            var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand<int, Person>("GetOnePersonCommand");
            var cmd2 = root.CommandManager.CreateCommand<int, Cat>("GetOneCatCommand");
            try
            {
                var cat = root.CommandManager.ExecuteCommand<int, Cat>(cmd2, 0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            WindsorContainer container = SetupContainer();

             var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand<object, List<Person>>("GetAll§Command");
            try
            {
                cmd.ExecuteAction(0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            var genericType = Type.GetType("WindsorCastleExperiments.Interfaces.ICommand`2");

            var types = new Type[2];
            types[0] = typeof(Person);
            types[1] = typeof(List<Person>);
            var commandType = genericType.MakeGenericType(types);

            WindsorContainer container = SetupContainer();
            var root = container.Resolve<IRoot>();

            var cmd = container.Resolve(commandType);
        }
        [TestMethod]
        public void TestMethodSimpleCommand()
        {
            WindsorContainer container = SetupContainer();
            var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand("SimpleCommand");
            try
            {
                root.CommandManager.ExecuteCommand(cmd, null);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        [TestMethod]
        public void TestMethodFactoryResolving()
        {
            WindsorContainer container = SetupContainer();
            var factory = container.Resolve<ICommand2Factory>();
            var cmd = factory.Create<Person, List<Person>>("GetAll§Command");

        }
                                                  
        private  WindsorContainer SetupContainer()
        {
            var container = new WindsorContainer();
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;
            container.AddFacility<TypedFactoryFacility>();
            container.Install(FromAssembly.Containing<IWork>());

            container.Kernel.AddHandlerSelector(new HandlerCommandSelector("LoadTestAssembly.StandardWorker", "LoadTestAssembly.BusyWorker"));
            container.Kernel.AddHandlerSelector(new HandlerCommandSelector("LoadTestAssembly.UnknownWorker", "LoadTestAssembly.LazyWorker"));

            //        container.Register(
            //Classes
            //    .FromAssembly(Assembly.GetExecutingAssembly())
            //    .Where(Component.IsInSameNamespaceAs<ICommand>())
            //    .WithService.FirstInterface()
            //    .Unless(t => typeof(ICommand<,>).IsAssignableFrom(t)));


            container.Register(Component.For<WindsorContainer>().Instance(container));
            container.Register(Component.For<IRoot>().ImplementedBy<Root>());
            container.Register(Component.For<ICommandManager>().ImplementedBy<CommandManager>());

            container.Register(Component.For(typeof(IRepository<,>)).ImplementedBy(Type.GetType("WCExp.Test.BaseRepository`2")));

            container.Register(Component.For(typeof(ICommand)).ImplementedBy<WindsorCastleExperiments.Implementations.SimpleCommand>().Named("SimpleCommand"));
            //container.Register(Component.For(typeof(ICommand<object, object>)).ImplementedBy<WindsorCastleExperiments.Implementations.SimpleCommand>().Named("SimpleCommand"));
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(Type.GetType("WCExp.Test.GetAllCommand`2")).Named("GetAll§Command"));
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(Type.GetType("WCExp.Test.GetOneCommand`2")).Named("GetOnePersonCommand"));
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(Type.GetType("WCExp.Test.GetOneCommand`2")).Named("GetOneCatCommand"));

            //Registering with typeof
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(typeof(WindsorCastleExperiments.Implementations.DoNothingCommand<,>)));
            //Registering with Type.GetTypecontainer.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(typeof(WindsorCastleExperiments.Implementations.DoNothingCommand<,>)).Named("DoNothingCommand"));
            var type = Type.GetType("WindsorCastleExperiments.Implementations.GetAllCommand`2, WindsorCastleExperiments");
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(type).Named("GetAllCommandOriginal"));

            // tell Windsor that it should generate factory for me
            container.Register(Component.For<ICommand2Factory>()
                .AsFactory(new Command2Factory()));



            return container;
        }
    }
}
