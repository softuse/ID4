using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace id4
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {

                 new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",
                                ClientSecrets = { new Secret("secret1122".Sha512())},
                    AllowedGrantTypes = GrantTypes.Implicit,//隐式方式
                    RequireConsent=false,//如果不需要显示否同意授权 页面 这里就设置为false
                    RedirectUris = { "http://localhost:5002/signin-oidc" },//登录成功后返回的客户端地址
                    PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },//注销登录后返回的客户端地址

                     AllowedScopes =
                     {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile

                     }
                 },
                  new Client
                {
                    ClientId = "mvc2",
                    ClientName = "MVC Client2",
                                ClientSecrets = { new Secret("secret1122".Sha512())},
                    AllowedGrantTypes = GrantTypes.Implicit,//隐式方式
                    RequireConsent=false,//如果不需要显示否同意授权 页面 这里就设置为false
                    RedirectUris = { "http://localhost:5003/signin-oidc" },//登录成功后返回的客户端地址
                    PostLogoutRedirectUris = { "http://localhost:5003/signout-callback-oidc" },//注销登录后返回的客户端地址

                     AllowedScopes =
                     {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile

                     }
                 }
            };
        }
    }
}
