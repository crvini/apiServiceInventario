using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class PedidoModel : DbContext
    {
        public PedidoModel()
            : base("name=PedidoModel")
        {
        }

        public virtual DbSet<Pedidio> Pedidio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
