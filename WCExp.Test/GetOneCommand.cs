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
    public class GetOneCommand<Tin, TOut> : CommandBase, ICommand<Tin, TOut>
        where Tin : struct
        where TOut : class
    {
        private IRepository<TOut, Tin> _repo;


        public GetOneCommand(IRepository<TOut, Tin> repo) : base()
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
            get; set;
        }

        public Tin Target
        {
            get; set;
        }

        public bool ExecuteAction()
        {
            Result = _repo.Get(Target);
            return true;

        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
