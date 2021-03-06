﻿using MoviesWebApp.Entities;
using MoviesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.IServices
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        bool Register(AuthenticationRequest request);

        AuthenticationResponse Login(AuthenticationRequest request);
    }
}
