using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDukan.Models
{
    public class Cart
    {
        public int ID { get; set; }
        [Column(TypeName = "Int")]
        public int UserId { get; set; }
        [Column(TypeName = "Int")]
        public int MedicineID { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal UnitePrice { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal Discount { get; set; }
        [Column(TypeName = "Int")]
        public int Quantity { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal Totalprice { get; set; }
    }
}

