using System.Collections.Generic;

namespace WCExp.Test
{
    public interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAll();
    }
}