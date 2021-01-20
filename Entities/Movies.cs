using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genres { get; set; }

        public virtual ICollection<ListAndMovies> ListAndMovies { get; set; }

    }
}
