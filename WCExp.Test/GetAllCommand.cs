using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Implementations;
using WindsorCastleExperiments.Interfaces;

namespace WCExp.Test
{
    public class GetAllCommand<Tin, TOut> :CommandBase, ICommand<Tin, TOut>
        where Tin : class
        where TOut : List<Tin>
    {
        private IRepository<Tin> _repo;
  

        public GetAllCommand(IRoot root, IRepository<Tin> repo):base(root)
        {
            _repo = repo;
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
            Result =(TOut)_repo.GetAll();
            return true;

        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
