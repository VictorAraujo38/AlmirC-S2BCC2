using Microsoft.EntityFrameworkCore;

namespace AlmirTrabs.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Racoes> Racoes { get; set; }

        public DbSet<Pets> Pets { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
