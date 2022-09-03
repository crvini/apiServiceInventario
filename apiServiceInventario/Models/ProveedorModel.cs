using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class ProveedorModel : DbContext
    {
        public ProveedorModel()
            : base("name=ProveedorModel")
        {
        }

        public virtual DbSet<Proveedor> Proveedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Nit)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Cuidad)
                .IsUnicode(false);
        }
    }
}
