using Microsoft.EntityFrameworkCore;
using Riode.WebUI.Models.Entities;

namespace Riode.WebUI.Models.DataContexts
{
    public class RiodeDbContext:DbContext
    {
       
        public RiodeDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
