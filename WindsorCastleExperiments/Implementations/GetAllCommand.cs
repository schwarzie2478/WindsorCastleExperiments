using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindsorCastleExperiments.Interfaces;

namespace WindsorCastleExperiments.Implementations
{
    public class GetAllCommand<Tin, TOut> :CommandBase, ICommand<Tin, TOut>
        where Tin : class
        where TOut : List<Tin>
    {

  

        public GetAllCommand( ):base()
        {
        }
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

        public TOut Result
        {
            get;set;
        }
       
        public Tin Target
        {
            get; set;
        }

        public bool ExecuteAction()
        {        
            Result =(TOut) new List<Tin>();
            return true;

        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
