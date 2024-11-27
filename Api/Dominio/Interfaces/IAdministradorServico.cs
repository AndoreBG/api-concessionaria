using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(loginDTO LoginDTO);
    Administrador Incluir(Administrador administrador);

    Administrador? BuscaPorId(int id);
    
    List<Administrador> Todos(int? pagina);
}