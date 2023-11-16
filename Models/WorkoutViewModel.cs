namespace FitnessAppPresentation.Models;

public class WorkoutViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List <WorkoutDTO> Workouts { get; set; }


    // public string Id { get; set; }
    // public string Name { get; set; }
    // public int Sets { get; set; }
    // public int Reps { get; set; }
    // public float Weight { get; set; }
    // public Timer Rest { get; set; }
}
