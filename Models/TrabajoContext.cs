using System;
using Microsoft.EntityFrameworkCore;

namespace Trabajo.Models
{
    public class TrabajoContext : DbContext
    {
        public TrabajoContext(DbContextOptions<TrabajoContext> options) 
        : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Alumno>().HasData(
                new Alumno {
                    Id = 1,
                    Nombre = "Andres Frias",
                    Codigo=1811586,
                    Password = "666"
                },
                new Alumno {
                    Id = 2,
                    Nombre = "Denis castillo",
                    Codigo= 123443,
                    Password = "999"
                }
            );
            modelBuilder.Entity<Evento>().HasData(
                new Evento{
                    Id=1,
                    Nombre="Trabajo comunitario",
                    Direccion="Av Los frutales 666 La molina",
                    Descripcion="Ayudar a recibir alimentos y bebidas y empaquetarlas para ser llevadas a puno",
                    Foto="https://api.netnoticias.mx/im/2017/09/10/770x490-tMlnQSNblV09w.JPG",
                    
                
                }
            );
        }

        
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Evento> Eventos { get; set; }

    }

    
        
}