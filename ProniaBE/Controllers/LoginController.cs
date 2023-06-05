using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProniaBE.Models;
using ProniaBE.Services.Interfaces;

namespace ProniaBE.Controllers
{
	public class LoginController: Controller
	{
        private IConfiguration _config;
        private readonly ILoginService _service;

        public LoginController(IConfiguration config, ILoginService service)
        {
            _config = config;
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserLogin userLogin)
        {
            var user = await _service.Authenticate(userLogin);

            if(user != null)
            {
                var token = await _service.Generate(user);
                return Ok(token);
            }
            return NotFound("User not found");
        }
    }
}

