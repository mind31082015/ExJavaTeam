using System.Data.Entity;
using Repository.Domain;

namespace Repository.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
