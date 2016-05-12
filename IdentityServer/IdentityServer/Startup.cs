using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer.Services;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Services;
using Owin;

namespace IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var factory = new IdentityServerServiceFactory();

            factory.ClientStore = new Registration<IClientStore, DefaultClientStore>();
            factory.ScopeStore = new Registration<IScopeStore, DefaultScopeStore>();
            factory.UserService = new Registration<IUserService, DefaultUserService>();

            var options = new IdentityServerOptions
            {
                Factory = factory,
                RequireSsl = false
            };

            app.UseIdentityServer(options);

            WebApiConfig.Register(app);
        }
    }
}