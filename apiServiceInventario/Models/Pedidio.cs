namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedidio")]
    public partial class Pedidio
    {
        [Key]
        public int idPedidio { get; set; }

        public int Usuario_idUsuario { get; set; }

        public double Total { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
    }
}
