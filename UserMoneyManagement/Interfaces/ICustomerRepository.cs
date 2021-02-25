using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Models;

namespace UserMoneyManagement.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomers();
        Customer Add(Customer customer);
        Customer Update(Customer customerChange);
        Customer Delete(int id);

    }
}
