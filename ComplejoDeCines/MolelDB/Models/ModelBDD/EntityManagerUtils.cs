using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ComplejoDeCines.Models
{
    public class EntityManagerUtils:DbContext
    {
        public EntityManagerUtils() : base("name=CONEXION_WEBCONFIG") { }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cartelera> Carteleras { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Versione> Versiones { get; set; }
        public DbSet<TiposDocumento> TiposDocumentos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}