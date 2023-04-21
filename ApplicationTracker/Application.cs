using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTracker
{
    class Application
    {
        public Application(string company,
            string position,
            string announcementID,
            string link,
            DateTime dateApplied,
            string currentStatus,
            string[] notes)
        {
            Company = company;
            Position = position;
            AnnouncementID = announcementID;
            Link = link;
            DateApplied = dateApplied;
            CurrentStatus = currentStatus;
            Notes = notes;
        }

        public string Company { get; set; }
        public string Position { get; set; }
        public string AnnouncementID { get; set; }
        public string Link { get; set; }
        public DateTime DateApplied { get; set; }
        public string CurrentStatus { get; set; }
        public string[] Notes { get; set; }

    }
}
