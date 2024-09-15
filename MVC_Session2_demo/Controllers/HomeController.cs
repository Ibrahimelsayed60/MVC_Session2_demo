using Microsoft.AspNetCore.Mvc;

namespace MVC_Session2_demo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = "Hello from content result";

        //    //return Redirect("/Home/AboutUs");

        //    return Content("Hello from content result");
        //}

        //public string AboutUs()
        //{
        //    return "This is About us action";
        //}


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
