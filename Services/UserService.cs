using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using MoviesWebApp.IServices;
using MoviesWebApp.Mapper;
using MoviesWebApp.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWebApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository, IOptions<AppSettings> appSettings)
        {
            this._userRepository = userRepository;
            this._appSettings = appSettings.Value;
        }
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.FindById(id);
        }

        public bool Register(AuthenticationRequest request)
        {
            var entity = UserMapper.ToUser(request); // Mapper 1

           // var entity = request.ToUserExtension(); // Mapper 2
            /*
            var entity = new User
            {
                Username = request.Username,
                Password = request.Password
            };
            */

            _userRepository.Create(entity);
            return _userRepository.SaveChanges();
        }

        public AuthenticationResponse Login(AuthenticationRequest request)
        {
            // find user
            var user = _userRepository.GetByUserAndPassword(request.Username, request.Password);
            if (user == null)
                return null;

            //atach token
            var token = GenerateJwtForUser(user);

            //return user & token
            return new AuthenticationResponse
            {
                Id = user.Id,
                Username = user.Username,
                Token = token
            };
            
        }

        private string GenerateJwtForUser(User user)
        {
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

      
    }
}
