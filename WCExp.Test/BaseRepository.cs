using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCExp.Test
{
    public class BaseRepository<Tin,TKey> : IRepository<Tin, TKey> where Tin :class,new()
        where TKey: struct
    {
        public Tin Get(TKey key)
        {
            return new Tin();
        }

        public List<Tin> GetAll()
        {
            return new List<Tin>();
        }

    }
}
