using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercaLibre58
{
    [Table ("Producto")]
    class Producto
    {
        [Key,Column("idProducto"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        [Column("cantidad"),Required]
        public int cantidad { get; set; }
        [Column("nombreProducto"),Required,StringLength(45)]
        public string nombreProducto { get; set; }
        [Column("precio"),Required]
        public float precio { get; set; }
        [Column("vendedor"),Required]
        public Usuario vendedor { get; set; }
        public List<Compra> Compras { get; set; }
    }
}

