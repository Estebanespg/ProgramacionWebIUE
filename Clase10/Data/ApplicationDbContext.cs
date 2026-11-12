using Clase10.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase10.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; } = null!;

        public DbSet<Ciudad> Ciudades { get; set; } = null!;

        public DbSet<Pais> Paises { get; set; } = null!;
    }
}