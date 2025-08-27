using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minimalapi.dominio.entidades;
using minimalapi.dominio.serviços;
using minimalapi.infraestrutura.DB;
using minimalapi.DTO;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<iAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options => options.UseMySql(
builder.Configuration.GetConnectionString("MySQL"),
//Fazendo isso a string de conexao é passada no boot da aplicacao ou na injecao de dependencia,e no override caso esteja vazio.
ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQL")
    )
    ));

var app = builder.Build();

app.MapGet("/", () => "Olá todos");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, iAdministradorServico AdministradorServico) =>{
    if (AdministradorServico.Login( loginDTO ) != null)
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized(); 
});

app.Run();
