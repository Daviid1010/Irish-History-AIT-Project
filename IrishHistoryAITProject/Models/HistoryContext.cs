using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IrishHistoryAITProject.Models
{
    public class HistoryContext : DbContext
    {
        public HistoryContext() : base("HistoryContext")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}