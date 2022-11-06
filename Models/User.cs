using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("Users")]
    public class User
    {
        // Constructor
        public User()
        {
        }

        // User properties goes here...
        [Key] public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Add relationship to UserRole model
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}