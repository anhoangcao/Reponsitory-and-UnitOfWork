using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.Model;

namespace ReponsitoryAndUnitOfWork.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {  get; set; } 
    }
}
