using Microsoft.EntityFrameworkCore;
using KoiCareSystemAtHome.WebApplication.Models;

namespace KoiCareSystemAtHome.WebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<News> News { get; set; }
    }
}