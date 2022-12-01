using Microsoft.EntityFrameworkCore;
using TrackOrders.Models;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options)
            : base(options)
    {
    }

    public DbSet<TrackOrder> TrackOrders { get; set; }
}