using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDukan.Models
{
    public class Medicines
    {
        public int ID { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Manufacturer { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal UnitPrice { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal Discount { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string ImageUrl { get; set; }
        [Column(TypeName = "Int")]
        public int Status { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime ExpDate { get; set; }

        //public string Type { get; set; }
    }
}


