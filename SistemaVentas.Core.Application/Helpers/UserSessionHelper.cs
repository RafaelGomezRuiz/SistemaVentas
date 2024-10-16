using Microsoft.AspNetCore.Http;
using SistemaVentas.Core.Application.Dtos.Account;

namespace SistemaVentas.Core.Application.Helpers
{
    public class UserSessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserSessionHelper(IHttpContextAccessor _httpContextAccessor)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }

        public async Task SetUser(AuthenticationResponse user)
        {
            _httpContextAccessor.HttpContext.Session.Set<AuthenticationResponse>(BussinesConstants.USERSESSION, user);
        }

        public async Task<AuthenticationResponse> GetUser()
        {
            return _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>(BussinesConstants.USERSESSION);
        }

        public async Task RemoveUser()
        {
            if (await HasUser())
                _httpContextAccessor.HttpContext.Session.Remove(BussinesConstants.USERSESSION) ;
        }

        public async Task<bool> HasUser()
        {
            var userAuthenticated = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>(BussinesConstants.USERSESSION);
            return userAuthenticated != null;
        }
    }
}
