using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercaLibre58
{
    [Table("CompraVenta")]
    public class CompraVenta
    {
        [Key,Column("idCompraVenta"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("PrecioCompraVenta"), Required]
        public float Precio { get; set; }
        [Column("Cantidad"), Required]
        public int CantUnidades { get; set; }
        [Column("fechayhora"), Required]
        public DateTime FechaHora { get; set; }

        [ForeignKey("idProducto"), Required]
        public Producto Producto { get; set; }

        [ForeignKey("idComprador"), Required]
        public Usuario Comprador{ get; set; }

        [NotMapped]
        public float TotalPrecio => CantUnidades * Precio;


        public CompraVenta()
        {

        }
        public CompraVenta(int cant, Usuario usuario, Producto producto)
        {
            CantUnidades = cant;
            Comprador = usuario;
            Producto = producto;
            FechaHora = DateTime.Now;
            Precio = producto.PrecioProducto;            
        }

        public bool Entre ( DateTime inicio , DateTime fin)
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
        

        
            
    }
        

}

