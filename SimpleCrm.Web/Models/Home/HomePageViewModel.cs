using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm.Web.Models.Home
{
    public class HomePageViewModel
    {
        public string Message { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

    }
}
