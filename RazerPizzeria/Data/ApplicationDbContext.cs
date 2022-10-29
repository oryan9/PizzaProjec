using Microsoft.EntityFrameworkCore;
using RazerPizzeria.Model;

namespace RazerPizzeria.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> pizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }



    }
}
