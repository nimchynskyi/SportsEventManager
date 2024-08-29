using System.ComponentModel.DataAnnotations.Schema;
using SportsEventManager.Data;

namespace SportsEventManager.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string SportType { get; set; }
    public decimal? EntryFee { get; set; }

    public bool HasScore { get; set; }
    public int AttendeeCount { get; set; }

    public string OrganizerId { get; set; }

    [ForeignKey("OrganizerId")] public virtual ApplicationUser Organizer { get; set; }
}