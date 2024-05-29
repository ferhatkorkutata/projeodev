using Microsoft.EntityFrameworkCore;
using WebUygulamasi1.Models;

namespace WebUygulamasi1.Utility
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options): base(options) { }
        public DbSet<KitapTuru> KitapTurleri { get; set; }
    }
}
