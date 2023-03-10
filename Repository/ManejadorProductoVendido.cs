using WebApiCoder.Models;
using System.Data.SqlClient;

namespace WebApiCoder.Repository
{
  internal static class ManejadorProductoVendido
    {
        public static string connetionString = "Data Source=DESKTOP-41B85ST;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void InsertarProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection conn = new SqlConnection(connetionString))
            {

                SqlCommand comando = new SqlCommand();

                comando.Connection = conn;
                comando.Connection.Open();
                comando.CommandText = @"INSERT INTO ProductoVendido ([Stock], [IdProducto],[IdVenta] ) VALUES( @stock, @idProducto, @idVenta)";

                comando.Parameters.AddWithValue("@stock", productoVendido.Stock);
                comando.Parameters.AddWithValue("@idProducto", productoVendido.IdProducto);
                comando.Parameters.AddWithValue("@idVenta", productoVendido.IdVenta);
                comando.ExecuteNonQuery();
                comando.Connection.Close();

            }


        }


    }
}
