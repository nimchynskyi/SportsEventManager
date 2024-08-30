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
    public int? LocationId { get; set; }

    [ForeignKey("OrganizerId")] public virtual ApplicationUser Organizer { get; set; }
    [ForeignKey("LocationId")] public virtual Venue Location { get; set; }
    public virtual ICollection<Team> Teams { get; set; }
    public virtual ICollection<Player> Players { get; set; }
    public virtual ICollection<EventPlayer> EventPlayers { get; set; }
    public virtual ICollection<EventTeam> EventTeams { get; set; }

    public Event()
    {
        // to prevent null references
        EventPlayers = new HashSet<EventPlayer>();
        EventTeams = new HashSet<EventTeam>();
    }
}