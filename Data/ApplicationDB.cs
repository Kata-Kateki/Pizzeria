using Pizzeria.Models;
using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Data
{
    public class ApplicationDB : DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}