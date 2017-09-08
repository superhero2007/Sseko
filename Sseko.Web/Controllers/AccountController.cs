using System;
using System.Threading.Tasks;
using Exceptionless;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sseko.BLL;
using Sseko.Web.Models;
using Sseko.Web.Utilities;

namespace Sseko.Web.Controllers
{
    [Route("/api/account/")]
    public class AccountController : BaseController
    {
        private ServiceFactory _serviceFactory;

        public AccountController()
        {
            _serviceFactory = new ServiceFactory();
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
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] UserForSignUpDto model)
        {
            try
            {
                if (model == null) return BadRequest();

                var userService = _serviceFactory.UserService();

                var user = await userService.GetByUserNameAsync(model.Username);

                var request = await userService.UpdatePassword(user.Id, model.Password);

                if (request.IsError) throw request.Exception;

                return Ok();
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

        [HttpPost("Impersonate")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ImpersonateUser([FromBody] UserForImpersonationDto model)
        {
            try
            {
                var userService = _serviceFactory.UserService();

                //Just validate that the requested user to impersonate exists
                var request = await userService.GetAsync(model.UserToImpersonateId);

                if (request.IsError) throw request.Exception;

                request = await userService.GetAsync(model.UserImpersonatingId);

                if (request.IsError) throw request.Exception;

                var token = TokenManager.GenerateTokenAsync(request.Output, model.UserToImpersonateId);

                return Json(new { token });
            }
            catch (Exception e)
            {
                e.ToExceptionless().Submit();
                return StatusCode(500);
            }
        }

        [HttpPost("AdminResetPassword")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> SendPasswordResetLink([FromBody] string userId)
        {
            try
            {
                var userService = _serviceFactory.UserService();

                var request = await userService.SetPasswordResetById(userId);

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
