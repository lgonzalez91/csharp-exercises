using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        // GET: /<controller>/

        static private List<string> Cheeses = new List<string>();

        public IActionResult Index()
        {

            ViewBag.cheeses = Cheeses; 

            return View(); 
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name)
        {
            //Add New Cheese to existing list
            Cheeses.Add(name);

            return Redirect("/Cheese");
        }
    }
}
