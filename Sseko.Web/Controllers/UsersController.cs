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
                Console.WriteLine(e);
                throw;
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserForAuthDto model)
        {
            try
            {
                var userService = _serviceFactory.UserService();

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

        [AllowAnonymous]
        [HttpPost("SendResetPasswordLink")]
        public async Task<IActionResult> SendPasswordResetLink([FromBody] UserForPasswodResetDto model)
        {
            try
            {
                var userService = _serviceFactory.UserService();

                var user = await userService.SetPasswordReset(model.Email);
                if (user == null) return StatusCode(204); //Don't reveal that this user does not exst

                //TODO: Send email
                return StatusCode(204);
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [AllowAnonymous]
        [HttpPost("VerifyResetLink")]
        public async Task<IActionResult> VerifyResetLink([FromBody] UserForPasswodResetDto model)
        {
            try
            {
                var email = await _serviceFactory.UserService().VerifyResetLink(model.Code);

                if (string.IsNullOrWhiteSpace(email))
                    return StatusCode(404);
                return Json(new { email });
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [AllowAnonymous]
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetForgottenPassword([FromBody] UserForPasswodResetDto model)
        {
            try
            {
                var userService = _serviceFactory.UserService();

                var request = await userService.ResetPassword(model.Email, model.Password);

                if (request.IsError) throw request.Exception;

                return StatusCode(204);
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [HttpPost("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword([FromBody] UserForPasswodResetDto model)
        {
            try
            {
                var userService = _serviceFactory.UserService();

                var userId = GetId();

                var request = await userService.UpdatePassword(userId, model.Password);

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
