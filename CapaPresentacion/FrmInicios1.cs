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
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmInicios1 : Form
    {
        Pedidos ControlPedidos;
        Productos controlproductos;
        Categorias controlCategorias;
        Clientes controlClientes;
        Transporte controlTransporte;
        Empleados controlEmpleados;
       
        public FrmInicios1()
        {
            String mensaje = NConexion.ChequearConexion();
            if (mensaje == "Y")
            {
                InitializeComponent();
                Iniciar();
            }
            else
            {
                MessageBox.Show("El Sistema de Gestión no se puede iniciar ya que existió un error al conectarse con la Base de Datos. " + mensaje,
                  "Error al iniciar el Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }
            //InitializeComponent();
            //controlproductos = new Productos();
            //controlCategorias = new Categorias();
            //controlClientes = new Clientes();
            //controlTransporte = new Transporte();
            //controlEmpleados = new Empleados();
            //ControlPedidos = new Pedidos(); 
        public void Iniciar()
        {
            ControlPedidos = new Pedidos();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(ControlPedidos);
        }

          private void buttonPedido_Click(object sender, EventArgs e)
        {
            if (ControlPedidos == null)
            {
                ControlPedidos = new Pedidos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(ControlPedidos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(ControlPedidos);
            }
        } 

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            if (controlproductos == null)
            {
                controlproductos = new Productos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlproductos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlproductos);
            }
            //******************************************************
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlproductos);

            //*******************************************
            /* esto fncona pero el problea es qe conse deaciada eoria RA ya qe a cada oento
             se le esta haciendo n llado a la isa ventana*/
            //Productos controlproductos = new Productos();
            //this.panelContenedor.Controls.Add(controlproductos);
            //*******************************************
        }
        private void buttonCategoria_Click_1(object sender, EventArgs e)
        {
            if (controlCategorias == null)
            {
                controlCategorias = new Categorias();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlCategorias);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlCategorias);
            }
           // this.panelContenedor.Controls.Clear();
           //this.panelContenedor.Controls.Add(controlCategorias);
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            if (controlClientes == null)
            {
                controlClientes = new Clientes();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlClientes);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlClientes);
            }
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlClientes);
        }

        private void buttonTransporte_Click(object sender, EventArgs e)
        {
            if (controlTransporte == null)
            {
                controlTransporte = new Transporte();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlTransporte);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlTransporte);
            }
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlTransporte);  
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            if (controlEmpleados == null)
            {
                controlEmpleados = new Empleados();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlEmpleados);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(controlEmpleados);
            }
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlEmpleados);  
        }

      


    }
}
