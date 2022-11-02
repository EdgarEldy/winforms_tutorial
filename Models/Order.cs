using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("Orders")]
    public class Order
    {
        // Constructor
        public Order()
        {
            
        }
        
        // Order properties goes here...
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }

        public int Qty { get; set; }

        public double Total { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}