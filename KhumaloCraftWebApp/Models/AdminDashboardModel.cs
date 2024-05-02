using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhumaloCraftWebApp.Models
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardModel 
    {
        public void OnGet()
        {
            // Add any necessary logic here
        }
    }
}
