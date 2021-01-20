using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;
using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Repositories
{
    public class ListOfMoviesRepository : GenericRepository<ListOfMovies>, IListOfMoviesRepository
    {
        public ListOfMoviesRepository(UserDbContext context) : base(context)
        {
        }

        public ListOfMovies GetByIdJoined(int id)
        {
            var listOfMovies = _context.ListOfMovies.Where(x => x.Id == id)
                .Include(x => x.ListAndMovies)
                .FirstOrDefault();

            return listOfMovies;
        }
    }
}
