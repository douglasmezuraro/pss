using System.Data.Entity;
using PSS.Models;

namespace SGCO.Context
{
    public class Context : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}