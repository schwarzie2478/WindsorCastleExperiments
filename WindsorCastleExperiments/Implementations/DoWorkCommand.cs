using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class DoWorkCommand<Tout> : ICommand<IWork, Tout>
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
            get; set;
        }

        public IWork Target
        {
            get; set;
        }

        public bool ExecuteAction()
        {
            
            Target.DoWork();
            return true;
        }
    }
}
