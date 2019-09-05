using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercaLibre58
{
    [Table ("Compra")]
    public class Compra
    {
        [Key]
        [Column ("idCompra"), Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCompra { get; set; }
        [Column("Precio Compra"),Required]
        public float precioCompra { get; set; }
        [Column("Cantidad Unidades"),Required]
        public byte cantUnidades { get; set; }
        [Column("Fecha y Hora"),Required]
        public DateTime fechaHora { get; set; }
        [ForeignKey("Producto")]
        [Column("Producto"),Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Producto producto { get; set; }
        [ForeignKey("Usuario")]
        [Column("Usuario"),Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Usuario usuario { get; set; }

    }
}
