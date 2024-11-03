using Microsoft.EntityFrameworkCore;
using MiApiClientes.Models;

namespace MiApiClientes.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionGeneral> InformacionGeneral { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformacionGeneral>()
                .HasOne(i => i.Cliente)
                .WithMany()
                .HasForeignKey(i => i.ClienteId);
        }
    }
}
