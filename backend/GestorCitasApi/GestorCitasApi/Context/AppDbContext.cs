using GestorCitasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorCitasApi.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cita> Citas { get; set; }
    }
}
