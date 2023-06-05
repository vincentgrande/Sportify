namespace Sportify.Data.Models;

public class Play
{
    public int Id { get; set; }
    public DateTime Time { get; set; }
    public double Score { get; set; }
    
    public Event Event { get; set; }
    public Profile Player { get; set; }
}