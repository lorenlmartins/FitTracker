namespace FitTracker.Models.Entities
{
    public abstract class Exercise
    {
        public virtual int Id { get; set; }

        public virtual string? Name { get; set; }
    }
}
