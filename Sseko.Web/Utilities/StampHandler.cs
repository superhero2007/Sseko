using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Sseko.BLL;

namespace Sseko.Web.Utilities
{
    public class StampHandler : AuthorizationHandler<StampRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, StampRequirement requirement)
        {
            var serviceFactoy = new ServiceFactory();
            if (!context.User.HasClaim(c => c.Type == "sec") || !context.User.HasClaim(c => c.Type == "uId"))
            {
                context.Fail();
                return Task.CompletedTask;
            }
            var claimsId = context.User.FindFirst(c => c.Type == "uId").Value;
            var claimsStamp = context.User.FindFirst(c => c.Type == "sec").Value;

            var request = serviceFactoy.UserService().GetAsync(claimsId).Result;

            if (request.IsError || request.Output == null)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            if (claimsStamp == request.Output.SecurityStamp)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            context.Fail();
            return Task.CompletedTask;
        }
    }

    public class StampRequirement : IAuthorizationRequirement
    {

    }
}
