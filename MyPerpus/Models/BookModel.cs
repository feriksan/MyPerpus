using System.ComponentModel.DataAnnotations.Schema;

namespace MyPerpus.Models
{
    [Table("Books")]
    internal class BookModel
    {
        [Column("book_id")]
        public Guid ID { get; set; }
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("author_id")]
        public int AuthorID { get; set; }
        [Column("publication_year")]
        public int PublicationYear { get; set; }
        [Column("isbn")]
        public string ISBN { get; set; } = string.Empty;

    }
}
