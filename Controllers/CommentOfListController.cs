using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApp.Entities;
using MoviesWebApp.Interfaces;
using MoviesWebApp.IServices;
using MoviesWebApp.Repositories;

namespace MoviesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentOfListController : ControllerBase
    {
        private readonly ICommentOfListService _service;

        public CommentOfListController(ICommentOfListService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var comment = _service.GetAll();
            return Ok(comment);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var comment = _service.GetById(id);
            return Ok(comment);
        }

        [HttpPost("update")]
        public IActionResult Update(CommentOfList payload)
        {
            _service.Insert(payload);
            return Ok();
        }

        [HttpPost("create")]
        public IActionResult Create(CommentOfList payload)
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


        /*

        [HttpPost]
        public IActionResult insertComment(CommentOfList commentOfList)
        {
            _commentOfListRepository.Create(commentOfList);
            var succes = _commentOfListRepository.SaveChanges();
            return Ok(succes == true ? "Succes" : "Failed");
        }

        [HttpGet("find")]
        public IActionResult FindCommentById(int id)
        {
            var comment = _commentOfListRepository.FindById(id);
            return Ok(comment);
        }

        [HttpGet("comment")]
        public IActionResult FindByComment(string comment)
        {
            var comments = _commentOfListRepository.GetByComment(comment);
            return Ok(comments);
        }

        */
    }
}
