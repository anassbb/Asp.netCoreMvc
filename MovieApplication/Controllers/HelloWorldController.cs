using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcom(string name, int newTime=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NewTime is :  {newTime}");
        }
    }
}
