using UserManagementService.Models;

namespace UserManagementService.Services.Interface
{
    public interface IUserService
    {
        Task<ApiResponse<string>> CreateUserWithTokenAsync(RegisterDto registerUser);
    }
}
