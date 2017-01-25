using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using IdentityServer3.Core.Configuration;
using PersonRegistryApp.Config;
using IdentityServer3.Core.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Owin.Security.OpenIdConnect;

[assembly: OwinStartup(typeof(PersonRegistryApp.Startup))]

namespace PersonRegistryApp
{
    public partial class Startup
    {
        public X509Certificate2 SigningCertificate { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.Map("/identity", idsrvApp =>
            {
                idsrvApp.UseIdentityServer(new IdentityServerOptions
                {
                    SiteName = "Embedded IdentityServer",

                    

                    Factory = new IdentityServerServiceFactory()
                                .UseInMemoryUsers(Users.Get())
                                .UseInMemoryClients(Clients.Get())
                                .UseInMemoryScopes(StandardScopes.All),

                    //SigningCertificate = LoadCertificate(),

                });  
            });

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = "https://localhost:44344/identity",
                ClientId = "pRegWebAPI",
                RedirectUri = "https://localhost:44344/",
                ResponseType = "id_token",

                SignInAsAuthenticationType = "Cookies"
            });
        }
        /*
        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\bin\identityServer\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
        */
    }
}
