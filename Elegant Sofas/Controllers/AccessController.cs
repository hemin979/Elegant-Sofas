using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Elegant_Sofas.Models;
using System.Threading.Tasks; // Add this namespace for Task

namespace Elegant_Sofas.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            // Check if the user is already authenticated
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home", "Sofas");
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            if (modelLogin.Email == "admin@yahoo.com" && modelLogin.PassWord == "@Cyber12345")
            {
                // Create claims for the authenticated user
#pragma warning disable IDE0090 // Use 'new(...)'
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties", "Example Role")
                };
#pragma warning restore IDE0090 // Use 'new(...)'

                // Create an identity for the user
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Create authentication properties
                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                // Sign in the user
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                              new ClaimsPrincipal(claimsIdentity),
                                              authProperties);

                // Redirect the user to the home page
                return RedirectToAction("Index", "Home", "Sofas");
            }

            // If user authentication fails, show error message
            ViewData["ValidateMessage"] = "User not found";
            return View();
        }
    }
}
