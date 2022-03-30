using GymStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GymStore.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
