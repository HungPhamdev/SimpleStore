using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ASM.Share.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace ASM.Server.Pages
{
    [AllowAnonymous]
    public class CheckLogin : PageModel
    {
        [Inject]
        public ASM.Share.Models.INguoidungSvc _nguoidungSvc { get; set; }
        public CheckLogin(ASM.Share.Models.INguoidungSvc nguoidungSvc)
        {
            _nguoidungSvc = nguoidungSvc;
        }
        public string ReturnUrl { get; set; }
        public async Task<IActionResult> OnGetAsync(string paramUserName, string paramPassword)
        {
            string returnUrl = Url.Content("~/");
            try
            {
                // Clear the existing external cookie
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            bool flagLogin = false;
            var viewLogin = new ViewLogin() { UserName = paramUserName, Password = paramPassword };
            ASM.Share.Models.Nguoidung nguoidung = _nguoidungSvc.Login(viewLogin);
            if (nguoidung != null)
            {
                flagLogin = true;
            }

            if (flagLogin) // Login successfully
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, paramUserName),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };

                try
                {
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), authProperties);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }
            else { }
            return LocalRedirect(returnUrl);
        }
    }
}
