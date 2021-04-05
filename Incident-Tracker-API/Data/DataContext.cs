using Incident_Tracker_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incident_Tracker_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackerDetails>().HasData(new TrackerDetails
            {
                Id = 1,
                Description = "Test1",
                Severity = "High",
                Status= "inprogress",
                CreatedDate = DateTime.Now,
                UpdateDate = DateTime.Now
            });
        }

        public DbSet<TrackerDetails> tbTracker { get; set; }
    }
}
