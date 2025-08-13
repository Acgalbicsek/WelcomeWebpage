using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace WelcomeWebpage.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<AdminInfo> AdminInfos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder b)
        {
            var e = b.Entity<AdminInfo>();
            e.ToTable("admininfo");                    // exact table name
            e.Property(x => x.Id).HasColumnName("Id");
            e.Property(x => x.Name).HasColumnName("Name");
            e.Property(x => x.Email).HasColumnName("Email");
            e.Property(x => x.CreatedAt).HasColumnName("CreatedAt");   // <-- At
            e.Property(x => x.UpdatedAt).HasColumnName("UpdatedAt");   // <-- At
            e.Property(x => x.IsDeleted).HasColumnName("IsDeleted").HasColumnType("tinyint(1)");
            e.Property(x => x.DeletedAt).HasColumnName("DeletedAt");   // <-- At
        }
    }
}