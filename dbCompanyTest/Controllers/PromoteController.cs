using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Excel =Microsoft.Office.Interop.Excel;
using HtmlAgilityPack;
using System.Net;

namespace dbCompanyTest.Controllers
{
    public class PromoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WebGame()
        {
            return View();
        }
    }
}
