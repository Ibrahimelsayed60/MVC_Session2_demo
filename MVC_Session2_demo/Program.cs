namespace MVC_Session2_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("you are in home page");
                });

                endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("you are at product page");
                });
            });

            app.Run(async(HttpContext)=> { await HttpContext.Response.WriteAsync("Your Requested page not found"); });

            //app.MapGet("/Home", () => "Hello World!");
           

            app.Run();
        }
    }
}
