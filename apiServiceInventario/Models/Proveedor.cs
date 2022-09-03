namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [Key]
        public int idProveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Nit { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Cuidad { get; set; }
    }
}
