using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrishHistoryAITProject.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string  Birth { get; set; }
        public string Death { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}