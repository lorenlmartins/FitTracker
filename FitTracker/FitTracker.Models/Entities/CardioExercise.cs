namespace FitTracker.Models.Entities
{
    public class CardioExercise : Exercise
    {
        public override int Id { get; set; }

        public override string? Name { get; set; }

        public TimeSpan DurationTime { get; set; }
    }
}
