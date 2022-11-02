using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("Products")]
    public class Product
    {
        // Constructor
        public Product()
        {

        }

        // Product properties goes here...
        [Key]
        public int Id { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Add relationship to Category model
        public Category Category { get; set; }
    }
}