using Microsoft.AspNetCore.Identity;

namespace Article.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<Guid>
{
    public string Name { get; set; } = string.Empty;
}

