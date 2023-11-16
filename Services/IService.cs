using FitnessAppPresentation.Models;

namespace FitnessAppPresentation.Services;

public interface IService
{
    Task Create(WorkoutViewModel obj);
    Task<WorkoutDTO> Get(string id);
    Task<List<WorkoutDTO>> Get();
    Task Update(WorkoutViewModel obj);
    Task Delete(string id);

}