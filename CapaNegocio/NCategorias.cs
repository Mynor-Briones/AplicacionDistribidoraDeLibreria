using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCategorias
    {
       public static DataTable ListaCategorias()
        {
            return new DCategoria().ListaCategorias();
        }

       public static DataTable Mostrar(int parRegistrosPorPagina, int parNumeroPagina)
        {
            return new DCategoria().Mostrar(parRegistrosPorPagina, parNumeroPagina );
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DCategoria().Tamaño(parRegistrosPorPagina);
        }

        
        public static DataTable Buscar(String parNombre_Buscado)
        {
            DCategoria categorias = new DCategoria();
            categorias.Nombre_Buscado = parNombre_Buscado;

            return categorias.Buscar(categorias);
        }
        
        public static String Eliminar(int parId_Categoria)
        {
            DCategoria categorias = new DCategoria();
            categorias.Id_Categoria = parId_Categoria;

            return categorias.Eliminar(categorias);
        }

        public static String Insertar(String parNombre_Categoria, String parDescripcion)
        {
            DCategoria categorias = new DCategoria();
            categorias.Nombre_Categoria = parNombre_Categoria;
            categorias.Descripcion = parDescripcion;

            return categorias.Insertar(categorias);
        }

        public static String Editar(int parId_Categoria, String parNombre_Categoria, String parDescripcion)
        {
            DCategoria categorias = new DCategoria();
            categorias.Id_Categoria = parId_Categoria;
            categorias.Nombre_Categoria = parNombre_Categoria;
            categorias.Descripcion = parDescripcion;

            return categorias.Editar(categorias);
        }
        
    }
}
