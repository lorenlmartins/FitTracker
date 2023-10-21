namespace FitTracker.Models.Entities
{
    public class Workout
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? Category { get; set; }

        public IEnumerable<Exercise>? Exercises { get; set; }
      
    }
}
