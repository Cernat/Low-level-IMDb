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
    public class CommentOfListRepository : GenericRepository<CommentOfList>, ICommentOfListRepository
    {
        public CommentOfListRepository(UserDbContext context) : base(context)
        {
        }

        public List<CommentOfList> GetByComment(string comment)
        {
            return _table.Where(x => x.Comment == comment).ToList();
        }

        public CommentOfList GetByIdJoined(int id)
        {
            var comment = _context.CommentOfList.Where(x => x.Id == id)
                .Include(x => x.ListOfMovies)
                .FirstOrDefault();

            return comment;
        }
    }
}
