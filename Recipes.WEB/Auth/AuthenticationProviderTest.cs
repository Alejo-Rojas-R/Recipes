using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Recipes.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var alejoUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("Name", "Alejandro"),
                new Claim("LastName", "Rojas"),
                new Claim(ClaimTypes.Name, "alejandrorojas@gmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(alejoUser)));
        }
    }
}
