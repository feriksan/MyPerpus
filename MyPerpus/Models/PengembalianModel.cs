using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Models
{
    [Table("Pengembalian")]
    internal class PengembalianModel
    {
        [Column("KodePinjam")]
        public string ID {  get; set; }
        [Column("KodeBuku")]
        public string KodeBuku { get; set; }
        [Column("NIM")]
        public int NIM { get; set; }
        [Column("JatuhTempo")]
        public DateTime JatuhTempo { get; set; }
        [Column("TanggalPinjam")]
        public DateTime TanggalPinjam { get; set; }
        [Column("LamaPinjam")]
        public int LamaPinjam { get; set; }
        [Column("TanggalKembali")]
        public DateTime TanggalKembali { get; set; }
        [Column("Denda")]
        public int Denda {  get; set; }
        [Column("TotalDenda")]
        public int TotalDenda {  get; set; }
    }
}
