using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FLEXTrainer.Essentials
{
    public class DataEnteredMeal : EventArgs
    {
        public string Name { get; private set; }
        public string Nutrition { get; private set; }
        public string Allergens { get; private set; }

        public DataEnteredMeal(string name, string nutrition, string allergens)
        {
            Name = name;
            Nutrition = nutrition;
            Allergens = allergens;  
        }
    }

    public class Meal
    {
        public string Name { get;  set; }
        public string Nutrition { get; set; }
        public string Allergens { get;  set; }
    }
}
