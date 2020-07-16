using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoRepositoryPattern_Repository
{
    public enum MealType { Burgers = 1, salads, Fries, Desserts, Coffee }
    
    public class MenuContent
    {
        public string FoodOptions { get; set; }
        public string MealName { get; set; }
        public string DescriptionType { get; set; }
        public string Ingredientlist { get; set; }
        public int MealPrice { get; set; }
        public MealType TypeOfmeal { get; set; }

        public MenuContent() { }
        public MenuContent(string foodOptions, string mealname, string descriptiontype, string ingedientlist, int mealprice, MealType meal )
        {
            FoodOptions = foodOptions;
            MealName = mealname;
            DescriptionType = descriptiontype;
            Ingredientlist = ingedientlist;
            MealPrice = mealprice;
            TypeOfmeal = meal;

        }
    }
}
