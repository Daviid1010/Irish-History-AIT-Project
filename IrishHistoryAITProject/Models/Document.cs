using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrishHistoryAITProject.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}