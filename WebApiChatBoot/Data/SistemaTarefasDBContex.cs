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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>().ToTable("NOME-DA-TABELA");

            // Caso os nomes das colunas sejam diferentes dos nomes das propriedades:
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Id).HasColumnName("ID");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Nome).HasColumnName("NOME");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Cpf).HasColumnName("CPF");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Telefone).HasColumnName("TELEFONE");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Email).HasColumnName("EMAIL");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Plano).HasColumnName("PLANO");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Operadora).HasColumnName("OPERADORA");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Vigencia).HasColumnName("VIGENCIA");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.dtInclisao).HasColumnName("DT_INCLUSAO");
            modelBuilder.Entity<UsuarioModel>().Property(x => x.Status).HasColumnName("STATUS");
        }
    }
}
