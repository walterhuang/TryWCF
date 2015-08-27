using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CustomerManager.Models;

namespace CustomerManager.Service
{
    public class CustomerService : ICustomerService
    {
        private BusinessLogic.CustomerBLL customerBLL;

        public CustomerService()
        {
            customerBLL = new BusinessLogic.CustomerBLL();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Customer> GetCustomerList()
        {
            return customerBLL.GetCustomerList();
        }

    }
}
