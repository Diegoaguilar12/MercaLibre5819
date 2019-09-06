using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MercaLibre58
{
    [Table ("Producto")]
    public class Producto:EnteConCompras
    {
        [Key,Column("idProducto"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [Column("cantidad"),Required]
        public int Cantidad { get; set; }
        [Column("nombreProducto"),Required,StringLength(45)]
        public string NombreProducto { get; set; }
        [Column("precio"),Required]
        public float PrecioProducto { get; set; }
        [ForeignKey("Vendedor"),Required]
        public Usuario Vendedor { get; set; }
        public Producto() : base()
        {
               
        }

        public void DecrementarCant( int cant)
        {
            Cantidad -= cant;
        }

        public bool StockSuf(int cant) => cant <= this.Cantidad;

        public float RecaudacionPara(DateTime inicio, DateTime fin)
        {
            return comprasVentasEntre(inicio, fin).Sum(h => h.Precio);
        }

        private List<CompraVenta> comprasVentasEntre(DateTime inicio, DateTime fin)
        {
            return CompraVentas.FindAll(r => r.Entre(inicio, fin));
        }

    }
}