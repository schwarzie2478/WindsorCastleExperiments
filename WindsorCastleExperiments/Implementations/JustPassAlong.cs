using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class JustPassAlong : IWork
    {
        public List<string> Input
        {
            get; set;
        }


        public List<string> DoWork()
        {
            return Input;
        }
    }
}
