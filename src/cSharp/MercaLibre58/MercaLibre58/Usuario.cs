using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MercaLibre58
{
    [Table("Usuario")]
    public class Usuario : EnteConCompras
    {
        [Key, Column("IdUsuario"), Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Column("Nombre"), Required, StringLength(45)]
        public string Nombre { get; set; }
        [Column("Apellido"), Required, StringLength(45)]
        public string Apellido { get; set; }
        [Column("Teléfono")]
        public int Telefono { get; set; }
        [Column("Nombre_Usuario"), Required, StringLength(100)]
        public string NombreUsuario { get; set; }
        [Column("Contraseña_Usuario"), Required,]
        public string ContraseñaUsuario { get; set; }
        [Column("Email"), Required, StringLength(100)]
        public string Email { get; set; }
        public Usuario() : base()
        {

        }
        public void Comprar(Producto producto, int cant)
        {
            if (producto.StockSuficiente(cant))
            {
                CompraVenta compra = new CompraVenta(cant, this, producto);

                AgregarCompra(compra);
                producto.DecrementarCant(cant);
            }
        }
        //public float TotalTicket => Items.Sum(item => item.TotalItem);
        public float RecaudacionTotal=>
        public float RecaudacionTotal(DateTime inicio, DateTime fin, Producto productos)
        {
            return  productos.RecaudacionPara.FindAll(rt => rt.Entre(inicio, fin)).Sum(rct => rct.TotalPrecio);
        }
        /*public float precioPromedioEntre(DateTime inicio, DateTime fin)
        {
            //Paso 1: filtro los Historiales que se encuentren entre esas fechas con el FindAll
            //Paso 2: sobre la lista filtrada, aplico el metodo para conocer el promedio
            return HistorialPrecios.FindAll(h => h.entre(inicio, fin)).
                                     Average(h => h.PrecioUnitario);
        }*/


    }
}
