using Microsoft.AspNetCore.Identity;

namespace EMSApi.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        // user name and password
    }

}
