using MoviesWebApp.Entities;
using MoviesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(AuthenticationRequest request)
        {
            return new User
            {
                Username = request.Username,
                Password = request.Password
            };
        }

        // Extension Method
        public static User ToUserEntity(this AuthenticationRequest request)
        {
            return new User
            {
                Username = request.Username,
                Password = request.Password
            };
        }
    }
}
