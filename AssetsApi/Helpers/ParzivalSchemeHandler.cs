using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace AssetsApi.Helpers
{
    public class ParzivalSchemeHandler : IAuthenticationHandler
    {
        Task<AuthenticateResult> IAuthenticationHandler.AuthenticateAsync()
        {
            throw new NotImplementedException("IAuthenticationHandler.AuthenticateAsync");
        }

        Task IAuthenticationHandler.ChallengeAsync(AuthenticationProperties properties)
        {
            throw new NotImplementedException("IAuthenticationHandler.ChallengeAsync");
        }

        Task IAuthenticationHandler.ForbidAsync(AuthenticationProperties properties)
        {
            throw new NotImplementedException("IAuthenticationHandler.ForbidAsync");
        }

        Task IAuthenticationHandler.InitializeAsync(AuthenticationScheme scheme, HttpContext context)
        {
            throw new NotImplementedException("IAuthenticationHandler.InitializeAsync");
        }
    }
}
