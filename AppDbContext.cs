namespace ProjektBlazrow67273
{
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<rooms> rooms { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<reservations> reservations { get; set;}



    }
}