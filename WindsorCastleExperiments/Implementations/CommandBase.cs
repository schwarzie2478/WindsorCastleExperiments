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
        protected IRoot _root;

        public CommandBase(IRoot root)
        {
            _root = root;
        }
    }
}
