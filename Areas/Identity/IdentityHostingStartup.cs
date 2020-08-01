using System;
using Avondale_College.Areas.Identity.Data;
using Avondale_College.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Avondale_College.Areas.Identity.IdentityHostingStartup))]
namespace Avondale_College.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AvondaleCollegeDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AvondaleCollegeDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AvondaleCollegeDbContext>();
            });
        }
    }
}