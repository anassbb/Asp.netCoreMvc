using Microsoft.AspNetCore.Mvc;

namespace MovieApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hey you";
        }
    }
}
