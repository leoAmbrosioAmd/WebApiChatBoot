using Microsoft.EntityFrameworkCore;
using WebApiChatBoot.Data;
using WebApiChatBoot.Models;
using WebApiChatBoot.Repositorios.Interfaces;

namespace WebApiChatBoot.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContex _dbContext;
        public UsuarioRepositorio(SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();

            //return await _dbContext.Usuarios
            // .Where(u => u.Status == "Status Liberado")
            // .ToListAsync();
        }

        public async Task<UsuarioModel> BuscarPorId(string id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        #region LOCAL PARA DE CRIAÇÃO DE OUTROS METODOS DA API QUE NÃO ESTÃO SENDO USADOS
        //public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        //{
        //  await _dbContext.Usuarios.AddAsync(usuario);
        //  await  _dbContext.SaveChangesAsync();

        //    return usuario;
        //}
        //public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        //{
        //    UsuarioModel usuarioPorId = BuscarPorId(id).Result;

        //    if (usuarioPorId == null)
        //    {
        //        throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados");
        //    }
        //    usuarioPorId.Nome = usuario.Nome;
        //    usuarioPorId.Cpf = usuario.Cpf;
        //    usuarioPorId.Telefone = usuario.Telefone;
        //    usuarioPorId.Email = usuario.Email;
        //    usuarioPorId.Plano = usuario.Plano;
        //    usuarioPorId.Operadora = usuario.Operadora;
        //    usuarioPorId.Vigencia = usuario.Vigencia;
        //    usuarioPorId.dtInclisao = usuario.dtInclisao;
        //    usuarioPorId.Status = usuario.Status;
        //    _dbContext.Usuarios.Update(usuarioPorId);

        //    _dbContext.Usuarios.Update(usuarioPorId);
        //    await _dbContext.SaveChangesAsync();

        //    return usuarioPorId; ;
        //}
        //public async Task<bool> Apagar(int id)
        //{
        //    UsuarioModel usuarioPorId = BuscarPorId(id).Result;

        //    if (usuarioPorId == null)
        //    {
        //        throw new Exception($"Usuário para o ID: {id} não foi encontrado no banco de dados");
        //    }

        //    _dbContext.Usuarios.Remove(usuarioPorId);
        //    await _dbContext.SaveChangesAsync();
        //    return true;
        //}
        #endregion
    }
}
