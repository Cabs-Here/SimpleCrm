using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SimpleCrm.SqlDbServices
{
    public class SqlCustomerData : ICustomerData
    {
        private readonly SimpleCrmDbContext context;

        public SqlCustomerData(SimpleCrmDbContext context)
        {
            this.context = context;
        }
        public Customer Get(int id)
        {
            return context.Customers.FirstOrDefault(customer => customer.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Save(Customer customer)
        {
            
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
