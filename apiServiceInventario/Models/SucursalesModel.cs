using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class SucursalesModel : DbContext
    {
        public SucursalesModel()
            : base("name=SucursalesModel")
        {
        }

        public virtual DbSet<Sucursal> Sucursal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sucursal>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursal>()
                .Property(e => e.Direccion)
                .IsUnicode(false);
        }
    }
}
