using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC_Session2_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("you are in home page");
            //    });



            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var id = context.Request.RouteValues["id"];

            //        if(id is not null)
            //        {
            //            int data = Convert.ToInt32(id);
            //            await context.Response.WriteAsync($"you are at product page id => {data}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("you are at product page");
            //        }



            //    });




            //    endpoints.MapGet("/Books/{ID}/{Auther:alpha:minlength(5):maxlength(10)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Auther"].ToString();
            //        await context.Response.WriteAsync($"you are at Book page id => {id}, by Author => {name}");
            //    });
            //}); 
            #endregion

            app.MapControllerRoute(
                name:"default",
                pattern: "/{Controller = Home}/{Action = Index}",
                defaults: new {Controller = "Home", Action = "Index" }
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller = Home}/{Action = AboutUs}",
                defaults: new { Controller = "Home", Action = "AboutUs" }
                );

            //app.Run(async(HttpContext)=> { await HttpContext.Response.WriteAsync("Your Requested page not found"); });

            //app.MapGet("/Home", () => "Hello World!");


            app.Run();
        }
    }
}
