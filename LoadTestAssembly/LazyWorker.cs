using LoadTestAssembly.IOC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTestAssembly
{
    public class LazyWorker :  IWork, ILazy
    {
        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void WorkABit()
        {
            Debug.WriteLine("Working a bit is too much for me already!");
        }

        public void WorkALot()
        {
            throw new NotImplementedException();
        }
    }
}
