namespace StockTracker.Entities;

public class User
{
    public int Id {get;set;}
    public string UserName { get; set; }
    public string PassHash { get; set; }
    public string PassSalt { get; set; }
}