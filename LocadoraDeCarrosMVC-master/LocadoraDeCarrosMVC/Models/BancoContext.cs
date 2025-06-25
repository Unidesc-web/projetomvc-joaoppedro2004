using Microsoft.EntityFrameworkCore;

namespace LocadoraDeCarrosMVC.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }
    }
}
