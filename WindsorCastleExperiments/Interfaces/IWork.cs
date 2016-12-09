using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindsorCastleExperiments.Interfaces
{
    public interface IWork
    {
        List<string> Input { get; set; }
        List<string> DoWork();
    }
}
