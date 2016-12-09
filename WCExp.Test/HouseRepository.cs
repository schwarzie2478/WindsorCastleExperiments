using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCExp.Test
{
    public class HouseRepository : IHouseRepository
    {
        List<Person> IRepository<Person>.GetAll()
        {
            return new List<Person>();
        }
    }
}
