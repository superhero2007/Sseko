using Microsoft.AspNetCore.Mvc;
using SsekoWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SsekoWeb.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Login()
        {
            var token = TokenManager.GenerateTokenAsync();
            return new JsonResult(new { token = token });
        }
    }
}
