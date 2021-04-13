using FSF.Login.Data;
using FSF.Login.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FSF.Login.Areas.Identity.IdentityHostingStartup))]
namespace FSF.Login.Areas.Identity
{
  public class IdentityHostingStartup : IHostingStartup
  {
    public void Configure(IWebHostBuilder builder)
    {
      builder.ConfigureServices((context, services) =>
      {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                context.Configuration.GetConnectionString("DefaultConnection")));
        services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
      });
    }
  }
}