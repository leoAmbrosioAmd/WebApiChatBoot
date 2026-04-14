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
        public DbSet<TabelaPrecoModel> TabelasPreco { get; set; } 

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


            // --- MAPEAMENTO DA TABELA PS1032 ---
            modelBuilder.Entity<TabelaPrecoModel>().ToTable("PS1032");

            // Chave primária (conforme PK na imagem)
            modelBuilder.Entity<TabelaPrecoModel>().HasKey(t => t.NUMERO_REGISTRO);

            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.NUMERO_REGISTRO).HasColumnName("NUMERO_REGISTRO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.CODIGO_PLANO).HasColumnName("CODIGO_PLANO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.CODIGO_TABELA_PRECO).HasColumnName("CODIGO_TABELA_PRECO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.IDADE_MINIMA).HasColumnName("IDADE_MINIMA");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.IDADE_MAXIMA).HasColumnName("IDADE_MAXIMA");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.VALOR_PLANO).HasColumnName("VALOR_PLANO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.Tipo_Relacao_Dependencia).HasColumnName("Tipo_Relacao_Dependencia");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.INFORMACOES_LOG_I).HasColumnName("INFORMACOES_LOG_I");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.INFORMACOES_LOG_A).HasColumnName("INFORMACOES_LOG_A");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.VALOR_NET).HasColumnName("VALOR_NET");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.CODIGO_GRUPO_CONTRATO).HasColumnName("CODIGO_GRUPO_CONTRATO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.NOME_TABELA).HasColumnName("NOME_TABELA");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.TIPO_CONTRATO_ESTIPULADO).HasColumnName("TIPO_CONTRATO_ESTIPULADO");
            modelBuilder.Entity<TabelaPrecoModel>().Property(t => t.ID_INSTANCIA_PROCESSO).HasColumnName("ID_INSTANCIA_PROCESSO");
        }
    }
}
