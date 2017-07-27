using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sseko.Akka.ReportGeneration.Messages;
using Sseko.BLL;
using Sseko.DAL.DocumentDb.Entities;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ServiceFactory factory = new ServiceFactory();

            var reportType = ReportGenerationOperations.ReportType.DownlineSummary;

            await factory.ReportService().GenerateReport(reportType);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
