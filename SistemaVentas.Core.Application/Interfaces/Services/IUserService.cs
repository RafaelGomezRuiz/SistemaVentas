using SistemaVentas.Core.Application.Dtos.Account;
using SistemaVentas.Core.Application.ViewModels.Users;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<AuthenticationResponse> LoginAsync(LoginViewModel loginViewModel);
        Task SignOut();
    }
}
