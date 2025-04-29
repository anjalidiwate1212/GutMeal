using Microsoft.AspNetCore.Mvc;

namespace GutMeal_Website.Models
{
    public class UserDetails : Controller
    {
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string DigestiveIssuesFrequency { get; set; } = string.Empty;
        public bool FoodAllergies { get; set; }
        public bool HealthConditions { get; set; }
        public string DietType { get; set; } = string.Empty;
        public string ProcessedFoodConsumption { get; set; } = string.Empty;
        public string FiberFoodIntake { get; set; } = string.Empty;
        public string ExerciseFrequency { get; set; } = string.Empty;
        public int StressLevel { get; set; }
        public int SleepQuality { get; set; }

        public UserDetails()
        {
            // Initialize default values for range inputs
            StressLevel = 1;
            SleepQuality = 1;
        }
    }
}
