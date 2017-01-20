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
    public class GetOneCommand<TKey, TEntity> : CommandBase, ICommand<TKey, TEntity>
        where TKey : struct
        where TEntity : class
    {
        private IRepository<TEntity, TKey> _repo;


        public GetOneCommand(IRepository<TEntity, TKey> repo) : base()
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

        public TEntity Result
        {
            get; set;
        }

        public TKey Target
        {
            get; set;
        }

        public bool ExecuteAction()
        {
            Result = _repo.Get(Target);
            return true;

        }

        public bool ExecuteAction(TKey input)
        {
            Result = _repo.Get(input);
            return true;
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
