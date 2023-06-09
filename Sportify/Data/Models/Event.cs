namespace Sportify.Data.Models;

public class Event
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    
    public Competition Competition { get; set; }
    public List<Play>? Plays { get; set; }
    public Constraint? Constraint { get; set; }



}