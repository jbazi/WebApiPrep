using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonRegistryApp.Config
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            var scopes = new List<Scope>
            {
                /*
                 * My identity scopes below
                 * OpenId   ->   Allows to support identity tokens
                 * Profile  ->   Used for profile information
                 */
                StandardScopes.OpenId,
                StandardScopes.Profile
            };
            return scopes;
        }
    }
}