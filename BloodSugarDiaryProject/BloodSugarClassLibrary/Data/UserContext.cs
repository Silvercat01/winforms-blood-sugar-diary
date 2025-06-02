using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using BloodSugarClassLibrary.Models;

namespace BloodSugarClassLibrary.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Measurements> Measurements { get; set; } = null!;
        public UserContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BloodSugarDiary;Integrated Security=True;")
                    .LogTo(message => Debug.WriteLine(message), LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User - Patient 1:0..1 kapcsolat
            modelBuilder.Entity<User>()
                .HasOne(u => u.Patient)
                .WithOne(p => p.User)
                .HasForeignKey<Patient>(p => p.UserId);

            // User - Measurements 1:n kapcsolat
            modelBuilder.Entity<User>()
                .HasMany(u => u.Measurements)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Unique constraint a felhasználónévre
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}