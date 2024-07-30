using Microsoft.EntityFrameworkCore;
using PizzariaMVC.Models;

namespace PizzariaMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}
