using Microsoft.EntityFrameworkCore;

namespace FunAtWork.Infrastructure.FunAtWorkDb
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // DbSet'ler burada tanımlanacak
    }
}