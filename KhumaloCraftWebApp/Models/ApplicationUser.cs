using Microsoft.AspNetCore.Identity;

namespace KhumaloCraftWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property for shopping cart
        public ShoppingCart ShoppingCart { get; set; }
    }
}
