namespace SportsEventManager.Models;

public class Venue
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int Capacity { get; set; }

    public virtual ICollection<Event> Events { get; set; }
}