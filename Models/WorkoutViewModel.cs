namespace FitnessAppPresentation.Models;

public class WorkoutViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List <WorkoutDTO> Workouts { get; set; }
<<<<<<< HEAD
=======


    // public string Id { get; set; }
    // public string Name { get; set; }
    // public int Sets { get; set; }
    // public int Reps { get; set; }
    // public float Weight { get; set; }
    // public Timer Rest { get; set; }

    public ExerciseDTO Exercise = new ExerciseDTO();
    public WorkoutDTO Workout = new WorkoutDTO();
>>>>>>> 707eab213f6bb565d59ceed14633c310797456c4
}
