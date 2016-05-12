using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;

namespace IdentityServer.Services
{
    public class DefaultScopeStore : IScopeStore
    {
        public Task<IEnumerable<Scope>> FindScopesAsync(IEnumerable<string> scopeNames)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Scope>> GetScopesAsync(bool publicOnly = true)
        {
            throw new NotImplementedException();
        }
    }
}