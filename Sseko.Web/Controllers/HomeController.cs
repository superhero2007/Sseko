using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;

namespace Sseko.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
