using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class CommandBase
    {
        public IRoot Root {
            get; set; }

        public CommandBase()
        {
        }
    }
}
