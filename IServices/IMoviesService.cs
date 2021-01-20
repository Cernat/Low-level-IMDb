using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.IServices
{
    public interface IMoviesService
    {
        List<Movies> GetAll();
        Movies GetById(int id);
        bool Insert(Movies movies);
        bool Update(Movies movies);
        bool Delete(int id);
    }
}
