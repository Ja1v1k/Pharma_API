using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Data;
using System;
using UserManagementService.Models;
using UserManagementService.Services.Interface;
using Microsoft.Extensions.Configuration;

namespace UserManagementService.Services
{
    public class UserManagementService 
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly IConfiguration _configuration;
        //private readonly IEmailService _emailService;

        //public UserManagementService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //    _roleManager = roleManager;
        //    _configuration = configuration;
        //    _emailService = emailService;
        //}

        //public async Task<ApiResponse<string>> CreateUserWithTokenAsync(RegisterDto registerUser)
        //{
        //    //check user exists
        //    var userExists = await _userManager.FindByEmailAsync(registerUser.Email);
        //    if (userExists != null)
        //    {
        //        return new ApiResponse<string> { IsSuccess = false, StatusCode = 403, Message = "User already exists!" };
        //        //return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "User already exists!" });
        //    }

        //    //Add user to DB
        //    IdentityUser user = new()
        //    {
        //        Email = registerUser.Email,
        //        SecurityStamp = Guid.NewGuid().ToString(),
        //        UserName = registerUser.UserName,
        //        TwoFactorEnabled = true
        //    };

        //    if (await _roleManager.RoleExistsAsync(registerUser.Role))
        //    {
        //        var result = await _userManager.CreateAsync(user, registerUser.Password);
        //        if (!result.Succeeded)
        //        {
        //            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Failed to Create User!" });
        //        }
        //        await _userManager.AddToRoleAsync(user, role);

        //        //Add token ot verify email...
        //        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //        var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, Request.Scheme);
        //        var message = new Message(new string[] { user.Email }, "Confirmation Email Link!", confirmationLink!);

        //        _emailService.SendEmail(message);

        //        return StatusCode(StatusCodes.Status201Created, new Response { Status = "Success", Message = $"User Created & Email sent to {user.Email} Successfully!" });
        //    }
        //    else
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Role doesn't exist!" });

        //    }

        //}
    }
}
