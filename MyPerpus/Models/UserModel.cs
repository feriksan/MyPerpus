using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPerpus.Models
{
    [Table("Users")]
    internal class UserModel
    {
        [Column("user_id")]
        public Guid ID { get; set; }
        [Column("username")]
        [Required]
        public string Username { get; set; } = string.Empty;
        [Column("password")]
        [MinLength(8)]
        [Required]
        public string Password { get; set; } = string.Empty;
        [Column("email")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Column("phone")]
        public string Phone { get; set; } = string.Empty;
        [Column("isAdmin")]
        public bool IsAdmin { get; set; } = false;

    }
}
