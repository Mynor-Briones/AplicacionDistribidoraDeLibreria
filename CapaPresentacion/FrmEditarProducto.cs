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
    public partial class FrmEditarProducto : Form
    {
        Productos _owner;
        int Id_Producto;

        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        public FrmEditarProducto(Productos owner)
        {
            _owner = owner;
            InitializeComponent();

            CargarCategorias();
            this.Id_Producto = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombreProducto.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.comboBoxCategoria.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CATEGORIA"].Value);
            this.textBoxPrecioUnitario.Text = Convert.ToDecimal(_owner.ObtenerSeleccion().Cells["PRECIO"].Value).ToString("0.00##");
            this.textBoxDetalles.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["DETALLES DEL PRODUCTO"].Value);
        }

        public void CargarCategorias()
        {
            this.comboBoxCategoria.DataSource = NCategorias.ListaCategorias();
            this.comboBoxCategoria.ValueMember = "ID";
            this.comboBoxCategoria.DisplayMember = "NOMBRE";
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            try//Por si alguna conversion de datos falla
            {
                if (String.IsNullOrWhiteSpace(this.textBoxNombreProducto.Text) || String.IsNullOrWhiteSpace(this.comboBoxCategoria.Text))
                {
                    MensajeError("Los campos Nombre de Producto y Categoría son obligatorios");
                }

                else
                {
                    if (String.IsNullOrWhiteSpace(this.textBoxPrecioUnitario.Text))
                    {
                        this.textBoxPrecioUnitario.Text = "0";
                    }

                    String mensaje = NProductos.Editar(this.Id_Producto, this.textBoxNombreProducto.Text,
                    this.comboBoxCategoria.Text, Convert.ToDecimal(Convert.ToString(this.textBoxPrecioUnitario.Text)),
                    this.textBoxDetalles.Text);

                    if (mensaje == "Y")
                    {
                        this._owner.Mensaje(String.Format("El Producto {0} ha sido EDITADO", this.textBoxNombreProducto.Text));
                        this._owner.Refrescar();
                        this.Close();
                    }
                    else
                    {
                        MensajeError(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("Los valores ingresados son incorrectos. " + ex.Message);
            }
        }

        private void textBoxPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxUnidadesStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

       
        
    }
}
