using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.DataAccess
{
    public class CustomerDAL
    {
        public List<Models.Customer> GetCustomerList()
        {
            return new List<Models.Customer>
            {
                new Models.Customer { Id = 1, FirstName = "GI", LastName = "Joe" },
                new Models.Customer { Id = 1, FirstName = "Mike", LastName = "Oil" },
                new Models.Customer { Id = 1, FirstName = "C", LastName = "P" },
            };
        }
    }
}
