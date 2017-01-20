using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCExp.Test
{
    public class IntegerRepository<TEntity> : IRepository<TEntity, int> where TEntity :class 
    {
        public IntegerRepository()
        {

        }

        public TEntity Get(int key)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
