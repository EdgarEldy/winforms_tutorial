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

        // Register Product DbSet
        public DbSet<Product> Products { get; set; }

        // Register Customer DbSet
        public DbSet<Customer> Customers { get; set; }

        // Register Order DbSet
        public DbSet<Order> Orders { get; set; }
        
        // Register User DbSet
        public DbSet<User> Users { get; set; }
        
        // Register Role DbSet
        public DbSet<Role> Roles { get; set; }
        
        // Register UserRole DbSet
        public DbSet<UserRole> UserRoles { get; set; }
    }
}