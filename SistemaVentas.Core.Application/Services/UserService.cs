using AutoMapper;
using SistemaVentas.Core.Application.Dtos.Account;
using SistemaVentas.Core.Application.Helpers;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Users;

namespace SistemaVentas.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly UserSessionHelper _userSessionHelper;

        public UserService(IAccountService _accountService, IMapper _mapper, UserSessionHelper _userSessionHelper)
        {
            this._accountService = _accountService;
            this._mapper = _mapper;
            this._userSessionHelper = _userSessionHelper;
        }
        public async Task<AuthenticationResponse> LoginAsync(LoginViewModel loginViewModel)
        {
            var loginRequest = _mapper.Map<AuthenticationRequest>(loginViewModel);
            AuthenticationResponse user = await _accountService.AuthenticateAsync(loginRequest);
            await _userSessionHelper.SetUser(user);
            return user;
        }

        public async Task SignOut()
        {
            await _accountService.SignOutAsync();
            await _userSessionHelper.RemoveUser();
        }
    }
}
