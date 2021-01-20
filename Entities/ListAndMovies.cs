using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Entities
{
    public class ListAndMovies
    {
        public int Id { get; set; }
        public int ListOfMoviesId { get; set; }
        public int MoviesId { get; set; }

        public virtual ListOfMovies ListOfMovies { get; set; }
        public virtual Movies Movies { get; set; }
    }
}
