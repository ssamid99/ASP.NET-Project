using MyResume.Domain.Models.DataContexts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace MyResume.Domain.AppCode.Extensions
{
    public partial class Extension
    {
        public static string GetPrincipalName(this ClaimsPrincipal principal)
        {
            string name = principal.Claims.FirstOrDefault(c => c.Type.Equals("name"))?.Value;
            string surname = principal.Claims.FirstOrDefault(c => c.Type.Equals("surname"))?.Value;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                return $"{name} {surname}";
            }

            return principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Email))?.Value;
        }
        public static int GetCurrentUserId(this ClaimsPrincipal principal)
        {
            var userId = Convert.ToInt32(principal.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value);

            return userId;
        }
        public static int GetCurrentUserId(this IActionContextAccessor ctx)
        {
            return ctx.ActionContext.HttpContext.User.GetCurrentUserId();
        }
    }
}
