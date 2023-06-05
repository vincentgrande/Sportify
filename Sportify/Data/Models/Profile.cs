using Microsoft.AspNetCore.Identity;

namespace Sportify.Data.Models;

public class Profile : IdentityUser
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool? Sex { get; set; }
    
    public List<Competition>? Competitions { get; set; }
    public List<Play>? Plays { get; set; }

  
}