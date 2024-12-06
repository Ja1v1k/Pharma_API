using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementService.Models;

namespace UserManagementService.Services.Interface
{
    public interface IUserManagementService
    {
        Task<ApiResponse<string>> CreateUserWithTokenAsync(RegisterDto registerUser)
    }
}
