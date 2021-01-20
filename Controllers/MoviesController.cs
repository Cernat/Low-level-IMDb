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
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        public IActionResult GetAllMovies()
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

        [HttpPost("update")]
        public IActionResult Update(Movies payload)
        {
            _service.Update(payload);
            return Ok();
        }

        [HttpPost("create")]
        public IActionResult Create(Movies payload)
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
