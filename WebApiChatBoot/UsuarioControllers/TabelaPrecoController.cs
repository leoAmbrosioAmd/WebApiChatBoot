using Microsoft.AspNetCore.Mvc;
using WebApiChatBoot.Models;
using WebApiChatBoot.Repositorios.Interfaces;

namespace WebApiChatBoot.UsuarioControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabelaPrecoController : ControllerBase
    {
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;

        public TabelaPrecoController(ITabelaPrecoRepositorio tabelaPrecoRepositorio)
        {
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<TabelaPrecoModel>>> BuscarTodos()
        {
            List<TabelaPrecoModel> precos = await _tabelaPrecoRepositorio.BuscarTodos();
            return Ok(precos);
        }

        [HttpGet("codigo-tabela/{codigoTabela}")]
        public async Task<ActionResult<List<TabelaPrecoModel>>> BuscarPorCodigoTabela(int codigoTabela)
        {
            List<TabelaPrecoModel> precos = await _tabelaPrecoRepositorio.BuscarPorCodigoTabela(codigoTabela);
            if (precos == null || precos.Count == 0)
                return NotFound($"Nenhum registro encontrado para o código de tabela: {codigoTabela}");

            return Ok(precos);
        }

        // Futuramente, endpoint com filtro por flag:
        // [HttpGet("com-flag/{flag}")]
        // public async Task<ActionResult<List<TabelaPrecoModel>>> BuscarComFlag(bool flag)
        // {
        //     ...
        // }
    }
}
