using Clase09.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase09.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; } = null!;
    }
}