using Microsoft.EntityFrameworkCore;
using minimalapi.dominio.entidades;
using minimalapi.DTO;
using minimalapi.infraestrutura.DB;

namespace minimalapi.dominio.serviços;


public class AdministradorServico : iAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.administradores.Where(a => a.email == loginDTO.Email && a.senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }
}