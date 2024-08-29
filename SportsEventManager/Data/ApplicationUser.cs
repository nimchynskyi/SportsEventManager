using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SportsEventManager.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [StringLength(50)] public string? FirstName { get; set; }
    [StringLength(50)] public string? LastName { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    
    public bool IsOrganizer { get; set; }
    public bool IsPlayer { get; set; }
    public bool IsCoach { get; set; }
}