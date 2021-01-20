using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Interfaces
{
    public interface ICommentOfListRepository : IGenericRepository<CommentOfList>
    {
        List<CommentOfList> GetByComment(string comment);
        CommentOfList GetByIdJoined(int id);
    }
}
