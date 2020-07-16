using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoRepositoryPattern_Repository
{
    public enum VehicleType { GasCar =1, EletricCar, HybridCar }
    public enum CarName { Tesla = 1, Honda, ToyotaPrius }
    
    public class VehicleContent
    {
        public CarName CarName { get; set; }
        public int PriceValue { get; set; }
        public string Information { get; set; }
        public VehicleType TypeofVehicle { get; set; }


        public VehicleContent() { }
        public VehicleContent(CarName car, int price, string information, VehicleType vehicle ) 
        {
            CarName = car;
            PriceValue = price;
            Information = information;
            TypeofVehicle = vehicle;
        }
    }  
                
}
