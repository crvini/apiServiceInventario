namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Detalle")]
    public partial class Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pedidido_idPedidio { get; set; }

        public int Producto_idProducto { get; set; }

        public int Producto_Marca_idMarca { get; set; }

        public int Producto_proveedor_idProveedor { get; set; }

        public int Cantidad { get; set; }
    }
}
