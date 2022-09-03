using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Usuarios")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);
        }
    }
}
