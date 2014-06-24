using System.Data.Entity;
using LeisureCoding.Domain.Models;

namespace LeisureCoding.Persistence.EntityFramework
{
    public class LeisureCodingContext : DbContext
    {
        public DbSet<Domain.Models.Content> Contents { get; set; }

    }
}
