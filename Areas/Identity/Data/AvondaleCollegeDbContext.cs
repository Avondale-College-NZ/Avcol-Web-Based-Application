using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avondale_College.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Avondale_College.Data
{
    public class AvondaleCollegeDbContext : IdentityDbContext<ApplicationUser>
    {
        public AvondaleCollegeDbContext(DbContextOptions<AvondaleCollegeDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
