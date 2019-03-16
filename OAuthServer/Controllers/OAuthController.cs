using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Primitives;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OAuthServer.Entities;
using OpenIddict.Abstractions;
using OpenIddict.Server;

namespace OAuthServer.Controllers
{
    [Route("oauth")]
    [ApiController]
    public class OAuthController : Controller
    {
        #region Constructor

        private readonly IdentityOptions _identityOptions;
        private readonly SignInManager<User> _signInManager;

        public OAuthController(IOptions<IdentityOptions> _identityOptions, SignInManager<User> _signInManager)
        {
            this._identityOptions = _identityOptions.Value ?? throw new ArgumentNullException(nameof(IdentityOptions));
            this._signInManager = _signInManager;
        }

        #endregion

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Kenely");
        }

        //[HttpPost]
        //[Route("token")]
        //public async Task<IActionResult> GetToken(OpenIdConnectRequest request)
        //{
        //    var ticket = await CreateTicketAsync(request, new User() { });

        //    return SignIn(ticket.Principal, ticket.Properties, ticket.AuthenticationScheme);
        //}

        //private async Task<AuthenticationTicket> CreateTicketAsync(OpenIdConnectRequest request, User user)
        //{
        //    // Create a new ClaimsPrincipal containing the claims that
        //    // will be used to create an id_token, a token or a code.
        //    var principal = await _signInManager.CreateUserPrincipalAsync(user);

        //    // Create a new authentication ticket holding the user identity.
        //    var ticket = new AuthenticationTicket(principal,
        //        new AuthenticationProperties(),
        //        OpenIddictServerDefaults.AuthenticationScheme);

        //    // Set the list of scopes granted to the client application.
        //    ticket.SetScopes(new[]
        //    {
        //        OpenIdConnectConstants.Scopes.OpenId,
        //        OpenIdConnectConstants.Scopes.Email,
        //        OpenIdConnectConstants.Scopes.Profile,
        //        OpenIddictConstants.Scopes.Roles
        //    }.Intersect(request.GetScopes()));

        //    ticket.SetResources("resource-server");

        //    // Note: by default, claims are NOT automatically included in the access and identity tokens.
        //    // To allow OpenIddict to serialize them, you must attach them a destination, that specifies
        //    // whether they should be included in access tokens, in identity tokens or in both.
        //    foreach (var claim in ticket.Principal.Claims)
        //    {
        //        // Never include the security stamp in the access and identity tokens, as it's a secret value.
        //        if (claim.Type == _identityOptions.ClaimsIdentity.SecurityStampClaimType)
        //        {
        //            continue;
        //        }

        //        var destinations = new List<string>
        //        {
        //            OpenIdConnectConstants.Destinations.AccessToken
        //        };

        //        // Only add the iterated claim to the id_token if the corresponding scope was granted to the client application.
        //        // The other claims will only be added to the access_token, which is encrypted when using the default format.
        //        if ((claim.Type == OpenIdConnectConstants.Claims.Name && ticket.HasScope(OpenIdConnectConstants.Scopes.Profile)) ||
        //            (claim.Type == OpenIdConnectConstants.Claims.Email && ticket.HasScope(OpenIdConnectConstants.Scopes.Email)) ||
        //            (claim.Type == OpenIdConnectConstants.Claims.Role && ticket.HasScope(OpenIddictConstants.Claims.Roles)))
        //        {
        //            destinations.Add(OpenIdConnectConstants.Destinations.IdentityToken);
        //        }

        //        claim.SetDestinations(destinations);
        //    }

        //    return ticket;
        //}
    }
}
