namespace FitnessAppPresentation.Models;

public class WorkoutViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List <WorkoutDTO> Workouts { get; set; }
}
