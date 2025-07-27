using Microsoft.AspNetCore.Identity;

namespace HymnStocks.Areas
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }  
        public string? LastName { get; set; }
        public string? FromChurch { get; set; }
    }
}
