using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MercaLibre58
{
    class MySQL_ADO: DbContext

    {
        public DbSet<CompraVenta>Compras
        { get; set; }

        public DbSet<Producto>Productos
        { get; set; }
        public DbSet<Usuario>Usuarios
        { get; set; }

        public void AltaCompra(CompraVenta compras)
        {
            Compras.Add(compras);
            SaveChanges();
        }
        public void AltaUsuario(Usuario usuarios)
        {
            Usuarios.Add(usuarios);
            SaveChanges();
        }
        public void AltaProducto(Producto productos)
        {
            Productos.Add(productos);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ForeverLand;user=root;password=root");
        }
    }
}
 