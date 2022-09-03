namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sucursal")]
    public partial class Sucursal
    {
        [Key]
        public int idAlmacen { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Direccion { get; set; }
    }
}
