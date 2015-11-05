using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormAgregarNewProducto : Form
    {
        Productos _owner;
        public FormAgregarNewProducto()
        {
            InitializeComponent();
        }

        public FormAgregarNewProducto (Productos owner)
        {
            _owner = owner;
            InitializeComponent();

            try
            {
                CargarCategoria();
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }
        private void CargarCategoria()
        {
            this.comboBoxCategoria.DataSource = NCategorias.ListaCategorias();
            this.comboBoxCategoria.ValueMember = "ID";
            this.comboBoxCategoria.DisplayMember = "NOMBRE";
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
