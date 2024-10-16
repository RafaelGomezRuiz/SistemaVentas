using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Core.Application.Helpers;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Users;
using SistemaVentas.Models;
using System.Diagnostics;
using WebApp.SistemaVentas.Helpers;

namespace SistemaVentas.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);
            
            var user = await _userService.LoginAsync(loginVM);
            
            if (user == null || user.HasError!=false)
                return View(loginVM);

            return RedirectionRoutes.ProductHome;
        }

        public async Task<IActionResult> SignOut()
        {
            await _userService.SignOut();
            return RedirectToAction("Login");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
