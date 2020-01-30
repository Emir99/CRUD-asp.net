using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class BuildingContext: DbContext
    {
        public BuildingContext(DbContextOptions<BuildingContext> options):base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>().ToTable("Building");
            modelBuilder.Entity<Owner>().ToTable("Owner");
        }
    }
}
