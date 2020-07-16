using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoRepositoryPattern_Repository
{
        public class MenuContentRepository
    {
        public List<MenuContent> _listOfContent = new List<MenuContent>();
        //Create
        public void AddContentToList(MenuContent content)
        {
            _listOfContent.Add(content);
        }

        //Read
        public List<MenuContent> GetContentList()
        {
            return _listOfContent;
        }

        //Update
        public bool UpdateExistingContent(string originalMealName, MenuContent newContent)
        {
            //Find the content
            MenuContent oldContent = GetContentByMealName(originalMealName);
            //update the content
            if (oldContent != null)
            {
                oldContent.MealName = newContent.MealName;
                oldContent.DescriptionType = newContent.DescriptionType;
                oldContent.Ingredientlist = newContent.Ingredientlist;
                oldContent.MealPrice = newContent.MealPrice;
                oldContent.TypeOfmeal = newContent.TypeOfmeal;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentFromList(string mealname)
        {
            MenuContent content = GetContentByMealName(mealname);
            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Helper method
        public MenuContent GetContentByMealName(string MealName)
        {
            foreach (MenuContent content in _listOfContent)
            {
                if (content.MealName.ToLower() == MealName.ToLower());
                {
                    return content;
                }
            }
            return null;
        }
    }
}
