using Microsoft.AspNetCore.Routing.Constraints;

namespace session1
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var WebApplicationBuilder = WebApplication.CreateBuilder(args);
            #region Configure Services
            WebApplicationBuilder.Services.AddControllersWithViews();
            #endregion
            var app = WebApplicationBuilder.Build();
            #region Configure
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/Student{name}", async context=>
            //{
            //  //  var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");
            //});
            app.MapControllerRoute(
                
                name: "default",
                pattern: "{controller}/{action}/{id?}",
                defaults: new { controller = "Movies", action = "Index" }
                // constraints: new { id=@"\d{2}" }
                );
            app.Run();
            //    app.UseEndpoints(endpoints =>
            //     {
            //         endpoints.MapGet("/", async context =>
            //         { 
            //            await context.Response.WriteAsync("Hello World!");
            //     });
            //});
            #endregion

        }    
    }
}
