namespace apiServiceInventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marca")]
    public partial class Marca
    {
        [Key]
        public int idMarca { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
