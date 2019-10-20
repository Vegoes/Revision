using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    class BD
    {
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

        private static string Conexion(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
