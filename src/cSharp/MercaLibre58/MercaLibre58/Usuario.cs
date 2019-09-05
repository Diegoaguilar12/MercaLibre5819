using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MercaLibre58
{  
    [Table ("Usuario")]
    public class Usuario:EnteConCompras
    {
        [Key]
        [Column ("IdUsuario"),Required,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        [Column("Nombre"),Required,StringLength(45)]
        public string Nombre { get; set; }
        [Column("Apellido"),Required,StringLength(45)]
        public string Apellido { get; set; }
        [Column("Teléfono")]
        public int Telefono { get; set; }
        [Column("Nombre_Usuario"),Required,StringLength(100)]
        public string NombreUsuario { get; set; }
        [Column("Contraseña_Usuario"),Required,]
        public string ContraseñaUsuario { get; set; }
        [Column("Email"),Required,StringLength(100)]
        public string Email { get; set; }
        public Usuario():base()
        {

        }   
        public void Comprar(Producto producto, int cant)
        {           
            
           
        }


    }
}
