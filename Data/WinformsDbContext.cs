using System.Data.Entity;
using winforms_tutorial.Models;

namespace winforms_tutorial.Data
{
    public class WinformsDbContext : DbContext
    {
        // Constructor
        public WinformsDbContext()
            : base("name=WinformsDbContext")
        {
        }

        // DbSets goes here..
        // Register Category DbSet
        public DbSet<Category> Categories { get; set; }
    }
}