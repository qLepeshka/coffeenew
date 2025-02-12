using Microsoft.AspNetCore.Identity;

namespace CoffeeNew.Models
{
    public class User : IdentityUser
    {
        public DateTime Created { get; set; }
    }
}
