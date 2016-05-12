using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;

namespace IdentityServer.Services
{
    public class DefaultClientStore : IClientStore
    {
        public Task<Client> FindClientByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}