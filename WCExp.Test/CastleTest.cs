using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using WindsorCastleExperiments.Interfaces;
using WindsorCastleExperiments.Implementations;
using System.Diagnostics;
using System.Collections.Generic;

namespace WCExp.Test
{
    [TestClass]
    public class CastleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindsorContainer container = SetupContainer();


            var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand<string, string>("DoNothingCommand");
            Debug.WriteLine(((object)cmd).GetType().FullName);
            var result = root.CommandManager.ExecuteCommand<string, string>(cmd, "InputValue");

            Assert.IsTrue(cmd.IsSucceeded);

        }
        [TestMethod]
        public void TestMethod2()
        {
            WindsorContainer container = SetupContainer();

            var root = container.Resolve<IRoot>();
            var cmd = root.CommandManager.CreateCommand<IRepository<Person>, List<Person>>("GetAllCommand");



        }

        private static WindsorContainer SetupContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<WindsorContainer>().Instance(container));
            container.Register(Component.For<IRoot>().ImplementedBy<Root>());
            container.Register(Component.For<ICommandManager>().ImplementedBy<CommandManager>());
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(typeof(DoNothingCommand<,>)).Named("DoNothingCommand"));
            container.Register(Component.For(typeof(ICommand<,>)).ImplementedBy(typeof(GetAllCommand<,>)).Named("GetAllCommand"));
            container.Register(Component.For<Person>().ImplementedBy<Person>());
            container.Register(Component.For(typeof(IRepository<Person>)).ImplementedBy(typeof(HouseRepository)));
            return container;


            /*
            .DynamicParameters(
                (k, d) =>
                {
                    d["container"] = container;
                })
            */
        }
    }
}
