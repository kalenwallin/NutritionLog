using System;

namespace NutritionLog.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string Weight { get; set; }
        public string Calories { get; set; }
        public string Protein { get; set; }
        public string Carbs { get; set; }
        public string Fat { get; set; }
    }
}