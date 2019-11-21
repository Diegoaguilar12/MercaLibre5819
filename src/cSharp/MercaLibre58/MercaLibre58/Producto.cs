﻿using System;
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
        [ForeignKey("idVendedor"),Required]
        public Usuario Vendedor { get; set; }
        public Producto() : base()
        {
               
        }

        public void DecrementarCant( int cant)
        {
            Cantidad -= cant;
        }

        public bool StockSuficiente(int cant) => cant <= this.Cantidad;

        public float RecaudacionPara(DateTime inicio, DateTime fin)
        {
            return ComprasVentasEntre(inicio, fin).Sum(h => h.Precio);
        }
            
        public List<CompraVenta> ComprasVentasEntre(DateTime inicio, DateTime fin)
        {
            return ComprasVentas.FindAll(r => r.Entre(inicio, fin));
        }

        public override string ToString()
            => $"{NombreProducto} - Cantidad: {Cantidad} - ${PrecioProducto:0.00}c/u";
        
    }
}