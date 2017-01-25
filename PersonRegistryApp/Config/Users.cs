using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace PersonRegistryApp.Config
{
    /*
     * Desc: My Class with 4 simple users
     * This class doesn't necessarily care about the users
     * It cares about the token that is returned.
     */ 

    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>()
            {
                new InMemoryUser
                {
                    Username = "john",
                    Password = "secret",
                    Subject = "1",

                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "john"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Mutabazi"),
                    }
                },
                new InMemoryUser
                {
                    Username = "nelson",
                    Password = "secret",
                    Subject = "2",

                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "nelson"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Jackson"),
                    }
                },
                new InMemoryUser
                {
                    Username = "peter",
                    Password = "secret",
                    Subject = "3",

                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "peter"),
                        new Claim(Constants.ClaimTypes.FamilyName, "woodruf"),
                    }
                },
                new InMemoryUser
                {
                    Username = "emilly",
                    Password = "secret",
                    Subject = "4",

                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "emilly"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Mylie"),
                    }
                }
            };
        }
    }
}