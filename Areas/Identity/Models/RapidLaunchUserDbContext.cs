using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Areas.Identity.Models
{
    public class RapidLaunchUserDbContext : IdentityDbContext<ApplicationUser>
    {
        public RapidLaunchUserDbContext(DbContextOptions<RapidLaunchUserDbContext> options) : base(options) { }

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
        }
    }
}
