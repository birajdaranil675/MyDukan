using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDukan.Models
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Int")]
        public int UserId { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string OrderNo { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal OrderTotal { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string OrderStatus { get; set; }
    }
}



