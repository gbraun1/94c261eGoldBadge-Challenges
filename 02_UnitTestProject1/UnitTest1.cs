using System;
using _02_KomodoRepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0
{
    [TestClass]
    public class VehicleContent_Test
    { 
        [TestMethod]
        public void addVehicle_Test()
        {
            //Arrange 
            VehicleContent content = new VehicleContent();
            VehicleContent _listofContent = new VehicleContent();

            //ACT
            bool addResult = _listofContent.Equals(content);

            //Assert
            Assert.IsTrue(addResult);
        }
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange 
            VehicleContent content = new VehicleContent();
            VehicleContent _listofContent = new VehicleContent();
            //ACT
            bool updatedResult = _listofContent.Equals(content);
            //ASSERT
            Assert.IsTrue(updatedResult);
            
        }

        [TestMethod]
        public void RemoveVehicle_Test()
        {
            //Arrange
            VehicleContent content = new VehicleContent();
            VehicleContent _listofContent = new VehicleContent();
            //ACT
            bool removeResult = _listofContent.Equals(content);
            //ASSERT
            Assert.IsTrue(removeResult);
        }
    }
}





    

