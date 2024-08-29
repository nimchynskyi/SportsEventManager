using SportsEventManager.Data;

namespace SportsEventManager.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CoachId { get; set; }
    public DateTime CreatedDate { get; set; }

    public virtual ApplicationUser Coach { get; set; }
    public virtual ICollection<Player> Players { get; set; }
}