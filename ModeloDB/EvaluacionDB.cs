using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace ModeloDB
{
    public class EvaluacionDB:DbContext
    {
        //Declaración de las entidades del modelo
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Languaje> Languajes { get; set; }
        public DbSet<Film> Films { get; set; }

        //Configuración de la Conexión.
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server = DESKTOP-IQ678RP\\SQLEXPRESS; initial catalog=Evaluacion; trusted_connection=true;"
            );
        }

        //Configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación uno a muchos:en un inventario hay varias películas 
            modelBuilder.Entity<Inventory>()
                .HasOne(inv => inv.film)
                .WithMany(film => film.Inventories)
                .HasForeignKey(inv => inv.filmID);

            // Relación uno a muchos:una pelicula esta en varios idiomas 
            modelBuilder.Entity<Film>()
                .HasOne(film => film.languaje)
                .WithMany(lang => lang.Films)
                .HasForeignKey(film => film.languajeID);
        }

    }

}
