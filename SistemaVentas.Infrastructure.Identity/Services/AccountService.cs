using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SistemaVentas.Core.Application.Dtos.Account;
using SistemaVentas.Core.Application.Dtos.Email;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Infrastructure.Identity.Entities;

namespace SistemaVentas.Infrastructure.Identity.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public AccountService(
            UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager,
            IEmailService _emailService,
            IMapper _mapper)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
            this._emailService = _emailService;
            this._mapper = _mapper;
        }

        public async Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request)
        {
            AuthenticationResponse authentication = new();

            ApplicationUser? user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                authentication.HasError = true;
                authentication.ErrorDescription = "Invalid credentials";
                return authentication;
            }
            
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded) {
                authentication.HasError = true;
                authentication.ErrorDescription = "Invalid credentials";
                return authentication;
            }

            if (!user.EmailConfirmed)
            {
                authentication.HasError = true;
                authentication.ErrorDescription = "This account ins't confirmed";
                return authentication;
            }

            var returnedUser = _mapper.Map<AuthenticationResponse>(user);
            returnedUser.Roles = (await _userManager.GetRolesAsync(user).ConfigureAwait(false)).ToList();

            return returnedUser;
        }

        public Task<string> ConfirmAccountAsync(string userId, string token)
        {
            throw new NotImplementedException();
        }

        public Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, string origin)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponse> RegisterUserAsync(RegisterRequest request, string origin)
        {
            throw new NotImplementedException();
        }

        public Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
