namespace GutMeal_Website.Models
{
    public class GutHealthUser
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double BMI { get; set; }

        public string Protein_Intake { get; set; }
        public string Fiber_Intake { get; set; }
        public string Carbohydrate_Intake { get; set; }
        public string Fat_Intake { get; set; }

        public bool Dairy_Allergy { get; set; }
        public bool Gluten_Allergy { get; set; }
        public bool Nut_Allergy { get; set; }

        public double Bacteroides { get; set; }
        public double Firmicutes { get; set; }
        public double Lactobacillus { get; set; }
        public double Proteobacteria { get; set; }
        public double Actinobacteria { get; set; }
        public double Verrucomicrobia { get; set; }

        public string SuggestedMealPlan { get; set; }
    }
}
