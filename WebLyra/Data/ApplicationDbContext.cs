using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebLyra.Models;



namespace WebLyra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //add models
        public DbSet<FolioControl> FolioControl { get; set; }
        public DbSet<Shiff> Shiff { get; set; }
    }
}
