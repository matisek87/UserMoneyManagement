using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Interfaces;

namespace UserMoneyManagement.Models
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext context;

        public SQLCustomerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Customer Add(Customer customer)
        {

            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer != null)
            {
                context.Remove(customer);
                context.SaveChanges();
            }
           
            return customer;
            
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customers;
        }

        public Customer GetCustomer(int id)
        {
            return context.Customers.Find(id);
        }

        public Customer Update(Customer customerChange)
        {
            throw new NotImplementedException();
        }
    }
}
