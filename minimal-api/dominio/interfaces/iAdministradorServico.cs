using minimalapi.dominio.entidades;
using minimalapi.DTO;

public interface iAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}