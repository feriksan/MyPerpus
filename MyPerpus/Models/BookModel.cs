using System.ComponentModel.DataAnnotations.Schema;

namespace MyPerpus.Models
{
    [Table("Books")]
    internal class BookModel
    {
        [Column("KodeBuku")]
        public Guid ID { get; set; }
        [Column("Judul")]
        public string Judul { get; set; } = string.Empty;
        [Column("Penulis")]
        public string Penulis { get; set; } = string.Empty;
        [Column("Penerbit")]
        public string Penerbit { get; set; } = string.Empty;
        [Column("Tahun")]
        public int Tahun { get; set; }

    }
}
