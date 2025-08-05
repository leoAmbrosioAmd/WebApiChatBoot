using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using WebApiChatBoot.Models;

namespace WebApiChatBoot.Data
{
    public class SistemaTarefasDBContex : DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) :
            base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region LOCAL PARA CONEXÃO NO BANCO DA PLENNUSC-HOMOL
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UsuarioModel>().ToTable("PropostaImportacao");

            //// Caso os nomes das colunas sejam diferentes dos nomes das propriedades:
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Id).HasColumnName("CodPropostaImportacao");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Nome).HasColumnName("Nome");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Cpf).HasColumnName("Cpf");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Telefone).HasColumnName("Celular");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Email).HasColumnName("Email");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Plano).HasColumnName("CodigoPlano");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Operadora).HasColumnName("CnpjOperadora");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Vigencia).HasColumnName("EstadoCivil");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.dtInclisao).HasColumnName("DataInclusao");
            //modelBuilder.Entity<UsuarioModel>().Property(x => x.Status).HasColumnName("Bairro");
            #endregion

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>().ToTable("VND1000_ON");

            // Caso os nomes das colunas sejam diferentes dos nomes das propriedades:
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Id).HasColumnName("CODIGO_ASSOCIADO");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Nome).HasColumnName("NOME_ASSOCIADO");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Cpf).HasColumnName("NUMERO_CPF");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Telefone).HasColumnName("CODIGO_EMPRESA");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Plano).HasColumnName("CODIGO_PLANO");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.ULTIMO_STATUS).HasColumnName("ULTIMO_STATUS");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.dtInclisao).HasColumnName("DATA_ADMISSAO");
        }
    }
}
