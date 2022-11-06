using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("Roles")]
    public class Role
    {
        // Constructor
        public Role()
        {
        }

        // Role properties goes here...
        [Key] public int Id { get; set; }

        public string RoleName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        
        // Add relationship to UserRole model
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}