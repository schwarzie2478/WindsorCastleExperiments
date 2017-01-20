using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTestAssembly
{
    public interface IWork
    {
        string FirstName { get; }
        void WorkABit();
        void WorkALot();
    }
}
