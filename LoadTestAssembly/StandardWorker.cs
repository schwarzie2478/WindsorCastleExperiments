using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTestAssembly
{
    public class StandardWorker : IWork
    {
        public StandardWorker()
        {
            FirstName = "Anomynous";
        }
        public StandardWorker(string firstName)
        {
            FirstName = firstName;
        }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value;
            }
        }

        public void WorkABit()
        {
            Debug.WriteLine("Working a bit");
            System.Threading.Thread.Sleep(200);
        }

        public void WorkALot()
        {
            Debug.WriteLine("Working a lot");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
