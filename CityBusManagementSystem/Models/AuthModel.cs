﻿using CityBusManagementSystem.Models.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace CityBusManagementSystem.Models
{
    public class AuthModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }


        public AuthModel(string message)
        {
            Message = message;
        }
        public AuthModel(IRegisterModel model ,List<string> role ,JwtSecurityToken token)
        {
                this.Username = model.UserName;
                this.Email = model.Email;
                this.IsAuthenticated = true;
                this.ExpiresOn = token.ValidTo;
                this.Roles = role;
                this.Token = new JwtSecurityTokenHandler().WriteToken(token);
        }

        public AuthModel(ApplicationUser model, List<string> role, JwtSecurityToken token)
        {
            this.Username = model.UserName;
            this.Email = model.Email;
            this.IsAuthenticated = true;
            this.ExpiresOn = token.ValidTo;
            this.Roles = role;
            this.Token = new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
