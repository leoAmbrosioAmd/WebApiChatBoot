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
        }
    }
}
