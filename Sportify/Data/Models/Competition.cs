namespace Sportify.Data.Models;

public class Competition
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Place { get; set; }
    
    public Sport Sport { get; set; }
    public List<Event> Events { get; set; }
    public Profile Profile { get; set; }



}