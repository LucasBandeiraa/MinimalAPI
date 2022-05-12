using APIminimal.Models;
using Microsoft.EntityFrameworkCore;

namespace APIminimal.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) => Database.EnsureCreated();

        public DbSet<Livro> Livro { get; set; }
    }
}
