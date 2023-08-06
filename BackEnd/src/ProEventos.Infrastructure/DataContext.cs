using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;

namespace ProEventos.Infrastructure
{
    public class DataContext:DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}