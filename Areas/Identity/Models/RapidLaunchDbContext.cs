using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RapidLaunch.Models;

namespace RapidLaunch.Areas.Identity.Models
{
    public class RapidLaunchDbContext : IdentityDbContext<ApplicationUser>
    {
        public RapidLaunchDbContext(DbContextOptions<RapidLaunchDbContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentHistory> DepartmentHistories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Launch> Launches { get; set; }
        public DbSet<LaunchOrbit> LaunchOrbits { get; set; }
        public DbSet<LaunchPad> LaunchPads { get; set; }
        public DbSet<LaunchSite> LaunchSites { get; set; }
        public DbSet<LaunchStatus> LaunchStatuses { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<PayHistory> PayHistories { get; set; }
        public DbSet<PayRate> PayRates { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Rocket> Rockets { get; set; }
        public DbSet<RocketCategory> RocketCategories { get; set; }
        public DbSet<RocketModel> RocketModels { get; set; }
        public DbSet<RocketModelLink> RocketModelLinks { get; set; }
        public DbSet<RocketStatus> RocketStatuses { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbQuery<LaunchHistory> LaunchHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("tblUser");
            });

            builder.Entity<IdentityRole>(b =>
            {
                b.ToTable("tblRole");
            });

            builder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("tblUserRole");
            });

            builder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("tblUserClaim");
            });

            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("tblUserLogin");
            });

            builder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("tblUserToken");
            });

            builder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("tblRoleClaim");
            });

            builder.Entity<RocketModel>()
                .HasOne(r => r.Manufacturer)
                .WithMany(m => m.RocketModels)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RocketModel>()
                .HasOne(r => r.RocketCategory)
                .WithMany(r => r.RocketModels)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Launch>()
                .HasOne(l => l.Rocket)
                .WithMany(r => r.Launches)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Launch>()
                .HasOne(l => l.LaunchPad)
                .WithMany(l => l.Launches)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<LaunchPad>()
                .HasMany(p => p.Launches)
                .WithOne(l => l.LaunchPad)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Rocket>()
                .HasMany(r => r.Launches)
                .WithOne(l => l.Rocket)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<DepartmentHistory>()
                .HasOne(d => d.Staff)
                .WithMany(s => s.DepartmentHistories)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DepartmentHistory>()
                .HasOne(d => d.Department)
                .WithMany(d => d.DepartmentHistories)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DepartmentHistory>()
                .HasOne(d => d.Shift)
                .WithMany(s => s.DepartmentHistories)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DepartmentHistory>()
                .HasKey(o => new { o.StaffID, o.DepartmentID, o.ShiftID });

            builder.Entity<PayHistory>()
                .HasKey(o => new { o.StaffID, o.PayDate });

            builder.Entity<RocketModelLink>()
                .HasKey(o => new { o.ProviderID, o.RocketModelID });

            builder.Query<LaunchHistory>().ToView("LaunchHistoryByYear");
        }
    }
}
