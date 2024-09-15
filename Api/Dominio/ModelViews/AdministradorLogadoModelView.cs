using Microsoft.VisualBasic;
using MinimalApi.Dominio.Enuns;
using System.Threading;
namespace MinimalApi.Dominio.ModelViews;

public record AdministradorLogadoModelView
{
    
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;

    public string Token { get; set; } = default!;
}