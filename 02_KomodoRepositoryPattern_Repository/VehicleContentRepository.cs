using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoRepositoryPattern_Repository
{
    public class VehicleContentRepository
      
    {
        public List<VehicleContent> _listOfContent = new List<VehicleContent>();
        //Create
        public void AddContentToList(VehicleContent content)
        {
            _listOfContent.Add(content);
        }

        //Read
        public List<VehicleContent> GetContentList()
        {
            return _listOfContent;
        }

        //Update
        public bool UpdateExistingContent(VehicleType Originalvehicle, VehicleContent newContent)
        {
            //Find the content
            VehicleContent oldContent = GetContentByTypeofVehicle(Originalvehicle);
            //update the content
            if (oldContent != null)
            {
                oldContent.CarName = newContent.CarName;
                oldContent.Information = newContent.Information;
                oldContent.PriceValue = newContent.PriceValue;
                
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentFromList(VehicleType Vehicle)
        {
            VehicleContent content = GetContentByTypeofVehicle(Vehicle);
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
        public VehicleContent GetContentByTypeofVehicle(VehicleType vehicle)
        {
            foreach (VehicleContent content in _listOfContent)
            {
                if (content.TypeofVehicle == vehicle);
                {
                    return content;
                }
            }
            return null;
        }

        public bool RemoveContentFromList(string input)
        {
            throw new NotImplementedException();
        }
    }
}

    

