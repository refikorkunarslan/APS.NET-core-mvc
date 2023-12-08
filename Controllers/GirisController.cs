using Microsoft.AspNetCore.Mvc;
using SGK.Models;
using System.Text.Encodings.Web;
using SGK.Data;


namespace SGK.Controllers
{
    public class GirisController : Controller
    {

        public IActionResult Index()
        {
            int hour = System.DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "iyi Akşamlar" : "iyi Sabahlar";
            return View();
        }
        [HttpGet]
        public IActionResult Kayit()
        {
            Response.Redirect("https://www.youtube.com/watch?v=0d6K5kS7zpE");
            return View();
        }
        [HttpPost]
        public IActionResult Kayit(vtd vtd)
        {
            return View();
        }
      


    }
}