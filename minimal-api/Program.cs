using Microsoft.EntityFrameworkCore;
using minimalapi.infraestrutura.DB;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>(options => options.UseMySql(
    builder.Configuration.GetConnectionString("MySQL"),
    //Fazendo isso a string de conexao é passada no boot da aplicacao ou na injecao de dependencia,e no override caso esteja vazio.
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQL")
    )
    ));

app.MapGet("/", () => "Olá todos");

app.MapPost("/login", (minimalapi.DTO.loginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {return Results.Ok("Login com sucesso");}
    else
    { return Results.Unauthorized(); }
});

app.Run();
