using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pharma.Dtos;
using Pharma.Helper;
using Pharma.Models;
using Pharma.Repository.Interfaces;
using Pharma.Services.Interfaces;

namespace Pharma.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAuthRepository _userRepository;
        private readonly JwtTokenHelper _jwtTokenHelper;

        public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,IAuthRepository userRepository, JwtTokenHelper jwtTokenHelper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _userRepository = userRepository;
            _jwtTokenHelper = jwtTokenHelper;
        }

        public async Task<IdentityResult> RegisterUser(RegisterDto model)
        {
            var roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            if (!roles.Contains(model.Role))
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Invalid Role."
                });
            }

            var existingUser = await _userManager.FindByEmailAsync(model.Email);
            if (existingUser != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "This email is already registered." });
            }

            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var roleExist = await _roleManager.RoleExistsAsync(model.Role);
                if (roleExist)
                {
                    await _userManager.AddToRoleAsync(user, model.Role);
                }
                else
                {
                    result = IdentityResult.Failed(new IdentityError
                    {
                        Description = "Role does not exist in the system."
                    });
                }
            }
            return result;
        }

    }
}
