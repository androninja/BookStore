using BookStore.Data;
using BookStore.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //addDBContext
            builder.Services.AddDbContext<BookContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("bookConnection"))
            );

            builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<BookContext>();
            //midleware will be enable later

            //Service Lifetime
            //Wherever IbookRep. is being used instead provide the instance of MockBookRepository

            //to maintain state - Singleton Service Lefetime - Single object for full lifetime
            //builder.Services.AddSingleton<IBookRepository,MockBookRepostory> ();

            //One object per new client
            //builder.Services.AddSCoped<IBookRepository,MockBookRepostory> ();

            //to have new object for each request - Here add books does not work as when we visit the list page it creates a new object and only displays the initialliy added books from code
            //builder.Services.AddTransient<IBookRepository,MockBookRepostory> ();


            //Usinf EF core
            builder.Services.AddTransient<IBookRepository,BookSQLRepository> ();

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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.MapControllerRoute(
               name: "books",
               pattern: "{controller=Books}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}



//Notes


//In older MVC
// To create Web Forms - Using Html Helper classes to create forms/models
//we needed to use razor syntax

//In asp.net core MVC
//Html Helper are replaced by Tag Helpers
//They can create Forms, Links, load assets
//Tag helper enable server side code to participate in creating HTMl elements in Razor files
