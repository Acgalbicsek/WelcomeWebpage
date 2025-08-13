using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using WelcomeWebpage.Models;
using WelcomeWebpage.Services;




namespace WelcomeWebpage
{
    public class Program
    {
        public static void Main(string[] args)

        {
            
            var builder = WebApplication.CreateBuilder(args);
            var cs = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseMySql(cs, ServerVersion.AutoDetect(cs)));

            builder.Services.AddHttpClient();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<WeatherServices>();
            builder.Services.AddSession();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
       
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Weather}/{action=Index}/{id?}");
                

            app.Run();
        }
    }
}
