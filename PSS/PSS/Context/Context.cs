using System.Data.Entity;
using PSS.Models;

namespace SGCO.Context
{
    public class Context : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<FreightType> FreightTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}