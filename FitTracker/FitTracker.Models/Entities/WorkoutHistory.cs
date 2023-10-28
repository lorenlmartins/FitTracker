namespace FitTracker.Models.Entities 
{
    public class WorkoutHistory //TO DO: reevaluate the structure afterwards
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        public string? WorkoutId { get; set; }

        public ExerciseResult? Result { get; set; }
    }

    public class ExerciseResult
    {
        public int Sets { get; set; }

        public int Repetitions { get; set; }
    }
}
