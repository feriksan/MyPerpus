using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Models
{
    [Table("Peminjaman")]
    internal class PeminjamanModel
    {
        [Column("KodePinjam")]
        public Guid ID { get; set; }
        [Column("KodeBuku")]
        public string KodeBuku { get; set; } = string.Empty;
        [Column("NIM")]
        public int NIM { get; set; }
        [Column("TanggalPinjam")]
        public DateTime TanggalPinjam { get; set; }
        [Column("LamaPinjam")]
        public int LamaPinjam { get; set; }

    }
}
