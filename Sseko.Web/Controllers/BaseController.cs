using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sseko.Web.Utilities;

namespace Sseko.Web.Controllers
{
    public class BaseController : Controller
    {
        protected string GetId()
        {
            var encodedToken = HttpContext.Request.Cookies["token"];

            var token = encodedToken.Decode();

            return token.Id;
        }

        protected int GetMagentoId()
        {
            var encodedToken = HttpContext.Request.Cookies.FirstOrDefault(c => c.Key == "token").Value;

            var token = encodedToken.Decode();

            return token.MagentoId;
        }
    }
}
