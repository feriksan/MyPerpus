using System.ComponentModel.DataAnnotations.Schema;

namespace MyPerpus.Models
{
    [Table("Authors")]
    internal class AuthorModel
    {
        [Column("author_id")]
        public Guid ID { get; set; }
        [Column("author_name")]
        public string AuthorName { get; set; } = string.Empty;
    }
}
