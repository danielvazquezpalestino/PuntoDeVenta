using Entidades;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasesDeDatos
{
    public class ProductoDataSource
    {
        public void GuardarProducto(Producto producto)
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into Producto(Nombre, Descripcion, Precio, Imagen , ProveedorID , CategoriaID )  " +
                $"values ('{producto.Nombre}','{producto.Descripcion}','{producto.Precio}','{producto.Imagen}' ,'{producto.ProveedorID}'  ,'{producto.CategoriaID}')";
            cmd.ExecuteNonQuery();

        }

        public List<Producto> ConsultarProducto()
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from producto;";
            IDataReader reader = cmd.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                productos.Add(new Producto()
                {
                    Nombre = reader["Nom_Producto"].ToString(),
                    CategoriaID = Convert.ToInt32(reader["FK_Categoria"]),
                    Descripcion = Convert.ToString(reader["Descripcion"]),
                    ID = Convert.ToInt32(reader["ID"]),
                    Imagen = Convert.ToString(reader["Imagen"]),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    ProveedorID = Convert.ToInt32(reader["FK_Proveedor"])
                });
            }

            return productos;
        }

        public List<Inventario> ConsultarProductoInformacion()
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmd.CommandText = "SELECT P.ID, P.Nom_Producto, P.Descripcion, P.Precio, PR.Nombre AS NombreProveedor, C.Nom_Cat AS NombreCategoria, P.cantidad AS cantidad, (P.cantidad * P.precio) AS TOTAL " +
                  "FROM dbo.Producto AS P " +
                  "INNER JOIN dbo.Proveedor AS PR ON P.FK_Proveedor = PR.ID " +
                  "INNER JOIN dbo.Categoria_Producto AS C ON P.FK_Categoria = C.ID " +
                  "INNER JOIN dbo.Orden_Compra AS oc ON oc.FK_Producto = P.ID ";


            IDataReader reader = cmd.ExecuteReader();
            List<Inventario> inventarios = new List<Inventario>();

            while (reader.Read())
            {
                inventarios.Add(new Inventario(reader)
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nombre = reader["Nom_Producto"].ToString(),
                    Descripcion = Convert.ToString(reader["Descripcion"]),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    NombreProveedor = reader["NombreProveedor"].ToString(),
                    NombreCategoria = reader["NombreCategoria"].ToString(),
                    Cantidad = Convert.ToInt32(reader["cantidad"]),
                    Total = Convert.ToDecimal(reader["TOTAL"])
                });
            }

            reader.Close(); // Cerrar el reader después de usarlo
            sqlConnection.Close(); // Cerrar la conexión después de usarla

            return inventarios;
        }

        public List<Inventario> ConsultarProductoInformacion(string nombre)
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmd.CommandText = "SELECT P.ID, P.Nom_Producto, P.Descripcion, P.Precio, PR.Nombre AS NombreProveedor, C.Nom_Cat AS NombreCategoria, P.cantidad AS cantidad, (P.cantidad * P.precio) AS TOTAL " +
                  "FROM dbo.Producto AS P " +
                  "INNER JOIN dbo.Proveedor AS PR ON P.FK_Proveedor = PR.ID " +
                  "INNER JOIN dbo.Categoria_Producto AS C ON P.FK_Categoria = C.ID  where P.Nom_Producto LIKE '%' + @nombre + '%'";
            cmd.Parameters.AddWithValue("@nombre", nombre);


            IDataReader reader = cmd.ExecuteReader();
            List<Inventario> inventarios = new List<Inventario>();

            while (reader.Read())
            {
                inventarios.Add(new Inventario(reader)
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Nombre = reader["Nom_Producto"].ToString(),
                    Descripcion = Convert.ToString(reader["Descripcion"]),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    NombreProveedor = reader["NombreProveedor"].ToString(),
                    NombreCategoria = reader["NombreCategoria"].ToString(),
                    Cantidad = Convert.ToInt32(reader["cantidad"]),
                    Total = Convert.ToDecimal(reader["TOTAL"])
                });
            }

            reader.Close(); // Cerrar el reader después de usarlo
            sqlConnection.Close(); // Cerrar la conexión después de usarla

            return inventarios;
        }
            public List<Inventario> ConsultarProductocompleto()
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = cmd.CommandText = "SELECT P.ID, P.Nom_Producto, P.Descripcion, P.Precio, PR.Nombre AS NombreProveedor, C.Nom_Cat AS NombreCategoria, P.cantidad AS cantidad, (P.cantidad * P.precio) AS TOTAL " +
                      "FROM dbo.Producto AS P " +
                      "INNER JOIN dbo.Proveedor AS PR ON P.FK_Proveedor = PR.ID " +
                      "INNER JOIN dbo.Categoria_Producto AS C ON P.FK_Categoria = C.ID  ";


                IDataReader reader = cmd.ExecuteReader();
                List<Inventario> inventarios = new List<Inventario>();

                while (reader.Read())
                {
                    inventarios.Add(new Inventario(reader)
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nom_Producto"].ToString(),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        NombreProveedor = reader["NombreProveedor"].ToString(),
                        NombreCategoria = reader["NombreCategoria"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["TOTAL"])
                    });
                }

                reader.Close(); // Cerrar el reader después de usarlo
                sqlConnection.Close(); // Cerrar la conexión después de usarla

                return inventarios;
            }

        public void ActualizarProducto(Producto producto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion))
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                string query = "UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, " +
                               "Imagen = @Imagen, ProveedorID = @ProveedorID, CategoriaID = @CategoriaID WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
                    cmd.Parameters.AddWithValue("@ProveedorID", producto.ProveedorID);
                    cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                    cmd.Parameters.AddWithValue("@ID", producto.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Producto> ConsultarProductoFiltrada(string nombre)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion))
            {
                sqlConnection.Open();

                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    // Llamar a la función existente y pasar el parámetro
                    cmd.CommandText = "SELECT  * from Productos as P   where p.Nombre LIKE '%' + @nombreParcial + '%';";
                    cmd.Parameters.AddWithValue("@nombreParcial", nombre); // Asignar el valor de nombre a @nombreParcial

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto()
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = Convert.ToString(reader["Descripcion"]),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Imagen = Convert.ToString(reader["Imagen"]),
                                ProveedorID = Convert.ToInt32(reader["ProveedorID"]),
                                CategoriaID = Convert.ToInt32(reader["CategoriaID"])
                            });
                        }
                    }
                }
            }

            return productos;
        }

        public string advertencia()
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT P.Nom_Producto, P.cantidad " +
                              "FROM dbo.Producto AS P " +
                              "INNER JOIN dbo.Proveedor AS PR ON P.FK_Proveedor = PR.ID " +
                              "INNER JOIN dbo.Categoria_Producto AS C ON P.FK_Categoria = C.ID";

            IDataReader reader = cmd.ExecuteReader();
            List<string> productosBajos = new List<string>();

            while (reader.Read())
            {
                int cantidad = Convert.ToInt32(reader["cantidad"]);
                if (cantidad <= 5)
                {
                    string nombreProducto = reader["Nom_Producto"].ToString();
                    productosBajos.Add(nombreProducto);
                }
            }

            reader.Close(); // Cerrar el reader después de usarlo
            sqlConnection.Close(); // Cerrar la conexión después de usarla

            // Si encontramos productos con cantidad baja, devolvemos un string con los nombres
            if (productosBajos.Count > 0)
            {
                return "Advertencia: Productos con cantidad baja: " + string.Join(", ", productosBajos);
            }
            else
            {
                return "No hay productos con cantidad baja.";
            }

        }


        public void Guardarcarrito(OrdenCompra orden, int cantidad)
        {
            string fecha = orden.FechaCompra.ToString("yyyy-MM-dd");
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into Orden_Compra(Fecha_Compra,Total,FK_Producto, FK_Vendedor , FK_MetodoPago)" +
                $"values ('{fecha}','{orden.Total * cantidad}','{orden.ProductoID}','{orden.VendedorID}' ,'{orden.MetodoPagoID}')";
            cmd.ExecuteNonQuery();
        }

        public void ActualizarInventario(int id, int cantidad)
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.Producto SET cantidad = cantidad - {cantidad} WHERE ID = {id}";
            cmd.ExecuteNonQuery();
        }

        public List<OrdenCompra> ObtenerOrdenesCompra()
        {
            List<OrdenCompra> ordenesCompra = new List<OrdenCompra>();

            using (SqlConnection sqlConnection = new SqlConnection(Conexion.CadenaConexion))
            {
                sqlConnection.Open();

                string query = "SELECT ID, Fecha_Compra, Total, FK_Producto, FK_Vendedor, FK_MetodoPago FROM Orden_Compra";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordenesCompra.Add(new OrdenCompra
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                FechaCompra = Convert.ToDateTime(reader["Fecha_Compra"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                ProductoID = Convert.ToInt32(reader["FK_Producto"]),
                                VendedorID = Convert.ToInt32(reader["FK_Vendedor"]),
                                MetodoPagoID = Convert.ToInt32(reader["FK_MetodoPago"])
                            });
                        }
                    }
                }
            }

            return ordenesCompra;
        }

    }

}
