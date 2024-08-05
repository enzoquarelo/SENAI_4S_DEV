using API_para_estudos_com_xUnit.Domains;
using Microsoft.EntityFrameworkCore;

namespace API_para_estudos_com_xUnit.Context
{
    public class Product_Context : DbContext
    {
        public DbSet<Products> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE06-SALA19\\SQLEXPRESS; Database= Products_Manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
