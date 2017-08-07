using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sseko.Web.Controllers
{
    public class BaseController : Controller
    {
        public string GetId()
        {
            var token = HttpContext.Request.Cookies["Token"];

            return "";
        }

        public int GetMagentoId()
        {
            var token = HttpContext.Request.Cookies["Token"];

            return 1104;
        }
    }
}
