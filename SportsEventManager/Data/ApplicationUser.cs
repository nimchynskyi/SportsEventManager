using Microsoft.AspNetCore.Identity;

namespace SportsEventManager.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public DateOnly? DateOfBirth { get; set; }
}