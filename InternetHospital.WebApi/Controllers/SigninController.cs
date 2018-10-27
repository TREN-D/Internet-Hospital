﻿using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using InternetHospital.BusinessLogic.Interfaces;
using InternetHospital.BusinessLogic.Models;
using InternetHospital.BusinessLogic.Services;
using InternetHospital.DataAccess;
using InternetHospital.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternetHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SigninController : ControllerBase
    {
        private ApplicationContext _context;
        private ITokenService _tokenService;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public SigninController(ApplicationContext context,
            UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<ActionResult> SignIn([FromBody]UserLoginModel form)
        {
            var user = await _userManager.FindByNameOrEmailAsync(form.UserName);
            if (user == null)
            {
                return NotFound(new { message = "You have entered an invalid username or password" });
            }
            else
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    return NotFound(new { message = "You have entered an invalid username or password" });
                }
            }
            if (!await _userManager.CheckPasswordAsync(user, form.Password))
            {
                return NotFound(new { message = "You have entered an invalid username or password" });
            }
            return Ok(new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(await _tokenService.GenerateAccessToken(user)),
                refresh_token = _tokenService.GenerateRefreshToken(user).Token
            });
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody]RefreshTokenModel refresh)
        {
            var refreshedToken = _tokenService.RefreshTokenValidation(refresh.RefreshToken);
            if (refreshedToken == null)
            {
                return BadRequest("invalid_grant");
            }
            var user = await _userManager.FindByIdAsync(refreshedToken.UserId.ToString());
            return Ok(new
            {
                access_token = new JwtSecurityTokenHandler().WriteToken(await _tokenService.GenerateAccessToken(user)),
                refresh_token = refreshedToken.Token
            });
        }    
    }

}