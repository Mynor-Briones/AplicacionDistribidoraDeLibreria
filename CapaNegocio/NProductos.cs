using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProductos
    {
        public static DataTable Mostrar(int parRegistrosPorPagina, int parNumeroPagina)
        {
            return new DProductos().Mostrar(parRegistrosPorPagina, parNumeroPagina);
        }
        //****************************************************************
         public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DProductos().Tamaño(parRegistrosPorPagina);
        }
        //****************************************************************
         public static DataTable Buscar(String ParNombreBuscado)
         {
             DProductos Producto = new DProductos();
             Producto.Nombre_Buscado = ParNombreBuscado;

             return Producto.Buscar (Producto);  
         }
        //******************************************************************//
         //metodo editar qe llaa al etodo editar de la calse DProducto de la capaDatos
         public static String Insertar(String parNombre_Producto, String parNombre_Categoria,
            decimal parPrecio_Unitario, String parDetalles)
         {
             DProductos productos = new DProductos();
             productos.Nombre_Producto = parNombre_Producto;
             productos.Nombre_Categoria = parNombre_Categoria;
             productos.Precio_Unitario = parPrecio_Unitario;
             productos.Detalles = parDetalles;

             return productos.Insertar(productos);
         }
    }

}
