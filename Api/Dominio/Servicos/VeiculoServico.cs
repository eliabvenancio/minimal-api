
using System.Reflection.Metadata.Ecma335;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace MinimalApi.Dominio.Servicos;

public class VeiculoServico : IVeiculoServico
{
    private readonly DbContexto _contexto;
    public VeiculoServico(DbContexto dbContext)
    {
        _contexto = dbContext;
    }

    public void Apagar(Veiculo veiculo)
    {
        _contexto.Veiculos.Remove(veiculo);
        _contexto.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        _contexto.Veiculos.Update(veiculo);
        _contexto.SaveChanges();
    }

    public Veiculo? BuscarPorId(int id)
    {
        return _contexto.Veiculos.Where(v => v.Id == id).FirstOrDefault();
    }

    public void Incluir(Veiculo veiculo)
    {
        _contexto.Veiculos.Add(veiculo);
        _contexto.SaveChanges();
    }

  public List<Veiculo> Todos(int? pagina = null, string? nome = null, string? marca = null)
{
    var query = _contexto.Veiculos.AsQueryable();

    if (!string.IsNullOrEmpty(nome))
    {
        query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome}%"));
    }

    // Se a página for null, retorna todos os veículos sem paginação
    if (!pagina.HasValue)
    {
        return query.ToList();
    }

    int itensPorPagina = 10;
    query = query.Skip((pagina.Value - 1) * itensPorPagina).Take(itensPorPagina);

    return query.ToList();
}


}