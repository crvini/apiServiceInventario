using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiServiceInventario.Models
{
    public partial class MarcaModel : DbContext
    {
        public MarcaModel()
            : base("name=MarcaModel1")
        {
        }

        public virtual DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
