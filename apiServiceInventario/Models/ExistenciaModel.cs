using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class ExistenciaModel : DbContext
    {
        public ExistenciaModel()
            : base("name=ExistenciaModel")
        {
        }

        public virtual DbSet<Existencia> Existencia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
