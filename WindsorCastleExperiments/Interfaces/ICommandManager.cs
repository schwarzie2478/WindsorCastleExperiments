using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Interfaces
{
    public interface ICommandManager
    {
        ICommand CreateCommand(string key);
        ICommand<Tin, Tout> CreateCommand<Tin, Tout>(string key);
        Tout ExecuteCommand<Tin, Tout>(ICommand<Tin, Tout> command, Tin tin);
        object ExecuteCommand(ICommand command, object tin);
    }

}
