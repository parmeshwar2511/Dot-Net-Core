using System.Data.Entity;

namespace DAL
{
    public  class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

    }
}
