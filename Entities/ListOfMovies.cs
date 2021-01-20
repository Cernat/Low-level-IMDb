using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Entities
{
    public class ListOfMovies
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int UserId { get; set; }



        public virtual CommentOfList CommentOfList { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ListAndMovies> ListAndMovies { get; set; }

    }
}
