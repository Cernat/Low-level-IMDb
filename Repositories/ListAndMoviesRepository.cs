using MoviesWebApp.Data;
using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Repositories
{
    public class ListAndMoviesRepository : GenericRepository<ListAndMovies>, IListAndMoviesRepository
    {
        public ListAndMoviesRepository(UserDbContext context) : base(context)
        {
        }

        public ListAndMovies GetByListAndMovies(int list, int movies)
        {
            return _context.ListAndMovies.Where(x => x.ListOfMoviesId == list && x.MoviesId == movies).FirstOrDefault();
        }
    }
}
