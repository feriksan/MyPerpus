using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Models
{
    [Table("Anggota")]
    internal class AnggotaModel
    {
        [Column("NIM")]
        public string ID { get; set; }
        [Column("Nama")]
        public string Nama { get; set; }
        [Column("Jurusan")]
        public string Jurusan { get; set; }
        [Column("NoHp")]
        public string NoHp { get; set; }
        [Column("Alamat")]
        public string Alamat {  get; set; }

    }
}
