using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Thinktecture.IdentityServer.Models;

namespace PersonRegistryApp.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "Person Registry App (Hybrid Flow)",
                    ClientId = "pRegWebAPI",
                    Flow = Flows.Hybrid,
                    RequireConsent = true,

                    RedirectUris = new List<string> { "https://localhost:44344/" },

                    AllowAccessToAllScopes = true

                    /*
                     * Right now my client will have access to all scopes which for sure
                     * is a big NO NO NO when working with production based applications
                     * 
                     * All Scopes (via AllowAccessToAllScopes setting)
                     */
                }
            };
        }
    }
}