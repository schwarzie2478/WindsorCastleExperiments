using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.AlternativeImplementations
{
    public class DoAlmostNothingCommand<Tin, Tout> : ICommand<Tin, Tout>
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

        public Tout Result
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

        public Tin Target
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

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
