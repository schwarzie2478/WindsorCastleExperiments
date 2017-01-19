    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class DoNothingCommand<Tin, Tout> : CommandBase, ICommand<Tin, Tout>
    {
        public DoNothingCommand():base()
        {

        }
        public bool HasExecuted
        {
            get; set;
        }

        public bool IsSucceeded
        {
            get; set;
        }




        public Tout Result
        {
            get
            {
                return default(Tout);
            }

            set
            {

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
                
            }
        }

        public bool ExecuteAction()
        {

            HasExecuted = true;
            IsSucceeded = true;

            return true;
        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
