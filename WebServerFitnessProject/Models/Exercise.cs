namespace WebServerFitnessProject.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string MuscleGroup { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Equipment { get; set; } = string.Empty;

        public string DifficultyLevel { get; set; } = string.Empty;
    }
}
