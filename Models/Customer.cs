using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("Customers")]
    public class Customer
    {
        // Constructor
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        // Customer properties goes here...
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Add relationship to Order model
        public virtual ICollection<Order> Orders { get; set; }
    }
}