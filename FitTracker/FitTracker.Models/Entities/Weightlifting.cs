namespace FitTracker.Models.Entities
{
    public class Weightlifting : Exercise
    {
        public override int Id { get; set; }

        public override string? Name { get; set; }

        public double Weight { get; set; }

        public string? WeightUnit { get; set; } = "kg";

        public int Repetitions { get; set; }

        public int Series { get; set; }

    }
}
