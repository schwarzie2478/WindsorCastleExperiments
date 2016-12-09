using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class DoNothingCommand<Tin, Tout> : ICommand<Tin, Tout>
    {
        public bool HasExecuted
        {
            get; set;
        }

        public bool IsSucceeded
        {
            get; set;
        }




        Tout ICommand<Tin, Tout>.Result
        {
            get
            {
                return default(Tout);
            }

            set
            {

            }
        }

        Tin ICommand<Tin, Tout>.Target
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
    }
}
