namespace SportsEventManager.Models;

public class EventPlayer
{
    public int EventId { get; set; }
    public int PlayerId { get; set; }
    public decimal? Score { get; set; }
    public int? Rank { get; set; }

    public virtual Event Event { get; set; }
    public virtual Player Player { get; set; }
}