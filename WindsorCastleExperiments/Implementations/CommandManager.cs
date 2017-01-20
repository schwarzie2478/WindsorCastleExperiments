using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class CommandManager: ICommandManager
    {
        private WindsorContainer _container;
        public CommandManager(WindsorContainer container)
        {
            _container = container;
        }
        public ICommand<Tin, Tout> CreateCommand<Tin, Tout>(string key)
        {
            return _container.Resolve<ICommand<Tin, Tout>>(key);
        }
        public ICommand CreateCommand(string key)
        {
            throw new NotImplementedException();
        }


        public Tout ExecuteCommand<Tin, Tout>(ICommand<Tin, Tout> command, Tin tin)
        {
            
            try
            {
                command.ExecuteAction(tin);
            }
            catch (Exception)
            {
                command.HasExecuted = true;
                command.IsSucceeded = false;
                return default(Tout);
            }

            return command.Result;
        }

        public object ExecuteCommand(ICommand command, object tin)
        {
            throw new NotImplementedException();
        }
    }
}
