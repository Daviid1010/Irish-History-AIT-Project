using System.Collections.Generic;

namespace IrishHistoryAITProject.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}