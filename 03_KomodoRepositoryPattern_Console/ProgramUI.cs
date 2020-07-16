using _03_KomodoRepositoryPattern_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_KomodoRepositoryPattern_Console
{
    public class ProgramUI
    {
        private readonly BadgeContentRepository _contentRepo = new BadgeContentRepository();


        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Enter the number of the badge options you'd like to select: \n" +
                "1. Create a new Badge \n" +
                "2. Update doors on an exsiting badge \n" +
                "3. Show a list with all badge numbers and door access. \n" +
                "4. Delete all doors form an exsisting badge \n" +
                "5. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        CreateNewContent();
                        break;
                    case "2":
                        //find by title
                        UpdatedExistingContent();
                        break;
                    case "3":
                        //Add new 
                        ShowAllContent();
                        break;
                    case "4":
                        //remove
                        RemoveContentFromList();
                        break;
                    case "5":
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 3. \n" +
                           "Press any key to continue....");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewContent()
        {
            Console.Clear();
            BadgesContent content = new BadgesContent();
            // BadgeNme
            Console.WriteLine("Please enter the employee Title content in the prompt: ");
            content.BadgeTitle = Console.ReadLine();
            Console.WriteLine("Select a BadgeOptions:/n" +
                "1.Name " +
                "2.Departement" +
                "3.Postion.");
            Console.WriteLine("Please enter the your postion Title: ");
            content.BadgeTitle = Console.ReadLine();
            Console.WriteLine("Please enter a valid number between 1 and 3. \n" +
           "Press any key to continue....");
            Console.ReadKey();
            Console.WriteLine("Please select badge option:/" +
                "1.NewBadge/n" +
                "2.BadgeUpdate/n" +
                "3.BadgeSearch");

            string BadgeName = Console.ReadLine();
            _contentRepo.Equals(content);
        }
        private void UpdatedExistingContent()
        {
            string badgeOptions = null;
            if (badgeOptions == "y")
            {
                Console.WriteLine("what BadgeOption content would you would like to Update?:\n" +
                    "1.DoorListOptions" +
                    "2.BadgeID" +
                    "3.BadgeTile");

            //DoorList
            BadgesContent newContent = new BadgesContent();
            Console.WriteLine("Enter the MealName");
            newContent.DoorList = Console.ReadLine();
            //BadgeID
            Console.WriteLine("Enter the description from the content:");
            newContent.BadgeID = Console.ReadLine();
            //Badge Title
            Console.WriteLine("Enter the ingredients  for the content (Burgers, Salads, Fries, Desserts, Coffee etc):");
            newContent.BadgeTitle = Console.ReadLine();

                _contentRepo.Equals(newContent);
            }

        }
        private void ShowAllContent()
        {
            Console.Clear();
            List<BadgesContent> listOfContent = new List<BadgesContent>();

            foreach (BadgesContent content in listOfContent)
            {
               
                Console.WriteLine("List of Badge content");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string Badgetitle = Console.ReadLine();
           
            if (Badgetitle != null)
            {
                Console.WriteLine("Invalid title. Cound not find any results.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
      

        }
        private void RemoveContentFromList()
        {
            Console.WriteLine("Which Badge information would you like to remove?");
            List<BadgesContent> contentList = new List<BadgesContent>();
            int count = 0;
            foreach (BadgesContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}{content.BadgeID}");
            }

            var targetContentId = int.Parse(Console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                BadgesContent desiredContent = contentList[targetIndex];
                if (desiredContent == contentList[targetIndex]);
                {
                    Console.WriteLine($"{desiredContent.BadgeID} successfully removed.");
                }
            }            else
            {
                Console.WriteLine("No content has that ID");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        private void DisplayContent(BadgesContent content)
        {
            Console.WriteLine($"Title: {content.BadgeID} \n" +
                $"Description: {content.BadgeTitle} \n" +
                $"Genre: {content.DoorList} \n");
        }
    }
}


