using Microsoft.EntityFrameworkCore;
using OfficeApp.Domain;

namespace OfficeApp.Data
{
    public class OfficeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = OfficeAppData");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPermission>().HasKey(userPerm =>
            new { userPerm.UserId, userPerm.PermissionId });
            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .HasColumnName("Id");
            modelBuilder.Entity<Task>();
            modelBuilder.Entity<Office>();
            modelBuilder.Entity<Permission>()
                .Property(p => p.PermissionId)
                .HasColumnName("Id");
        }
    }
}
