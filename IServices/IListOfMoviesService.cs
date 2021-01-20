using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.IServices
{
    public interface IListOfMoviesService
    {
        List<ListOfMovies> GetAll();
        ListOfMovies GetById(int id);
        bool Insert(ListOfMovies listOfMovies);
        bool Update(ListOfMovies listOfMovies);
        bool Delete(int id);
    }
}
