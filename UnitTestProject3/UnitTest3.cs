using System;
using _03_KomodoRepositoryPattern_repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        private object _Repo;

        [TestMethod]

        public void addBadge_Test()
        {
            //Arrange 
            BadgesContent _contentRepo = new BadgesContent();
            BadgesContent carName = new BadgesContent();

            //ACT
            bool addResult = _contentRepo.Equals(carName);

            //Assert
            Assert.IsTrue(addResult);
        }
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange 
            BadgesContent newContent = new BadgesContent();
            BadgesContent vehicleType = new BadgesContent();
            //ACT
            bool updatedResult = newContent.Equals(vehicleType);
            //ASSERT
            Assert.IsTrue(updatedResult);

        }

        [TestMethod]
        public void RemoveVehicle_Test()
        {
            //Arrange
            BadgesContent _contentRepo = new BadgesContent();
            BadgesContent vehicleType = new BadgesContent();
            //ACT
            bool removeResult = _contentRepo.Equals(vehicleType);
            //ASSERT
            Assert.IsTrue(removeResult);
        }
    }
}
                 
           
        
        
        
        

        
    





