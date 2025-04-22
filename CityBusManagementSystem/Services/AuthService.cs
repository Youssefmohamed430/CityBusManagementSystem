using CityBusManagementSystem.Helpers;
using CityBusManagementSystem.Models;
using CityBusManagementSystem.Models.Data;
using CityBusManagementSystem.Models.Entities;
using CityBusManagementSystem.Repositries;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace CityBusManagementSystem.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly JWTServices _jwtservice;
        private readonly IGenericRepository<Client> _IGenClientRepo;
        private readonly IDriverRepository _DriverRepo;

        public AuthService
            (IDriverRepository DriverRepo, IGenericRepository<Client> IGenClientRepo,UserManager<ApplicationUser> userManager, JWTServices jwtservice)
        {
            this._UserManager = userManager;
            this._jwtservice = jwtservice;
            this._IGenClientRepo = IGenClientRepo;
            this._DriverRepo = DriverRepo;
        }

        public async Task<AuthModel> RegisterClientAsync([FromBody] RegisterClientModel model)
        {
            if (await IsUserNameToken(model.UserName))
                return new AuthModel("UserName Is already registerd!");

            if (await IsEmailToken(model.Email))
                return new AuthModel("Email Is already registerd!");

            ApplicationUser user = new ApplicationUser(model.UserName,model.Name,model.Email);

            var result = await _UserManager.CreateAsync(user,model.Password);

            if (!result.Succeeded) return new AuthModel(GetErrors(result));

            await _UserManager.AddToRoleAsync(user,"Client");

            _IGenClientRepo.Add(new Client(user.Id));

            return new AuthModel(model, "Client", await _jwtservice.CreateJwtToken(user));
        }
        public async Task<AuthModel> RegisterDriverAsync([FromBody] RegisterDriverModel model)
        {
            if (await IsUserNameToken(model.UserName))
                return new AuthModel("UserName Is already registerd!");

            if (await IsEmailToken(model.Email))
                return new AuthModel("Email Is already registerd!");

            if (_DriverRepo.IsSsnToken(model.SSN))
                return new AuthModel("Ssn Is already registerd!");

            ApplicationUser user = new ApplicationUser(model.UserName, model.Name, model.Email);

            var result = await _UserManager.CreateAsync(user, model.Password);

            if (!result.Succeeded) return new AuthModel(GetErrors(result));

            await _UserManager.AddToRoleAsync(user, "Driver");

            _DriverRepo.Add(new Driver(user.Id,model.SSN,model.Address,model.ImgDrivingLicense));

            return new AuthModel(model, "Driver", await _jwtservice.CreateJwtToken(user));
        }
        private async Task<bool> IsUserNameToken(string username)
            => await _UserManager.FindByNameAsync(username) is not null ? true : false;
        private async Task<bool> IsEmailToken(string Email)
            => await _UserManager.FindByEmailAsync(Email) is not null ? true : false;
        private string GetErrors(IdentityResult result)
            => string.Join(", ", result.Errors.Select(e => e.Description));

    }
}
