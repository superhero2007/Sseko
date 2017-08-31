using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;

namespace Sseko.Web.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var serviceFactory = new ServiceFactory();

            await serviceFactory.UserService().UpdateFellows();

            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }
    }
}
