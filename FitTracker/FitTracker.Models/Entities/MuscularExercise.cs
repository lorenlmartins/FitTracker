namespace FitTracker.Models.Entities
{
    public class MuscularExercise : Exercise
    {
        public override int Id { get; set; }

        public override string? Name { get; set; }

        public double Load { get; set; }

        public string? WeightUnit { get; set; } = "kg";

        public int Repetitions { get; set; }

        public int Sets { get; set; }

    }
}
