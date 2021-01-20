using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Entities
{
    public class CommentOfList
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public int ListOfMoviesId { get; set; }

        public virtual ListOfMovies ListOfMovies { get; set; }
    }
}
