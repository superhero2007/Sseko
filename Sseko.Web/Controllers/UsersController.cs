using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Exceptionless;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;
using Sseko.Web.Models;
using Sseko.Web.Utilities;

namespace Sseko.Web.Controllers
{
    [Route("/api/users/")]
    public class UsersController : BaseController
    {
        private ServiceFactory _serviceFactory;

        public UsersController()
        {
            _serviceFactory = new ServiceFactory();
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var request = await _serviceFactory.UserService().GetAllAsync();

                if (request.IsError) throw request.Exception;

                var users = request.Output;

                var model = Mapper.Map<List<UserDto>>(users);
                return Json(model);
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [HttpGet("ToggleEnabled/{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ToggleEnabled(string id)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(id)) return BadRequest();

                var request = await _serviceFactory.UserService().GetAsync(id);

                if (request.IsError) throw request.Exception;

                var user = request.Output;

                if(user == null) return NotFound();

                user.Enabled = !user.Enabled;

                request = await _serviceFactory.UserService().UpsertAsync(user);

                if (request.IsError) throw request.Exception;

                return Ok();
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }
    }
}
