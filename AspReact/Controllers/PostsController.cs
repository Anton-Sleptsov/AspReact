using AspReact.Models;
using AspReact.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace AspReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostService _postServise;

        public PostsController(IPostService postService)
        {
            _postServise = postService;
        }

        [HttpPost]
        public PostModel Create(PostModel model)
        {
            return _postServise.Create(model);
        }

        [HttpPatch]
        public PostModel Update(PostModel model)
        {
            return _postServise.Update(model);
        }

        [HttpGet("{id}")]
        public PostModel Get(int id)
        {
            return _postServise.Get(id);
        }

        [HttpGet]
        public List<PostModel> GetAll()
        {
            return _postServise.Get();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _postServise.Delete(id);

            return Ok();
        }
    }
}
