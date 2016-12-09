using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class ReverseOrder : IWork
    {
        public List<string> Input { get; set; }
        public List<string> DoWork()
        {
            var list = new List<string>();
            foreach (var inp in Input)
            {
                list.Insert(0,inp);
            }
            return list;
        }
    }
}
