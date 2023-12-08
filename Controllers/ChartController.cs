using Microsoft.AspNetCore.Mvc;
using SGK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGK.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VisaulizeProductResult()
        {
            return Json(Prolist());
        }
        public List<class11> Prolist()
        {
            List<class11> cs = new List<class11>();
            cs.Add(new class11()
            {
                proname = "Yazılım",
                stock = 150
            });
            cs.Add(new class11()
            {
                proname = "veri girişi",
                stock = 75
            });
            cs.Add(new class11()
            {
                proname = "yönetim hizmetleri",
                stock = 220
            });
            return cs;


        }

    }
}
