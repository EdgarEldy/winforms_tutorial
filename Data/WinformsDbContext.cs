using System.Data.Entity;

namespace winforms_tutorial.Data
{
    public class WinformsDbContext : DbContext
    {
        // Constructor
        public WinformsDbContext()
            : base("name=WinformsDbContext")
        {
        }
    }
}