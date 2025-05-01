using GutMeal_Website.Models;
using System.Collections.Generic;
using System.Linq;

namespace GutMeal_Website.Services
{
    public class GutUserService
    {
        private static List<GutHealthUser> _users = new();
        private static int _nextId = 1;

        public List<GutHealthUser> GetAll() => _users;

        public void Add(GutHealthUser user)
        {
            user.Id = _nextId++;
            user.SuggestedMealPlan = SuggestMealPlan(user);
            _users.Add(user);
        }

        public void Delete(int id) => _users.RemoveAll(u => u.Id == id);

        public GutHealthUser Get(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Update(GutHealthUser updated)
        {
            var index = _users.FindIndex(u => u.Id == updated.Id);
            if (index != -1)
            {
                updated.SuggestedMealPlan = SuggestMealPlan(updated);
                _users[index] = updated;
            }
        }

        private string SuggestMealPlan(GutHealthUser u)
        {
            if (u.Carbohydrate_Intake == "Low" || u.BMI > 30)
                return "Keto-Friendly Low-Sugar Plan";
            if (u.Fiber_Intake == "High" || u.Age > 50)
                return "Gut-Health Fiber Boost";
            if (u.Bacteroides > 30 && u.Firmicutes > 40)
                return "Mediterranean Gut Balance";
            if (u.BMI >= 18.5 && u.BMI <= 24.9)
                return "Metabolic Maintenance Diet";
            if (u.Actinobacteria > 5 && u.Lactobacillus > 10 && u.Dairy_Allergy)
                return "Dairy-Free Anti-Inflammation Plan";
            if (u.Gluten_Allergy && u.Fiber_Intake == "Low") 
                return "Digestive Relief (Low-FODMAP)";
            if (u.Age > 45 && u.Firmicutes > 40 && (u.Fat_Intake == "Low" || u.Fat_Intake == "Moderate"))
                return "Heart Health Plus";
            return "Metabolic Maintenance Diet";
        }
    }
}
