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
    public class MoviesRepository : GenericRepository<Movies>, IMoviesRepository
    {
        public MoviesRepository(UserDbContext context) : base(context)
        {
        }

        public Movies GetByIdJoined(int id)
        {
            var movies = _context.Movies.Where(x => x.Id == id)
                .Include(x => x.ListAndMovies)
                .ThenInclude(x => x.ListOfMovies)
                .FirstOrDefault();

            return movies;
        }
    }
}
