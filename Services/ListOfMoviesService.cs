using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using MoviesWebApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Services
{
    public class ListOfMoviesService : IListOfMoviesService
    {
        private readonly IListOfMoviesRepository _repository;
        private readonly IListAndMoviesRepository _listAndMoviesRepository;


        public ListOfMoviesService(IListOfMoviesRepository repository, IListAndMoviesRepository listAndMoviesRepository)
        {
            this._repository = repository;
            this._listAndMoviesRepository = listAndMoviesRepository;
        }

        public bool Delete(int id)
        {
            var listOfMovies = _repository.FindById(id);
            _repository.Delete(listOfMovies);
            return _repository.SaveChanges();
        }

        public List<ListOfMovies> GetAll()
        {
            return _repository.GetAll();
        }

        public ListOfMovies GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(ListOfMovies listOfMovies)
        {
            _repository.Create(listOfMovies);
            return _repository.SaveChanges();
        }

        public bool Update(ListOfMovies listOfMovies)
        {
            _repository.Update(listOfMovies);
            return _repository.SaveChanges();
        }

        /*
         public bool RegisterStudent(StudentCourseRegister paylaod)
        {
            var entity = new CourseStudent
            {
                CourseId = paylaod.CourseId,
                StudentId = paylaod.StudentId
            };

            _courseStudentRepository.Create(entity);
            return _repository.SaveChanges();
        }

        public bool RemoveStudentFromCourse(StudentCourseRegister payload)
        {
            var entity = _courseStudentRepository.GetByStudentAndCourse(payload.StudentId, payload.CourseId);
            _courseStudentRepository.HardDelete(entity);
            return _courseStudentRepository.SaveChanges();
        }
        */
    }
}
