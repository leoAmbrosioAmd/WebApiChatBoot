using Microsoft.EntityFrameworkCore;
using WebApiChatBoot.Data;
using WebApiChatBoot.Models;
using WebApiChatBoot.Repositorios.Interfaces;

namespace WebApiChatBoot.Repositorios
{
    public class TabelaPrecoRepositorio : ITabelaPrecoRepositorio
    {
        private readonly SistemaTarefasDBContex _dbContext;

        public TabelaPrecoRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<List<TabelaPrecoModel>> BuscarTodos()
        {
            return await _dbContext.TabelasPreco.ToListAsync();
        }

        public async Task<List<TabelaPrecoModel>> BuscarPorCodigoTabela(int codigoTabela)
        {
            return await _dbContext.TabelasPreco
                .Where(t => t.CODIGO_TABELA_PRECO == codigoTabela)
                .ToListAsync();
        }
    }
}