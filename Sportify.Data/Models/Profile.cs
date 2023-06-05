namespace Sportify.Data.Models;

public class Profile
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public bool Sex { get; set; }
}