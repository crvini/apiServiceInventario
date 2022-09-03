namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [Key]
        public int idProducto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public int Marca_idMarca { get; set; }

        public int Proveedor_idProveedor { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Descripcion { get; set; }
    }
}
