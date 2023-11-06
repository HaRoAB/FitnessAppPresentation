using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Services;

public interface IService
{
    Task Create(WorkoutViewModel obj);
    Task Get(string id);
    Task Get();
    Task Update(WorkoutViewModel obj);
    Task Delete(string id);

}