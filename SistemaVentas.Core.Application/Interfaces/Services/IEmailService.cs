using SistemaVentas.Core.Application.Dtos.Email;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
