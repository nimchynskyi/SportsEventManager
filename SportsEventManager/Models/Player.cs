using SportsEventManager.Data;

namespace SportsEventManager.Models;

public class Player
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
    public DateOnly? DateOfBirth { get; set; }

    public string Position { get; set; }
    public int? TeamId { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual Team Team { get; set; }
    public ICollection<EventPlayer> EventPlayers { get; set; }

    public string Biography { get; set; }
    public bool IsActive { get; set; }
}