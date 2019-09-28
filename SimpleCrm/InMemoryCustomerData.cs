using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SimpleCrm
{
    public class InMemoryCustomerdata : ICustomerData
    {
        static IList<Customer> _customers;

        static InMemoryCustomerdata()
        {
            _customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "James", LastName = "Holden", PhoneNumber = "555-987-3214"},
                new Customer {Id = 2, FirstName = "Amos", LastName = "Burton", PhoneNumber = "555-654-4123"},
                new Customer {Id = 3, FirstName = "Naomi", LastName = "Nagata", PhoneNumber = "555-357-9827"},
                new Customer {Id = 4, FirstName = "Alex", LastName = "Kamal", PhoneNumber = "555-358-9371"},
                new Customer {Id = 5, FirstName = "Roberta", LastName = "Draper", PhoneNumber = "555-924-2497"},
                new Customer {Id = 6, FirstName = "Fred", LastName = "Johnson", PhoneNumber = "555-983-6819"}
            };
        }

        public Customer Get(int id)
        {
            return _customers.FirstOrDefault(customer => customer.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }

        public void Add(Customer customer)
        {
            customer.Id = _customers.Max(x => x.Id) + 1;
            _customers.Add(customer);
            
        }
        public void Update(Customer customer)
        {
            var old = _customers.FirstOrDefault(x => x.Id == customer.Id);
            _customers.Remove(old);
            _customers.Add(customer);
        }
    }
}
