using _02_KomodoRepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RepositoryPattern_Console
{
     public class ProgramUI
    {
        private VehicleContentRepository _contentRepo = new VehicleContentRepository();
        //Method that runs/starts the application
        public void Run()
        {
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
                    "3.View content By Vehicle Type\n" +
                    "4.Update Existing Content\n" +
                    "5.Delete Existing Content\n" +
                    "6.Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the users input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View Content by MealName
                        DisplayContentByVehicle();
                        break;
                    case "4":
                        //Update Existing Content
                        UpdateExistingcontent();
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
        private void CreateNewContent()
        {

            DisplayAllContent();

            //Ask for the mealname to update
            Console.WriteLine(" Enter the content of the content you'd like to update:");
            //Get the title
            string oldMealName = Console.ReadLine();

            VehicleContent newContent = new VehicleContent();
            //CarName
            Console.WriteLine("Enter the title for the content by vehicle type Gas, hybrid,or electric:");
            string vehicle = Console.ReadLine();
            int vehicleasInt = int.Parse(vehicle);
            newContent.TypeofVehicle = (VehicleType)vehicleasInt;
           
            //PriceValue
            Console.WriteLine("Enter the value of car content you are looking for (20,000, 30,000, 40,000)");

            newContent.PriceValue =int.Parse(Console.ReadLine());
            //Information
            Console.WriteLine("Enter the description for the content you would like.");
            
            newContent.Information = Console.ReadLine();
            //Vehicletype
            Console.WriteLine("Enter the car content by vehicle type you would like (Tesla, Honda,or ToyotaPrius)(Y/N)? ");
            string CarName = Console.ReadLine().ToLower();
            int CarNameAsInt = int.Parse(CarName);
            newContent.CarName = (CarName)CarNameAsInt;

            if (CarName == "y")
            {
                Console.WriteLine("List of VehicleTypes with CarNames/n" +
                    "1.GasCar" +
                    "2.ElectricCar" +
                    "3.Hybridcar/n" +
                    "4.Tesla" +
                    "5.Honda" +
                    "6.Toyota Priue");

                _contentRepo.AddContentToList(newContent);
            }
            
        }
        private void DisplayAllContent()
        {
            List<VehicleContent> listofContent = _contentRepo.GetContentList();
            foreach(VehicleContent content in listofContent)
            Console.WriteLine($"CarName: {content.CarName}\n" +
                $"$Information: {content.Information}");

        }
        private void DisplayContentByVehicle()
        {
            Console.Clear();
            //prompt the user to give me a Carname
            Console.WriteLine("Enter the CarName of Content you would like to see:");

            //Get the Users Input 
            string VehicleType = Console.ReadLine();
            // Display said content if it isn't null
            List<VehicleContent> content = _contentRepo.GetContentList();
            if (VehicleType != null)
            {
                Console.WriteLine($"VehicleType: {content.Count}/n" +
                    $"Information {content.Count}/n" +
                    $"CarName {content.Count}/n" +
                    $"PriceValue {content.Count}/n");
            }
                
        }
        private void UpdateExistingcontent()
        {
            //Display all Content
            DisplayAllContent();
            // Ask for CarName needed to update
            Console.WriteLine("Enter the carNAme fo the content you are wanting to update");
            //Get that CarName
            string oldCarName = Console.ReadLine();
            // build a new object

            VehicleContent newContent = new VehicleContent();
            //CarName
            Console.WriteLine("Enter the title for the content by vehicle type Gas, hybrid,or electric:");
            string vehicle = Console.ReadLine();
            int vehicleasInt = int.Parse(vehicle);
            newContent.TypeofVehicle = (VehicleType)vehicleasInt;

            //PriceValue
            Console.WriteLine("Enter the value of car content you are looking for (20,000, 30,000, 40,000)");

            newContent.PriceValue = int.Parse(Console.ReadLine());
            //Information
            Console.WriteLine("Enter the description for the content you would like.");

            newContent.Information = Console.ReadLine();
            //Vehicletype
            Console.WriteLine("Enter the car content by vehicle type you would like (Tesla, Honda,or ToyotaPrius)(Y/N)? ");
            string CarName = Console.ReadLine().ToLower();
            int CarNameAsInt = int.Parse(CarName);
            newContent.CarName = (CarName)CarNameAsInt;


            if (CarName == "y")
            {
                Console.WriteLine("List of VehicleTypes with CarNames/n" +
                    "1.GasCar" +
                    "2.ElectricCar" +
                    "3.Hybridcar/n" +
                    "4.Tesla" +
                    "5.Honda" +
                    "6.Toyota Priue");

                _contentRepo.AddContentToList(newContent);
            }

        }
        private void DeleteExistingContent()
        {
            Console.Clear();

            DisplayAllContent();

            //Get the CarName they wanted to remove
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
        
    }
}
