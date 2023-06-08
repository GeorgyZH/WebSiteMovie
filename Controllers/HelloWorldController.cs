using Microsoft.AspNetCore.Mvc;

namespace WebSiteMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
