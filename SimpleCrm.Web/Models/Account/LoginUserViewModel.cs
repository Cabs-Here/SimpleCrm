using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleCrm.Web.Models.Account
{
    public class LoginUserViewModel
    {
        [Required, MinLength(8), MaxLength(30), DataType(DataType.EmailAddress), DisplayName("Email Address")]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password), DisplayName("Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
