using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.BusinessLogic
{
    public class CustomerBLL
    {
        private DataAccess.CustomerDAL customerDAL;

        public CustomerBLL()
        {
            customerDAL = new DataAccess.CustomerDAL();
        }

        public List<Models.Customer> GetCustomerList()
        {
            return customerDAL.GetCustomerList();
        }
    }
}
