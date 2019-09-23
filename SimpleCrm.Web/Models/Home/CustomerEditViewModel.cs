using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm.Web.Models.Home
{
    public class CustomerEditViewModel
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required()]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [MinLength(1), MaxLength(50)]
        [Required()]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        [MinLength(7), MaxLength(12)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Newsletter Opt In")]
        public bool OptInNewsletter { get; set; }
        [Display(Name = "Customer Type")]
        [Required()]
        public CustomerType Type { get; set; }
    }
}
