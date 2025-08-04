using Microsoft.EntityFrameworkCore;
using WebApiChatBoot.Data;
using WebApiChatBoot.Repositorios;
using WebApiChatBoot.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do Entity Framework e Repositórios
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaTarefasDBContex>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
