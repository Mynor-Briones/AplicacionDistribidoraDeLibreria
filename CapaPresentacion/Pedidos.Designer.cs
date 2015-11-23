namespace CapaPresentacion
{
    partial class Pedidos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelManipulacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonMarcarEntregado = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBuscarCodigo = new System.Windows.Forms.Label();
            this.textboxNombreBuscar = new System.Windows.Forms.TextBox();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPaginacionAtras = new System.Windows.Forms.Button();
            this.labelPaginacion = new System.Windows.Forms.Label();
            this.buttonPaginacionSiguiente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePendiente = new System.Windows.Forms.TabPage();
            this.tabPageEntregado = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelManipulacion.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelPaginacion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanelPrincipal.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 3;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(1232, 633);
            this.tableLayoutPanelPrincipal.TabIndex = 1;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelManipulacion, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBuscar, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1226, 94);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // tableLayoutPanelManipulacion
            // 
            this.tableLayoutPanelManipulacion.ColumnCount = 4;
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30362F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.18384F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.51254F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEliminar, 3, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEditar, 2, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonAgregar, 1, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonMarcarEntregado, 0, 0);
            this.tableLayoutPanelManipulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelManipulacion.Location = new System.Drawing.Point(776, 3);
            this.tableLayoutPanelManipulacion.Name = "tableLayoutPanelManipulacion";
            this.tableLayoutPanelManipulacion.RowCount = 1;
            this.tableLayoutPanelManipulacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelManipulacion.Size = new System.Drawing.Size(447, 88);
            this.tableLayoutPanelManipulacion.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Orange;
            this.buttonEliminar.Image = global::CapaPresentacion.Properties.Resources.remove_delete_file;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(359, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(85, 82);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.Orange;
            this.buttonEditar.Image = global::CapaPresentacion.Properties.Resources.file_edit;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(272, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(81, 82);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.Orange;
            this.buttonAgregar.Image = global::CapaPresentacion.Properties.Resources.file_add;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregar.Location = new System.Drawing.Point(179, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(87, 82);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonMarcarEntregado
            // 
            this.buttonMarcarEntregado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcarEntregado.Location = new System.Drawing.Point(3, 3);
            this.buttonMarcarEntregado.Name = "buttonMarcarEntregado";
            this.buttonMarcarEntregado.Size = new System.Drawing.Size(170, 82);
            this.buttonMarcarEntregado.TabIndex = 3;
            this.buttonMarcarEntregado.Text = "Marcar Pedido Entregado/Pendiente";
            this.buttonMarcarEntregado.UseVisualStyleBackColor = true;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxBuscar.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxBuscar.Location = new System.Drawing.Point(515, 0);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(254, 94);
            this.groupBoxBuscar.TabIndex = 2;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Productos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06806F));
            this.tableLayoutPanel1.Controls.Add(this.labelBuscarCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textboxNombreBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefrescar, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 64);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelBuscarCodigo
            // 
            this.labelBuscarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuscarCodigo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarCodigo.Location = new System.Drawing.Point(0, 0);
            this.labelBuscarCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.labelBuscarCodigo.Name = "labelBuscarCodigo";
            this.labelBuscarCodigo.Size = new System.Drawing.Size(97, 32);
            this.labelBuscarCodigo.TabIndex = 0;
            this.labelBuscarCodigo.Text = "Nombre:";
            this.labelBuscarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxNombreBuscar
            // 
            this.textboxNombreBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxNombreBuscar.Location = new System.Drawing.Point(97, 0);
            this.textboxNombreBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textboxNombreBuscar.Name = "textboxNombreBuscar";
            this.textboxNombreBuscar.Size = new System.Drawing.Size(129, 26);
            this.textboxNombreBuscar.TabIndex = 1;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefrescar.BackColor = System.Drawing.Color.Gray;
            this.buttonRefrescar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.ForeColor = System.Drawing.Color.Orange;
            this.buttonRefrescar.Location = new System.Drawing.Point(97, 32);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(129, 32);
            this.buttonRefrescar.TabIndex = 2;
            this.buttonRefrescar.Text = "Actualizar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitulo.Location = new System.Drawing.Point(0, 17);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(210, 59);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "PEDIDOS";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02522F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97478F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelPaginacion, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 565);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1223, 65);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanelPaginacion
            // 
            this.tableLayoutPanelPaginacion.ColumnCount = 4;
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonPaginacionAtras, 1, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.labelPaginacion, 0, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonPaginacionSiguiente, 3, 0);
            this.tableLayoutPanelPaginacion.Location = new System.Drawing.Point(749, 3);
            this.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion";
            this.tableLayoutPanelPaginacion.RowCount = 1;
            this.tableLayoutPanelPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.Size = new System.Drawing.Size(471, 56);
            this.tableLayoutPanelPaginacion.TabIndex = 5;
            // 
            // buttonPaginacionAtras
            // 
            this.buttonPaginacionAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginacionAtras.BackColor = System.Drawing.Color.Gray;
            this.buttonPaginacionAtras.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginacionAtras.ForeColor = System.Drawing.Color.Orange;
            this.buttonPaginacionAtras.Location = new System.Drawing.Point(178, 0);
            this.buttonPaginacionAtras.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginacionAtras.Name = "buttonPaginacionAtras";
            this.buttonPaginacionAtras.Size = new System.Drawing.Size(129, 56);
            this.buttonPaginacionAtras.TabIndex = 6;
            this.buttonPaginacionAtras.Text = "<< Atrás  ";
            this.buttonPaginacionAtras.UseVisualStyleBackColor = false;
            // 
            // labelPaginacion
            // 
            this.labelPaginacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaginacion.AutoSize = true;
            this.labelPaginacion.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginacion.Location = new System.Drawing.Point(57, 16);
            this.labelPaginacion.Name = "labelPaginacion";
            this.labelPaginacion.Size = new System.Drawing.Size(118, 23);
            this.labelPaginacion.TabIndex = 5;
            this.labelPaginacion.Text = "Página X de X";
            // 
            // buttonPaginacionSiguiente
            // 
            this.buttonPaginacionSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginacionSiguiente.BackColor = System.Drawing.Color.Gray;
            this.buttonPaginacionSiguiente.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginacionSiguiente.ForeColor = System.Drawing.Color.Orange;
            this.buttonPaginacionSiguiente.Location = new System.Drawing.Point(347, 0);
            this.buttonPaginacionSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginacionSiguiente.Name = "buttonPaginacionSiguiente";
            this.buttonPaginacionSiguiente.Size = new System.Drawing.Size(124, 56);
            this.buttonPaginacionSiguiente.TabIndex = 7;
            this.buttonPaginacionSiguiente.Text = "Siguiente>>";
            this.buttonPaginacionSiguiente.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePendiente);
            this.tabControl1.Controls.Add(this.tabPageEntregado);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1226, 456);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPagePendiente
            // 
            this.tabPagePendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePendiente.Location = new System.Drawing.Point(4, 22);
            this.tabPagePendiente.Name = "tabPagePendiente";
            this.tabPagePendiente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePendiente.Size = new System.Drawing.Size(1218, 430);
            this.tabPagePendiente.TabIndex = 0;
            this.tabPagePendiente.Text = "PENDIENTE";
            this.tabPagePendiente.UseVisualStyleBackColor = true;
            // 
            // tabPageEntregado
            // 
            this.tabPageEntregado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageEntregado.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntregado.Name = "tabPageEntregado";
            this.tabPageEntregado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntregado.Size = new System.Drawing.Size(1218, 430);
            this.tabPageEntregado.TabIndex = 1;
            this.tabPageEntregado.Text = "ENTREGADO";
            this.tabPageEntregado.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Name = "Pedidos";
            this.Size = new System.Drawing.Size(1235, 639);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tableLayoutPanelManipulacion.ResumeLayout(false);
            this.groupBoxBuscar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelPaginacion.ResumeLayout(false);
            this.tableLayoutPanelPaginacion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelManipulacion;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBuscarCodigo;
        private System.Windows.Forms.TextBox textboxNombreBuscar;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaginacion;
        private System.Windows.Forms.Button buttonPaginacionAtras;
        private System.Windows.Forms.Label labelPaginacion;
        private System.Windows.Forms.Button buttonPaginacionSiguiente;
        private System.Windows.Forms.Button buttonMarcarEntregado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePendiente;
        private System.Windows.Forms.TabPage tabPageEntregado;
    }
}
