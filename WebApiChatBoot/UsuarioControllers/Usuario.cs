using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiChatBoot.Models;
using WebApiChatBoot.Repositorios.Interfaces;

namespace WebApiChatBoot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(string id)
        {
            var usuario = await _usuarioRepositorio.BuscarPorId(id);
            if (usuario == null || usuario.ULTIMO_STATUS != "Status Liberado")
                return NotFound($"Usuário com ID: {id} não encontrado ou não está liberado.");

            return Ok(usuario);
        }

        #region LOCAL PARA DE CRIAÇÃO DE OUTROS METODOS DA API QUE NÃO ESTÃO SENDO USADOS
        //[HttpPost]
        //public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        //{
        //    UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
        //    return Ok(usuario);
        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        //{
        //    usuarioModel.Id = id;
        //    UsuarioModel usuario = await _usuarioRepositorio.Atualizar(usuarioModel, id);
        //    return Ok(usuario);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<UsuarioModel>> Apagar(int id)
        //{
        //    bool apagado = await _usuarioRepositorio.Apagar(id);
        //    return Ok(apagado);
        //}
        #endregion
    }
}
