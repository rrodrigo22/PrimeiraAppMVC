using Microsoft.AspNetCore.Mvc;
using PrimeiraAppMVC.Models;
using System.Diagnostics;

namespace PrimeiraAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int[] nm = new int[5];
            int[] estr = new int[2];
            
            Random rnd = new Random();

            int num;
            int str;

            for (int i = 0; i < 5; i++)
            {
               do
               {
                    num = rnd.Next(1, 51);
               } 
                while (nm.Contains(num)) ;
                    nm[i] = num;
            }


            for (int i = 0; i < 2; i++)
            {
                do
                {
                    str = rnd.Next(1, 13);
                } while (estr.Contains(str));
                    estr[i] = str;                     
            }


            ViewBag.numero = string.Join(",", nm);
            ViewBag.estrela = string.Join(",", estr);



            //ViewBag.Hour = "Boa noite!";
            //if (DateTime.UtcNow.Hour <=19)
            //{
            //    ViewBag.Hour = "Bom dia!";
            //}
            return View("MyView");

            //Conclusão da ficha
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}