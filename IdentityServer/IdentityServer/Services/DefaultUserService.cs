using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;

namespace IdentityServer.Services
{
    public class DefaultUserService : IUserService
    {
        public Task AuthenticateExternalAsync(ExternalAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public Task AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            throw new NotImplementedException();
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            throw new NotImplementedException();
        }

        public Task PostAuthenticateAsync(PostAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public Task PreAuthenticateAsync(PreAuthenticationContext context)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync(SignOutContext context)
        {
            throw new NotImplementedException();
        }
    }
}