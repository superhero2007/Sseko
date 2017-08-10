using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Util.Internal;
using AutoMapper;
using Exceptionless;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;
using Sseko.DAL.DocumentDb.Models;
using Sseko.Web.Models;
using Sseko.Web.Utilities;

namespace Sseko.Web.Controllers
{   
    [Route("/api/users/")]
    public class UsersController : BaseController
    {
        [HttpGet]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var serviceFactory = new ServiceFactory();

                var request = await serviceFactory.UserService().GetAllAsync();

                if (request.IsError) throw request.Exception;

                var users = request.Output;

                var model = Mapper.Map<List<UserDto>>(users);
                return Json(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserForAuthDto model)
        {
            try
            {
                var userService = new ServiceFactory().UserService();

                var user = await userService.ValidateUser(model.Username, model.Password);

                if (user == null) return Unauthorized();

                var token = TokenManager.GenerateTokenAsync(user);
                return Json(new { token });
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> SendPasswordResetLink(string email)
        {
            try
            {
                var userService = new ServiceFactory().UserService();

                var user = await userService.GetByUserNameAsync(email);
                if (user == null) return StatusCode(204); //Don't reveal that this user does not exst

                //Invalidate the current password
                user.PasswordHash = string.Concat(user.PasswordHash, Guid.NewGuid().ToString());

                //Change the security stamp. This will force already authenticated users to logout
                //TODO: actually implement this feature
                user.SecurityStamp = Guid.NewGuid().ToString();

                user.PasswordResetDetails = new PasswordResetDetails();

                var request = await userService.UpsertAsync(user);

                if (request.IsError) throw request.Exception;

                //TODO: Send email
                return StatusCode(204);
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        public async Task<IActionResult> UpdatePassword([FromBody] UserForAuthDto model)
        {
            try
            {
                var userService = new ServiceFactory().UserService();

                if (!await userService.Exists(model.Username)) return StatusCode(404);

                var request = await userService.UpdatePassword(model.Username, model.Password);

                if (request.IsError) throw request.Exception;

                return StatusCode(204);
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }
    }
}
