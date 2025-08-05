using WebApiChatBoot.Models;

namespace WebApiChatBoot.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(string id);
        #region LOCAL PARA DE CRIAÇÃO DE OUTROS METODOS DA API QUE NÃO ESTÃO SENDO USADOS
        //Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        //Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        //Task<bool> Apagar(int id);
#endregion
    }
}
