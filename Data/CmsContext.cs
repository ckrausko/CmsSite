
using Microsoft.EntityFrameworkCore;
using Cms.Models;

namespace Cms.Data
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
    }
}
