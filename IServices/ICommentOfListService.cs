using MoviesWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.IServices
{
    public interface ICommentOfListService
    {
        List<CommentOfList> GetAll();
        CommentOfList GetById(int id);
        bool Insert(CommentOfList commentOfList);
        bool Update(CommentOfList commentOfList);
        bool Delete(int id);
    }
}
