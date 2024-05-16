using Microsoft.AspNetCore.Mvc;
using ProjetoUsuarioPost.Context;
using ProjetoUsuarioPost.Dto;
using ProjetoUsuarioPost.Model;

namespace ProjetoUsuarioPost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public UsuariosController()
        {
            _dataContext = new DataContext();
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return _dataContext.Usuario.ToList();

        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = _dataContext.Usuario.FirstOrDefault(x => x.Id == id);
            if (usuario == null)
            {
                return BadRequest("ID não existente");
            }
            return usuario;
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult<Usuario> Post([FromBody] UsuarioRequest usuarioRequest)
        {
            if (ModelState.IsValid)
            {
                var usuario = usuarioRequest.toModel();
                _dataContext.Usuario.Add(usuario);
                _dataContext.SaveChanges();
                return usuario;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
