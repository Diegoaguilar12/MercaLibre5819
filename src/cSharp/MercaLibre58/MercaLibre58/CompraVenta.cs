using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MercaLibre58
{
    [Table("CompraVenta")]
    public class CompraVenta
    {
        [Key, Column ("idCompraVenta"), Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Precio CompraVenta"), Required]
        public float Precio { get; set; }
        [Column("Cantidad Unidades"), Required]
        public int CantUnidades { get; set; }
        [Column("Fecha y Hora"), Required]
        public DateTime FechaHora { get; set; }

        [ForeignKey("Producto"), Required]
        public Producto Producto { get; set; }

        [ForeignKey("Usuario"), Required]
        public Usuario Usuario{ get; set; }
        [NotMapped]
        public float TotalPrecio => CantUnidades * Precio;
        public List<Producto> Comprados { get; set; }
        public List<Producto> Vendidos { get; set; }
        public bool Entre(DateTime inicio, DateTime fin)
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
        public CompraVenta(int cant, Usuario usuario, Producto producto)
        {
            CantUnidades = cant;
            Usuario = usuario;
            Producto = producto;
            FechaHora = DateTime.Now;   
        }

        
            
    }
        

}

