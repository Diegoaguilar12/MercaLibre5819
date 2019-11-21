using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MercaLibre58
{
    public class MySQL_ADO: DbContext

    {
        public DbSet<CompraVenta>Compras
        { get; set; }

        public DbSet<Producto>Productos
        { get; set; }
        public DbSet<Usuario>Usuarios
        { get; set; }

        internal MySQL_ADO(DbContextOptions dbo) : base(dbo) { }

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
        public void actualizarInfo(Usuario usuarios)
        {
            this.Attach<Usuario>(usuarios);
            SaveChanges();

        }
        public Usuario usuarioPorNomUsuarioPass(string nombreUsuario, string ContraseñaUsuarioEncriptada)
            => Usuarios.FirstOrDefault(c => c.NombreUsuario == nombreUsuario && c.ContraseñaUsuario == ContraseñaUsuarioEncriptada);

        public List<Producto> ProductosEnVentaDe(Usuario usuario) 
            => Productos.
               Where(p => p.Vendedor == usuario).
               ToList();
    }
}
 