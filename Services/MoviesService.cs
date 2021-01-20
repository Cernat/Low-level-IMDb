using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using MoviesWebApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _repository;

        public MoviesService(IMoviesRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var movies = _repository.FindById(id);
            _repository.Delete(movies);
            return _repository.SaveChanges();
        }

        public List<Movies> GetAll()
        {
            return _repository.GetAll();
        }

        public Movies GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Insert(Movies movies)
        {
            _repository.Create(movies);
            return _repository.SaveChanges();
        }

        public bool Update(Movies movies)
        {
            _repository.Update(movies);
            return _repository.SaveChanges();
        }
    }
}
