using System;
using _01_KomodoRepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_KomodoRepositoryPattern_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void SetMealname_ShouldgetCorrectString()
        {
            //Arrange
            MenuContent content = new MenuContent();
            content.MealName = "Burger";
            // ACT
            string expected = "Burger";
            string actual = content.MealName;
            // ASSERT
            Assert.AreEqual(expected, actual);
        }
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange 
            MenuContent content = new MenuContent();
            MenuContentRepository _contentRepo = new MenuContentRepository();

            //ACT
            bool addResult = _contentRepo.Equals(content);

            //Assert
            Assert.IsTrue(addResult);
        }
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange 
            MenuContent newContent = new MenuContent();
            MenuContent vehicleType = new MenuContent();
            //ACT
            bool updatedResult = newContent.Equals(vehicleType);
            //ASSERT
            Assert.IsTrue(updatedResult);

        }

        [TestMethod]
        public void RemoveContentFromList_ShouldReturnTrue()
        {

            //Arrange
            MenuContent content = new MenuContent();
            MenuContent _listofContent = new MenuContent();
            //ACT
            bool removeResult = _listofContent.Equals(content);
            //ASSERT
            Assert.IsTrue(removeResult);
        }
    }
    
}




    

