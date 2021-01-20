using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Interfaces
{
    public interface IMoviesRepository : IGenericRepository<Movies>
    {
        Movies GetByIdJoined(int id);
    }
}
