using Microsoft.VisualBasic;
using System.Threading;
namespace MinimalApi.Dominio.ModelViews;

public struct ErrosDeValidacao
{
    public List<string> Mensages { get; set;}
}