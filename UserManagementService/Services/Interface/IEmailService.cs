using UserManagementService.Models;

namespace UserManagementService.Services.Interface
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
