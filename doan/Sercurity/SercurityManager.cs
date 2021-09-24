using DoAn.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DoAn.Sercurity
{
    public class SercurityManager
    {
        public async void SignIn(HttpContext httpContext, Account account)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getuserClaims(account),
                CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }
        public async void SingnOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }
        private IEnumerable<Claim> getuserClaims(Account account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, account.UserName));
            account.RoleAccounts.ToList().ForEach(ra =>
            {
                claims.Add(new Claim(ClaimTypes.Role, ra.Role.Name));
            });
            return claims;
        }
    }
}
