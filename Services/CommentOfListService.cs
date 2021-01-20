using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using MoviesWebApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Services
{
    public class CommentOfListService : ICommentOfListService
    {
        private readonly ICommentOfListRepository _repository;

        public CommentOfListService(ICommentOfListRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var commentOfList = _repository.FindById(id);
            _repository.Delete(commentOfList);
            return _repository.SaveChanges();
        }

        public List<CommentOfList> GetAll()
        {
            return _repository.GetAll();
        }

        public CommentOfList GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(CommentOfList commentOfList)
        {
            _repository.Create(commentOfList);
            return _repository.SaveChanges();
        }

        public bool Update(CommentOfList commentOfList)
        {
            _repository.Update(commentOfList);
            return _repository.SaveChanges();
        }
    }
}
