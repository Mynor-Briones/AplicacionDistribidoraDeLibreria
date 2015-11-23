namespace CapaPresentacion
{
    partial class Transporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelManipulacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelManipulacion.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanelPrincipal.Controls.Add(this.dataGridViewProductos, 0, 1);
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 3;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(1229, 633);
            this.tableLayoutPanelPrincipal.TabIndex = 3;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanelManipulacion, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBuscar, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1223, 91);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // tableLayoutPanelManipulacion
            // 
            this.tableLayoutPanelManipulacion.ColumnCount = 3;
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonAgregar, 0, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEditar, 1, 0);
            this.tableLayoutPanelManipulacion.Controls.Add(this.buttonEliminar, 2, 0);
            this.tableLayoutPanelManipulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelManipulacion.Location = new System.Drawing.Point(966, 3);
            this.tableLayoutPanelManipulacion.Name = "tableLayoutPanelManipulacion";
            this.tableLayoutPanelManipulacion.RowCount = 1;
            this.tableLayoutPanelManipulacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelManipulacion.Size = new System.Drawing.Size(254, 85);
            this.tableLayoutPanelManipulacion.TabIndex = 0;
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
            this.buttonAgregar.Location = new System.Drawing.Point(3, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(78, 79);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
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
            this.buttonEditar.Location = new System.Drawing.Point(87, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(78, 79);
            this.buttonEditar.TabIndex = 0;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
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
            this.buttonEliminar.Location = new System.Drawing.Point(171, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(80, 79);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscar.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxBuscar.Location = new System.Drawing.Point(725, 0);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(238, 91);
            this.groupBoxBuscar.TabIndex = 2;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Transporte";
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
            this.labelTitulo.Location = new System.Drawing.Point(0, 16);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(305, 59);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "TRANSPORTE";
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
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.Location = new System.Drawing.Point(6, 100);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowTemplate.Height = 25;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1217, 459);
            this.dataGridViewProductos.TabIndex = 8;
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Name = "Transporte";
            this.Size = new System.Drawing.Size(1229, 633);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelManipulacion;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
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
        private System.Windows.Forms.DataGridView dataGridViewProductos;
    }
}
