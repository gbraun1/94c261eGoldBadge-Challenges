using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoRepositoryPattern_repository
{

    public enum BadgeOptions {NewBadge, Updatebadge, BadgeSearch }
    public enum BadgeNumber { verificationOne, verificationTwo, verificationThree, }


    public class BadgesContent
    {
        public string DoorList { get; set; }
        public BadgeNumber TypeBadgeNumber { get; set; }
        public string BadgeID { get; set; }
        public BadgeOptions TypeBadgeOptions { get; set; }
        public string BadgeTitle { get; set; }

        public BadgesContent(string doorlist, BadgeNumber badgeNumber, string badgeID, BadgeOptions badgeoptions, string badgeTitle) 
        {
            DoorList = doorlist;
            TypeBadgeNumber = badgeNumber;
            BadgeID = badgeID;
            TypeBadgeOptions = badgeoptions;
            BadgeTitle = badgeTitle;
        }

        public BadgesContent()
        {
        }
    }
}
   
