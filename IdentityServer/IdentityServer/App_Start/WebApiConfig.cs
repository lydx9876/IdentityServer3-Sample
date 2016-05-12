using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace IdentityServer
{
    public static class WebApiConfig
    {
        public static void Register(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}