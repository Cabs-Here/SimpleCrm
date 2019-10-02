using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm.Web.Models.Account
{
    public class RegisterUserViewModel
    {
        [Required, MinLength(8),MaxLength(30), DisplayName("Email Address")]
        public string UserName { get; set; }
        [Required, MaxLength(256), DisplayName("Name")]
        public string DisplayName { get; set; }
        [Required, DataType(DataType.Password), DisplayName("Password")]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
