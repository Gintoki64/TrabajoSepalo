using Microsoft.EntityFrameworkCore;
using PruebaCRUD.Models;
namespace PruebaCRUD.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
