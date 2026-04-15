using Microsoft.EntityFrameworkCore;
using WebApiChatBoot.Data;
using WebApiChatBoot.Repositorios;
using WebApiChatBoot.Repositorios.Interfaces;
using WebApiChatBoot.Service;
using WebApiChatBoot.Service.Middlewares;        

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaTarefasDBContex>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<ITabelaPrecoRepositorio, TabelaPrecoRepositorio>();


builder.Services.AddSingleton<TokenService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 👇 Middleware de autenticação (ANTES do UseAuthorization)
app.UseMiddleware<TokenAuthenticationMiddleware>();

app.UseAuthorization();
app.MapControllers();
app.Run();