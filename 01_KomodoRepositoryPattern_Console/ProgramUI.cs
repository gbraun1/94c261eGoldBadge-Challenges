using _01_KomodoRepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoRepositoryPattern_Console
{
    class ProgramUI
    {

        private MenuContentRepository _contentRepo = new MenuContentRepository();
        
        //Method that runs/starts the application
        public void Run()
        {
            SeedContentlist();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1.Create New Content\n" +
                    "2.View All Content\n" +
                    "3.View content By MealName\n" +
                    "4.Update Existing Content\n" +
                    "5.Delete Existing Content\n" +
                    "6.Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the users input ads act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreatNewContent();
                        break;
                    case "2":
                        //View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View Content by MealName
                        DisplayContentbyMealName();
                        break;
                    case "4":
                        //Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                       
                }
                Console.WriteLine("Pleass press any key to continue...");
                Console.Clear();
            }
        }
        // Create new MenuContent
        private void CreatNewContent()
        {
            Console.Clear();

            //MealName
            MenuContent newContent = new MenuContent();
            Console.WriteLine("Enter the MealName");
            newContent.MealName = Console.ReadLine();
            //Description
            Console.WriteLine("Enter the description from the content:");
            newContent.DescriptionType = Console.ReadLine();
            //Ingredident list
            Console.WriteLine("Enter the ingredients  for the content (Burgers, Salads, Fries, Desserts, Coffee etc):");
            newContent.Ingredientlist = Console.ReadLine();
            //MealPrice
            Console.WriteLine("Enter the the Meal price for the content(10, 7, 3, 5, 2 etc):");
            string mealpriceAsString = Console.ReadLine();
            //Mealtype 
            Console.WriteLine("Would you like to enter the order content of your meal you would like?(y/n)");
            string TypeOfMealString = Console.ReadLine().ToLower();
           

            if (TypeOfMealString == "y")
            {
                Console.WriteLine("Enter the meal you would like:\n" +
                    "1.Burgers" +
                    "2.Salad" +
                    "3.Fries" +
                    "4.Deserts" +
                    "5.Coffee");

                string TypeofMealAsString = Console.ReadLine();
                int TypeofMealAsInt = int.Parse(TypeofMealAsString);
                newContent.TypeOfmeal = (MealType)TypeofMealAsInt;

                _contentRepo.AddContentToList(newContent);
                    
            }
        }
        //View Current MenuContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<MenuContent> listOfContent = _contentRepo.GetContentList();

            foreach (MenuContent content in listOfContent)
            {
                Console.WriteLine($"Menu: {content.MealName}\n" +
                    $"Desc: {content.DescriptionType}");

            }                
        }

        //View existing Content by MealName
        private void DisplayContentbyMealName()
        {
            
            Console.Clear();
            //Prompt the user to give me a mealname
            Console.WriteLine("Enter the MealName of the content you would like to see");
            // Get the Users Input
            string MealName = Console.ReadLine();
            //find content by that MealName
           MenuContent content = _contentRepo.GetContentByMealName(MealName);
            //Display said content if not null
            if (content !=null)
            {
                Console.WriteLine($"MealName: {content.MealName}\n" +
                    $"Discription: {content.DescriptionType}\n" +
                    $"IngredientList: {content.Ingredientlist}\n" +
                    $"MealPrice: {content.MealPrice}\n" +
                    $"TypeOfMeal: {content.TypeOfmeal}");
            }
            else
            {
                Console.WriteLine( "No content by that MealName");
            }

        }

        // Update Existing Content
        private void UpdateExistingContent()
        {
            //Display all content

            DisplayAllContent();

            //Ask for the mealname to update
            Console.WriteLine(" Enter the content of the content you'd like to update:");
            //Get the title
            string oldMealName = Console.ReadLine();
         // build a new object

             //MealName
            MenuContent newContent = new MenuContent();
            Console.WriteLine("Enter the MealName");
            newContent.MealName = Console.ReadLine();
            //Description
            Console.WriteLine("Enter the description from the content:");
            newContent.DescriptionType = Console.ReadLine();
            //Ingredident list
            Console.WriteLine("Enter the ingredients  for the content (Burgers, Salads, Fries, Desserts, Coffee etc):");
            newContent.Ingredientlist = Console.ReadLine();
            //MealPrice
            Console.WriteLine("Enter the the Meal price for the content(10, 7, 3, 5, 2 etc):");
            string mealpriceAsString = Console.ReadLine();
            //Mealtype 
            Console.WriteLine("Would you like to enter the order content of your meal you would like?(y/n)");
            string TypeOfMealString = Console.ReadLine().ToLower();


            if (TypeOfMealString == "y")
            {
                Console.WriteLine("Enter the meal you would like:\n" +
                    "1.Burgers" +
                    "2.Salad" +
                    "3.Fries" +
                    "4.Deserts" +
                    "5.Coffee");

                string TypeofMealAsString = Console.ReadLine();
                int TypeofMealAsInt = int.Parse(TypeofMealAsString);
                newContent.TypeOfmeal = (MealType)TypeofMealAsInt;

                _contentRepo.AddContentToList(newContent);
            }

        }
        //Delete Existing content
        private void DeleteExistingContent()
        {
            Console.Clear();

            DisplayAllContent();

            //Get the mealname they wanted to remove
            Console.WriteLine("Enter the title of the content you'd like to remove:");

            string input = Console.ReadLine();

            //Call the deleted method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            //If the content was deleted, say so.
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }
            //Otherwise state it could not be deleted.
        }
        //Seed method
        private void SeedContentlist()
        {
            MenuContent FoodOptions = new MenuContent("FoodOptions", "Burgers.","is a healthy option","OrganicMeet", 10, MealType.Fries);

            _contentRepo.AddContentToList(FoodOptions);
        }
    }
}
