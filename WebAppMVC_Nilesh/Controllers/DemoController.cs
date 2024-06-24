using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Implementation;
using WebAppMVC_Nilesh.Models;

namespace WebAppMVC_Nilesh.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Add()
        {
            int x = 45, y = 45, z;
            z = x + y;
            ViewData["res"] = z;
            return View();
        }

        [HttpGet]  // on load
        public IActionResult Sub()
        {
            ViewData["res"] = "No Result on Load";
            return View();
        }

        [HttpPost]  // on click
        public IActionResult Sub(string s)
        {
            int x = Convert.ToInt32(Request.Form["txt1"].ToString());
            int y = Convert.ToInt32(Request.Form["txt2"].ToString());
            int z = x - y;
            ViewData["res"] = " Result on Click :" + z;
            return View();
        }

        [HttpGet]  // on load
        public IActionResult Mul()
        {
            ViewData["res"] = "No Result on Load";
            return View();
        }

        [HttpPost]  // on load
        public IActionResult Mul(MyModel obj)
        {
            int z = obj.x * obj.y;
            ViewData["res"] = " Result on Click:"+z;
            return View();
        }




    }
}
