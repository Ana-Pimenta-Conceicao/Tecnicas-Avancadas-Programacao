using Dominus.Models;
using Microsoft.EntityFrameworkCore;

namespace Dominus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<InstrumentoModel> Instrumento { get; set; }
    }
}
