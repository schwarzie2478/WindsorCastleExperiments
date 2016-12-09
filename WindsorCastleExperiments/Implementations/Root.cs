using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class Root : IRoot
    {
        public ICommandManager CommandManager
        {
            get; set;
        }
    }
}
