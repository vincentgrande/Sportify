namespace Sportify.Data.Models;

public class Constraint
{
    public int Id { get; set; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
    public int MaxParticipants { get; set; }
    public bool Sex { get; set; }
}