using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace winforms_tutorial.Models
{
    [Table("UserRoles")]
    public class UserRole
    {
        //Constructor   
        public UserRole()
        {
        }

        // Properties goes here...
        [Key] 
        public int Id { get; set; }

        [ForeignKey("User")] 
        [Column(Order = 1)]
        public int? UserId { get; set; }

        [ForeignKey("Role")] 
        [Column(Order = 2)]
        public int? RoleId { get; set; }
        
        // Add relationship to User Model
        public virtual User User { get; set; }
    }
}