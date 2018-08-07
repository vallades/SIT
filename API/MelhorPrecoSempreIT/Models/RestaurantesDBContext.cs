using System.Data.Entity;

namespace MelhorPrecoSempreIT.Models
{
    public class RestaurantesDBContext : DbContext
    {
        public RestaurantesDBContext() : base("name=RestaurantesDBContext") { }

        public virtual DbSet<Pratos> Pratos { get; set; }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}