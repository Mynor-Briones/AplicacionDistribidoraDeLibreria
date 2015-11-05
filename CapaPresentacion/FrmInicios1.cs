using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicios1 : Form
    {
        Productos controlproductos;
        public FrmInicios1()
        {
            InitializeComponent();
            controlproductos = new Productos();
        }
        private void buttonProductos_Click(object sender, EventArgs e)
        {
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlproductos);
        }
    }
}
