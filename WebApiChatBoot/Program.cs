using Microsoft.EntityFrameworkCore;
using WebApiChatBoot.Data;
using WebApiChatBoot.Repositorios;
using WebApiChatBoot.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaTarefasDBContex>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
