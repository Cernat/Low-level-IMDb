using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApp.Entities;
using MoviesWebApp.IServices;
using MoviesWebApp.Repositories;

namespace MoviesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListOfMoviesController : ControllerBase
    {
        private readonly IListOfMoviesService _service;
        private readonly IUserService _userService;
        public ListOfMoviesController(IListOfMoviesService service, IUserService userService)
        {
            this._service = service;
            this._userService = userService;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpGet("user/{id}")]
        public IActionResult Get_User(int id)
        {
            var response = _userService.GetById(id);
            return Ok(response);
        }


        [HttpPost("update")]
        public IActionResult Update(ListOfMovies payload)
        {
            _service.Update(payload);
            return Ok();
        }

        [HttpPost("create")]
        public IActionResult Create(ListOfMovies payload)
        {
            _service.Insert(payload);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
