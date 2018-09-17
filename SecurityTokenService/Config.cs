namespace SecurityTokenService
    {
    using System.Collections.Generic;

    using IdentityServer4.Models;
    using IdentityServer4.Test;

    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
            {
            return new List<ApiResource>
                { new ApiResource("tbp", "The Bluebell Project") };
            }

        public static IEnumerable<Client> GetClients()
            {
            return new List<Client> {
                new Client {
                    ClientId = "client",
                // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets = {
                        new Secret("secret".Sha256()) },
                    // scopes that client has access to
                    AllowedScopes = { "tbp" }
                    }
                };
            }

        public static List<TestUser> GetUsers()
            {
            return new List<TestUser>
                {
                new TestUser
                    {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password"
                    },
                new TestUser
                    {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password"
                    }
                };
            }
        }
    }
