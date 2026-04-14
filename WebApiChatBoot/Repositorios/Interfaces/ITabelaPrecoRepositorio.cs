using WebApiChatBoot.Models;

namespace WebApiChatBoot.Repositorios.Interfaces
{
    public interface ITabelaPrecoRepositorio
    {
        Task<List<TabelaPrecoModel>> BuscarTodos();
        Task<List<TabelaPrecoModel>> BuscarPorCodigoTabela(int codigoTabela);
        // Futuramente: Task<List<TabelaPrecoModel>> BuscarComFiltroFlag(bool flag);
    }
}
