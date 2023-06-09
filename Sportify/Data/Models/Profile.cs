using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Sportify.Data.Models;

public class Profile 
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool? Sex { get; set; }
    
    public List<Competition>? Competitions { get; set; }
    public List<Play>? Plays { get; set; }

    
    [ForeignKey("AspNetUser")]
    public string AspNetUserId { get; set; }
    public virtual IdentityUser AspNetUser { get; set; }
  
}