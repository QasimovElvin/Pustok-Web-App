using Microsoft.EntityFrameworkCore;
using Pustok_Web_App.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]));

var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
    );
});

app.MapDefaultControllerRoute();

app.Run();
