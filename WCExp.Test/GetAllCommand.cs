using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorCastleExperiments.Interfaces;

namespace WCExp.Test
{
    public class GetAllCommand<Tin, TOut> : ICommand<Tin, TOut>
        where Tin : class
        where TOut : List<Tin>
    {
        private WindsorContainer _container;


        public GetAllCommand(WindsorContainer container)
        {
            _container = container;
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
            var repo = _container.Resolve<IRepository<Tin>>();
            Result =(TOut) repo.GetAll();
            return true;

        }

        public void ExecuteAction<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}
