using System.Collections.Generic;

namespace IrishHistoryAITProject.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string name { get; set; }
        public string Date { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}