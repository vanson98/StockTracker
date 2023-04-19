namespace StockTracker.DbContext;

using Microsoft.EntityFrameworkCore;
using StockTracker.Entities;

public class ApplicationDbContext : DbContext{
     
    protected readonly IConfiguration Configuration;
    
    public ApplicationDbContext(IConfiguration configuration){
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // connect to mysql with connection string from app settings
        var connectionString = Configuration.GetConnectionString("MySqlDb");
        optionsBuilder.UseMySQL(connectionString) ;
    }

    public DbSet<User> Users {get;set;}

}