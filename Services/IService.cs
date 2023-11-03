using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Services;

public interface IWorkoutService
{
    Task Create(WorkoutViewModel obj);
    Task Get(string id);
    Task Get();
    Task Update(WorkoutViewModel obj);
    Task Delete(string id);

}