using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoRepositoryPattern_repository
{
    public class BadgeContentRepository
    {
        public class StreamingContentRepository
        {
            protected readonly List<BadgesContent> _contentDirectory = new List<BadgesContent>();

            //CRUD
            public bool AddContentToDirectory(BadgesContent content)
            {
                int startingCount = _contentDirectory.Count;
                _contentDirectory.Add(content);
                bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
                return wasAdded;
            }

            public List<BadgesContent> GetContents()
            {
                return _contentDirectory;
            }

            public bool UpdateExistingContent(BadgesContent newContent)
            {
                BadgesContent oldContent = newContent;
                if (oldContent != null)
                {
                    oldContent.BadgeID = newContent.BadgeID;
                    oldContent.BadgeTitle = newContent.BadgeTitle;
                    oldContent.DoorList = newContent.DoorList;

                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool DeleteExistingContent(BadgesContent existingContent)
            {
                bool deleteResult = _contentDirectory.Remove(existingContent);
                return deleteResult;
            }
            //Build Methods
            // Get by other parameters
            // Get By Rating
            // Get By Family Friendly
            // Etc

        }
    
    }
}



    

