using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTestAssembly
{
    public class BusyWorker : IWork, IBusy
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
            Debug.WriteLine("A busy worker can never work just a little bit");
        }

        public void WorkALot()
        {
            Debug.WriteLine("Finally I can get busy!");
        }
    }
}
