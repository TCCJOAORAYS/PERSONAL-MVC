using Personal.Models;
namespace Personal.Services;
public interface IExService
{
    List<Exercise> GetExercices();
    Exercise GetExercises(int Numero);
    ExercicesDto GetExercicesDto();
 
}