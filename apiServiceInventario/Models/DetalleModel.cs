using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class DetalleModel : DbContext
    {
        public DetalleModel()
            : base("name=DetalleModel")
        {
        }

        public virtual DbSet<Detalle> Detalle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
