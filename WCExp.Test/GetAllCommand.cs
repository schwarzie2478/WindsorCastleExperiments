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
    public class GetAllCommand<TEntity,TKey> :CommandBase, ICommand<object, List<TEntity>>
        where TEntity : class,IEntity<TKey>
        where TKey : struct
    {
        private IRepository<TEntity, TKey> _repo;
  

        public GetAllCommand( IRepository<TEntity, TKey> repo):base()
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


        public List<TEntity> Result
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
            Result = _repo.GetAll();
            return true;

        }

        public bool ExecuteAction(object input)
        {
            Result = _repo.GetAll();
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
