using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class SimpleCommand : ICommand
    {
        public bool HasExecuted
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSucceeded
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public object Result
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public object Target
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ExecuteAction()
        {
            throw new NotImplementedException();
        }

        public bool ExecuteAction(object input)
        {
            throw new NotImplementedException();
        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }

        public bool ExecuteAction<T1, T2>(T1 input, out T2 output)
        {
            throw new NotImplementedException();
        }
    }
}
