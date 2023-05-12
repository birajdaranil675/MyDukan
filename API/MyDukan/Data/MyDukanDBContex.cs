using Microsoft.EntityFrameworkCore;
using MyDukan.Models;

namespace MyDukan.Data
{
    public class MyDukanDBContex: DbContext
    {
        public MyDukanDBContex(DbContextOptions<MyDukanDBContex> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Medicines> Medicines { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}
