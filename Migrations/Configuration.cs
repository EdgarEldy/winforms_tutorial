
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace winforms_tutorial.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<winforms_tutorial.Data.WinformsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}