using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerpus.Models
{
    [Table("Borrow")]
    internal class BorrowModel
    {
        [Column("borrow_id")]
        public Guid ID { get; set; }
        [Column("borrower")]
        public string Borrower { get; set; } = string.Empty;
        [Column("checkout_date")]
        public DateTime CheckoutDate { get; set; }
        [Column("return_date")]
        public DateTime ReturnDate { get; set; }
        [Column("actual_return_date")]
        public DateTime ActualReturnDate { get; set; }
    }
}
