using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class DProductos
    {
        /*Propiedades de DProductos son las colnas qe teneos en la BD procediiento de alacenado 
        metodos accesores  */
        public int Id_Producto { get; set; }
        public String Nombre_Producto { get; set; }
        public String Nombre_Categoria { get; set; }
        public decimal Precio_Unitario { get; set; }
        public String Detalles { get; set; } 
        public String Nombre_Buscado { get; set; }
        
        
        /* VIDEO 13  9:09  Constructor,  */
          public DProductos()
          {

          }
          /*Este es otro constructor que va a setear y tomar todas las propiedades que tenemos en las propiedades 
           VAOS A pasarle paraetros qe van a toar el valor o cabiar el valor de las propiedades  qe tenos en la clase  Dprodcto */
          public DProductos(int parId_Producto, String parNombre_Producto, String parNombre_Categoria,
              decimal parPrecio_Unitario, String parDetalles, String parNombre_Buscado)  
              /* bscar esto String parNombre_Buscado no lo tengo en el caderno apntado, sin tener esto la
               aplicacion e fnciona bien la bsqeda */
          {
              /*priero le envia al metodo SEt y le enviaos el praraetro  al parId_Producto qe estaos recibiendo  */
              this.Id_Producto = parId_Producto;
              this.Nombre_Producto = parNombre_Producto;
              this.Nombre_Categoria = parNombre_Categoria;
              this.Precio_Unitario = parPrecio_Unitario;
              this.Detalles = parDetalles;
              /* bscar esto String parNombre_Buscado no lo tengo en el caderno apntado */
              this.Nombre_Buscado = parNombre_Buscado;
        
          } 
        public DataTable Mostrar(int parRegistrosPorPagina, int parNumeroPagina)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.cnDBEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosMostrar";
                SqlComando.CommandType = CommandType.StoredProcedure;


                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParNumeroPagina = new SqlParameter();
                ParNumeroPagina.ParameterName = "@NumeroPagina";
                ParNumeroPagina.SqlDbType = SqlDbType.Int;
                ParNumeroPagina.Value = parNumeroPagina;
                SqlComando.Parameters.Add(ParNumeroPagina);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ProductosMostrar. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        //*****************************************************//
        public int Tamaño(int parRegistrosPorPagina)
        {
            int totalPaginas = 1;
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.cnDBEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosTamaño";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                ParTotalPaginas.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoProductos. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        //*****************************************************//
        public DataTable Buscar(DProductos parProducto)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.cnDBEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductoBuscar";
                SqlComando.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombreBuscado = new SqlParameter();
                ParNombreBuscado.ParameterName = "@NombreBuscado"; 
                ParNombreBuscado.SqlDbType = SqlDbType.VarChar;
                ParNombreBuscado.Size = parProducto.Nombre_Buscado.Length;
                ParNombreBuscado.Value = parProducto .Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombreBuscado);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ProductoBuscar. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos; 
        } 

        /*************************************************************************************/
        /*************************************************************************************/
        public string Insertar(DProductos parProductos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.cnDBEmpresa;  
                SqlConexion.Open(); 

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosInsertar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parProductos.Nombre_Producto.Length;
                ParNombre_Producto.Value = parProductos.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParNombre_Categoria = new SqlParameter();
                ParNombre_Categoria.ParameterName = "@Nombre_Categoria";
                ParNombre_Categoria.SqlDbType = SqlDbType.VarChar;
                ParNombre_Categoria.Size = parProductos.Nombre_Categoria.Length;
                ParNombre_Categoria.Value = parProductos.Nombre_Categoria;
                SqlComando.Parameters.Add(ParNombre_Categoria);

                SqlParameter ParPrecio_Unitario = new SqlParameter();
                ParPrecio_Unitario.ParameterName = "@Precio_Unitario";
                ParPrecio_Unitario.SqlDbType = SqlDbType.Money;
                ParPrecio_Unitario.Value = parProductos.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecio_Unitario);

                SqlParameter ParDetalles = new SqlParameter();
                ParDetalles.ParameterName = "@Detalles";
                ParDetalles.SqlDbType = SqlDbType.VarChar;
                ParDetalles.Size = parProductos.Detalles.Length;
                ParDetalles.Value = parProductos.Detalles;
                SqlComando.Parameters.Add(ParDetalles);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un producto con ese Nombre, Ingrese otro nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Nombre y Categoría vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar el nombre de una Categoría existente. Para ingresar una nueva Categoría, primero debes crearla.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarProducto. " + ex.Message;
                }
            }
            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }
    }

}

