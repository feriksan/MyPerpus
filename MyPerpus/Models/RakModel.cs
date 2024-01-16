using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Models
{
    [Table("Raks")]
    internal class RakModel
    {
        [Column("Id")]
        public Guid ID { get; set; }
        [Column("RakName")]
        public string RakName { get; set; }
    }
}
