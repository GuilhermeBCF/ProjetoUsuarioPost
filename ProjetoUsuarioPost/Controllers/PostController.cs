using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoUsuarioPost.Context;
using ProjetoUsuarioPost.Dto;
using ProjetoUsuarioPost.Model;

namespace ProjetoUsuarioPost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PostController()
        {
            _dataContext = new DataContext();
        }

        // GET: api/<PostController>
        [HttpGet]
        public ActionResult<List<Post>> Get()
        {
            var posts = _dataContext.Post.ToList<Post>();
            return posts;
        }

        // GET api/<PostController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostController>
        [HttpPost]
        public ActionResult<Post> Post([FromBody] PostRequest postRequest)
        {
            if (ModelState.IsValid)
            {
                var post = postRequest.toModel();
                _dataContext.Post.Add(post);
                _dataContext.SaveChanges();
                return post;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<PostController>/5
        [HttpPut]
        public ActionResult<Post> Put([FromBody] Post post)
        {
            var postENulo = _dataContext.Post.FirstOrDefault(post) == null;
            if (postENulo)
                ModelState.AddModelError("PostId", "Id do post não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Post.Update(post);
                _dataContext.SaveChanges();
                return post;
            }
            return BadRequest(ModelState);

        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var post = _dataContext.Post.Find(id);
            if (post == null)
                ModelState.AddModelError("PostId", "Id do post não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Post.Remove(post);
                _dataContext.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
