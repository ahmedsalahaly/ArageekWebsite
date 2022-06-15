using ArageekWebsite.Parent;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArageekWebsite.Models
{
    public class User : Humen
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole userRole { get; set; }
    }
}
