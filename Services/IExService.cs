using Personal.Models;
namespace Personal.Services;
public interface IExService
{
    List<Pokemon> GetExercices();
    List<Tipo> GetTipos();
    Pokemon GetExercices(int Numero);
    PokedexDto GetExercicesDto();
    DetailsDto GetDetailedExercice(int Numero);
    Tipo GetTipo(string Nome);
}