﻿using CityBusManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CityBusManagementSystem.Helpers
{
    public class JWTServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWT _jwt;
        public JWTServices(UserManager<ApplicationUser> userManager, IOptions<JWT> jwt)
        {
            this._userManager = userManager;
            this._jwt = jwt.Value;
        }
        public async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
                roleClaims.Add(new Claim("roles", role));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken
                (
                    issuer: _jwt.Issuer,
                    audience: _jwt.Audience,
                    claims: claims,
                    expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                    signingCredentials: signingCredentials
                );

            return jwtSecurityToken;
        }
    }
}
