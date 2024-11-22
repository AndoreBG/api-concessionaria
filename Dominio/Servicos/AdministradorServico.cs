using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador? Login(loginDTO LoginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == LoginDTO.Email && a.Senha == LoginDTO.Senha).FirstOrDefault();
        return adm;
    }
}