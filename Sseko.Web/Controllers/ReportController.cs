using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;
using Exceptionless;
using Microsoft.AspNetCore.Authorization;

namespace Sseko.Web.Controllers
{
    [Authorize]
    [Route("/api/reports/")]
    public class ReportsController : BaseController
    {
        [HttpGet("Downline")]
        public async Task<IActionResult> Downline()
        {
            try
            {
                var id = GetMagentoId();

                var serviceFactory = new ServiceFactory();

                var request = await serviceFactory.MagentoService().GetDownlineReport(id);

                if (!request.IsError)
                {
                    return Json(request.Output.Rows);
                }
                throw request.Exception;
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [HttpGet("PersonalVolume")]
        public async Task<IActionResult> PersonalVolume()
        {
            try
            {
                var id = GetMagentoId();

                var serviceFactory = new ServiceFactory();

                var request = await serviceFactory.MagentoService().GetPvSummaryReport(id);

                if (!request.IsError)
                {
                    return Json(request.Output.Rows);
                }
                throw request.Exception;
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }
    }
}
