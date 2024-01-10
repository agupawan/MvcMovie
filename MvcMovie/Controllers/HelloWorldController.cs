using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int count =1)
        {
            // HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.
            ViewData["name"] = name;
            ViewData["count"] = count;
            return View();
        }
    }
}
