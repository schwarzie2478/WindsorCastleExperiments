using System.Collections.Generic;

namespace WCExp.Test
{
    public interface IRepository<TEntity,TKey> where TEntity:class
        where TKey :struct
    {
        List<TEntity> GetAll();
        TEntity Get(TKey key);
    }
}