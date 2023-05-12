using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDukan.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string LastName { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Password { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Email { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal Fund { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Type { get; set; }
        [Column(TypeName = "Int")]
        public int Status { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime CreatedOn { get; set; }
    }
}
