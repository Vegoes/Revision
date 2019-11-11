using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplicacion
{
    public static class BD
    {
        //public static string ligazon = Path.Combine(Directory.GetCurrentDirectory(), @"netcoreapp3.0\DespensaBD.db");

        public static List<ProductoNovo> CargarProducto()
        {
            using (IDbConnection conexion = new SQLiteConnection(Conexion()))
            {
                var productoCargado = conexion.Query<ProductoNovo>("select * from Productos", new DynamicParameters());
                return productoCargado.ToList();
            }
        }

        public static void GardarProducto(ProductoNovo producto)
        {
            using (IDbConnection conexion = new SQLiteConnection(Conexion()))
            {
                conexion.Execute("insert into Productos (Nome, Marca, Cantidades, Lugar, Caducidade) values " +
                    "(@Nome, @Marca, @Cantidades, @Lugar, @Caducidade)", producto);
            }
        }

        public static void BorrarProducto(ProductoNovo borrar)
        {
            using (IDbConnection conexion = new SQLiteConnection(Conexion()))
            {
                conexion.Execute("delete from Productos where Id = " + borrar.Id);
            }
        }

        public static void EditarProducto(ProductoNovo editar, int numEditar)
        {
            using (IDbConnection conexion = new SQLiteConnection(Conexion()))
            {
                conexion.Execute(string.Format("UPDATE Productos SET Nome=\"{0}\", Marca=\"{1}\", Cantidades={2}, Lugar=\"{3}\",Caducidade=\"{4}\" where id ={5}",
                    editar.Nome, editar.Marca, editar.Cantidades, editar.Lugar, editar.Caducidade, numEditar));
            }
        }

        private static string Conexion(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
