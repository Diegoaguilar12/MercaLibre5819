using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;

namespace MercaLibre58
{
    [Table("Usuario")]
    public class Usuario : EnteConCompras
    {
        
        [Key]
        [Column("IdUsuario"), Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Column("Nombre"), Required, StringLength(45)]
        public string Nombre { get; set; }
        [Column("Apellido"), Required, StringLength(45)]
        public string Apellido { get; set; }
        [Column("Teléfono")]
        public int? Telefono { get; set; }
        
        [Column("Username"), Required, StringLength(100)]
        public string NombreUsuario { get; set; }
        [Column("Pass"), Required,]
        public string ContraseñaUsuario { get; set; }
        
        [Column("Email"), Required, StringLength(100)]
        public string Email { get; set; }
        public List<Producto> ProductoVendidos { get; set; }
        [NotMapped]
        public string NombreCompleto => $"{Apellido}, {Nombre}";
        public Usuario() : base()
        {

        }
        
        public void Comprar(Producto producto, int cant)
        {
            if (producto.StockSuficiente(cant))
            {
                CompraVenta compra = new CompraVenta(cant, this, producto);
                agregarCompra(compra);
                producto.Vendedor.ProductoVendidos.Add(producto);
                
                producto.DecrementarCant(cant);
            }
        }
        
        public float RecaudacionTotal(DateTime inicio, DateTime fin)
        {          
            return ProductoVendidos.Sum(pv => pv.RecaudacionPara(inicio, fin));
        }
       


    }
}
