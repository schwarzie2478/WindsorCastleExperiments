using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Interfaces
{
    public interface ICommand2Factory
    {
        ICommand<Tin, Tout> Create<Tin, Tout>(string key);
        void Release<Tin,Tout>(ICommand<Tin, Tout> instance);
    }
}
