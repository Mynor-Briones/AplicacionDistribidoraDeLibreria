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
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Categorias : UserControl
    {
       int registroporpagina = 17;
        int numeropagina = 1;
        int cantidadpaginas;

        //*******************************************************************************
        //*******************************************************************************
        public Categorias()
        {
            InitializeComponent();
            Mostrar();
        }
        //*******************************************************************************
        //*******************************************************************************
       public void Mostrar()
       {
        try
        {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCategorias.DataSource = NCategorias.Mostrar(registroporpagina, numeropagina);
                this.dataGridViewCategorias.Columns[0].Visible = false;
                cantidadpaginas = NCategorias.Tamaño(registroporpagina);
                this.labelPaginacion.Text = String.Format("Página {0} de {1}", numeropagina, cantidadpaginas);
                    
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }
       //*******************************************************************************
       //*******************************************************************************
//       public void Buscar()
//       {
//           try
//           {
//               this.dataGridViewCategorias.DataSource = NCategorias.Buscar(this.textboxNombreBuscar.Text);
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show(ex.Message);
//           }
//       }
//       //*******************************************************************************
//       //*******************************************************************************
       //public void Refrescar()
       //{
       //    this.numeropagina = 1;
       //    this.Mostrar();
       //    this.textboxNombreBuscar.Text = String.Empty;
       //}
        //*******************************************************************************
        //*******************************************************************************
        // viene del FrmAgregarProducto linea 92
       public void Mensaje(String mensaje)
       {
           //   this.labelMensajes.Text = mensaje;
       }
       // Por eso e daba error en el owner por qe esto era lo qe faltaba. todo el clavo estaba
       //en el ensae de error
       //if (mensaje == "Y")
       //            {
       //                this._owner.mensaje(String.Format("El Producto {0} ha sido AGREGADO", this.textBoxNombreProducto.Text));
       //                this._owner.Refrescar();
       //                this.Close();
       //            }
       // Eliinar prodctos
       public void LimpiarMensaje()
       {
           // this.labelMensajes.Text = String.Empty;
       }
       /******************************************************/
       private void MensajeError(string mensaje)
       {
           MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }

       //public DataGridViewRow ObtenerSeleccion()
       //{
       //    DataGridViewRow filaSeleccionada = this.dataGridViewCategorias.Rows[this.dataGridViewCategorias.CurrentRow.Index];
       //    return filaSeleccionada;
       //}
       //********************************************************************//
       //private void textboxNombreBuscar_TextChanged(object sender, EventArgs e)
       //{
       //    if (this.textboxNombreBuscar.Text == String.Empty)
       //    {
       //        this.numeropagina = 1;
       //        this.Mostrar();
       //        this.tableLayoutPanelPaginacion.Show();
       //    }
       //    else
       //    {
       //        this.Buscar();
       //        this.tableLayoutPanelPaginacion.Hide();
       //    }
       //}

       ////*******************************************************************************
       ////*******************************************************************************
       //private void buttonRefrescar_Click(object sender, EventArgs e)
       //{
       //    this.Refrescar();
       //    this.LimpiarMensaje();
       //}

       //*******************************************************************************
       //*******************************************************************************
       //private void buttonAgregar_Click(object sender, EventArgs e)
       //{
       //    FormAgregarNewProducto nuevoproducto = new FormAgregarNewProducto();
       //    nuevoproducto.ShowDialog();
       //}
       //*******************************************************************************
       //*******************************************************************************

       //private void buttonEditar_Click(object sender, EventArgs e)
       //{
       //    try
       //    {
       //        if (this.dataGridViewCategorias.Rows.Count > 0)
       //        {
       //            FrmEditarProducto editarProducto = new FrmEditarProducto(this);
       //            editarProducto.ShowDialog();
       //        }
       //        else
       //        {
       //            MensajeError("Debes seleccionar una fila para editar");
       //        }
       //    }
       //    catch (Exception ex)
       //    {
       //        MensajeError(ex.Message);
       //    }
       //}
       //*******************************************************************************
       //*******************************************************************************
       //private void buttonEliminar_Click(object sender, EventArgs e)
       //{
       //    try
       //    {
       //        if (this.dataGridViewCategorias.Rows.Count > 0)
       //        {
       //            DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar este producto?", "Eliminar Producto",
       //            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

       //            if (confirmacion == DialogResult.OK)
       //            {
       //                String mensaje = NProductos.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells["ID"].Value));
       //                if (mensaje == "Y")
       //                {
       //                    Mensaje(String.Format("El Producto {0} ha sido ELIMINADO",
       //                        Convert.ToString(ObtenerSeleccion().Cells["NOMBRE"].Value)));
       //                    Refrescar();
       //                }
       //                else
       //                {
       //                    MensajeError(mensaje);
       //                    Refrescar();
       //                }
       //            }
       //        }
       //        else
       //        {
       //            MensajeError("Debes seleccionar una fila para eliminar");
       //        }

       //    }
       //    catch (Exception ex)
       //    {
       //        MensajeError(ex.Message);
       //    }
       //}

       //*******************************************************************************
       //*******************************************************************************
       private void buttonPaginacionAtras_Click_1(object sender, EventArgs e)

       {
           if (numeropagina > 1)
           {
               numeropagina = numeropagina - 1;
               Mostrar();
           }
       }

       //*******************************************************************************
       //*******************************************************************************
       private void buttonPaginacionSiguiente_Click_1(object sender, EventArgs e)
       {
           if (numeropagina < cantidadpaginas)
           {
               numeropagina = numeropagina + 1;
               Mostrar();
           }

       }
       
    }

    }