using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Productos : UserControl
    {
        int registroporpagina = 17;
        int numeropagina = 1;
        int cantidadpaginas;
        public Productos()
        {
           InitializeComponent();
            this.Dock = DockStyle.Fill;
            Mostrar(); 
        }
       public void Mostrar()
        {
            this.dataGridViewProductos.DataSource = NProductos.Mostrar(registroporpagina, numeropagina);
            cantidadpaginas = NProductos.Tamaño(registroporpagina);
            this.labelPaginacion.Text = String.Format("pagina {0} de {1}", numeropagina, cantidadpaginas);
        }
//********************************************************************//
       public void Buscar()
       {
           try
           {
               this.dataGridViewProductos.DataSource = NProductos.Buscar
                   (this.textboxNombreBuscar.Text);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

        public void Refrescar ()
       {
           this.numeropagina = 1;
           this.Mostrar();
           this.textboxNombreBuscar.Text = String.Empty;

       }
        // viene del FrmAgregarProducto linea 73
        public void Mensaje(String mensaje)
        {
            this.labelMensajes.Text = mensaje;
        }
//********************************************************************//
        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (numeropagina > 1)
            {
                numeropagina = numeropagina - 1;
                Mostrar();
            }
        }

        private void buttonPaginacionSiguiente_Click(object sender, EventArgs e)
        {
            if (numeropagina < cantidadpaginas)
            {
                numeropagina = numeropagina + 1;
                Mostrar();
            }

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarNewProducto nuevoproducto = new FormAgregarNewProducto();
            nuevoproducto.ShowDialog();
        }

        private void textboxNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.textboxNombreBuscar.Text==String.Empty)
            {
                this.numeropagina = 1;
                this.Mostrar();
                this.tableLayoutPanelPaginacion.Show();
            }
            else
            {
                this.Buscar();
                this.tableLayoutPanelPaginacion.Hide();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

    }
}
