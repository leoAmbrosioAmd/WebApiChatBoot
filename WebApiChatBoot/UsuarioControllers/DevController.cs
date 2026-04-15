using Microsoft.AspNetCore.Mvc;
using WebApiChatBoot.Service;

namespace WebApiChatBoot.UsuarioControllers
{
    [Route("api/dev")]
    [ApiController]
    public class DevController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public DevController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet("hash/{senha}")]
        public IActionResult GetHash(string senha)
        {
            var hash = _tokenService.GerarHashParaSenha(senha);
            return Ok(new { senha, hash });
        }
    }
}