using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class TermeszetVedelemContext : DbContext
    {
        public TermeszetVedelemContext(DbContextOptions<TermeszetVedelemContext> options) :
            base(options)
        { }

        public DbSet<Kategoria> kategoria { get; set; }

        public DbSet<Teszt> teszt { get; set; }
    }
}
