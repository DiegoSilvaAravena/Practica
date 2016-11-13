namespace System
{
    partial class Ventas
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBoxProducto = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonAñadir = new MetroFramework.Controls.MetroButton();
            this.metroLabelProducto = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCliente = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFactura = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPrecio = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelCantidad = new MetroFramework.Controls.MetroLabel();
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButtonLimpiar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.toolTipCliente = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrecio = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFactura = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBoxProducto
            // 
            this.metroComboBoxProducto.FormattingEnabled = true;
            this.metroComboBoxProducto.ItemHeight = 23;
            this.metroComboBoxProducto.Location = new System.Drawing.Point(92, 201);
            this.metroComboBoxProducto.Name = "metroComboBoxProducto";
            this.metroComboBoxProducto.Size = new System.Drawing.Size(131, 29);
            this.metroComboBoxProducto.TabIndex = 0;
            this.metroComboBoxProducto.UseSelectable = true;
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.CustomFormat = "";
            this.metroDateTimeFecha.Location = new System.Drawing.Point(92, 95);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(200, 29);
            this.metroDateTimeFecha.TabIndex = 1;
            // 
            // metroTextBoxFactura
            // 
            this.metroTextBoxFactura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFactura.Lines = new string[0];
            this.metroTextBoxFactura.Location = new System.Drawing.Point(92, 130);
            this.metroTextBoxFactura.MaxLength = 32767;
            this.metroTextBoxFactura.Name = "metroTextBoxFactura";
            this.metroTextBoxFactura.PasswordChar = '\0';
            this.metroTextBoxFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFactura.SelectedText = "";
            this.metroTextBoxFactura.Size = new System.Drawing.Size(200, 29);
            this.metroTextBoxFactura.TabIndex = 2;
            this.metroTextBoxFactura.UseCustomBackColor = true;
            this.metroTextBoxFactura.UseSelectable = true;
            this.metroTextBoxFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxFactura_KeyPress);
            // 
            // metroTextBoxPrecio
            // 
            this.metroTextBoxPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPrecio.Lines = new string[0];
            this.metroTextBoxPrecio.Location = new System.Drawing.Point(92, 166);
            this.metroTextBoxPrecio.MaxLength = 32767;
            this.metroTextBoxPrecio.Name = "metroTextBoxPrecio";
            this.metroTextBoxPrecio.PasswordChar = '\0';
            this.metroTextBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrecio.SelectedText = "";
            this.metroTextBoxPrecio.Size = new System.Drawing.Size(200, 29);
            this.metroTextBoxPrecio.TabIndex = 3;
            this.metroTextBoxPrecio.UseCustomBackColor = true;
            this.metroTextBoxPrecio.UseSelectable = true;
            this.metroTextBoxPrecio.Click += new System.EventHandler(this.metroTextBoxPrecio_Click);
            this.metroTextBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxVenta_KeyPress);
            // 
            // metroComboBoxCliente
            // 
            this.metroComboBoxCliente.FormattingEnabled = true;
            this.metroComboBoxCliente.ItemHeight = 23;
            this.metroComboBoxCliente.Location = new System.Drawing.Point(92, 60);
            this.metroComboBoxCliente.Name = "metroComboBoxCliente";
            this.metroComboBoxCliente.Size = new System.Drawing.Size(200, 29);
            this.metroComboBoxCliente.TabIndex = 4;
            this.metroComboBoxCliente.UseSelectable = true;
            this.metroComboBoxCliente.Click += new System.EventHandler(this.metroComboBoxCliente_Click);
            // 
            // metroButtonAñadir
            // 
            this.metroButtonAñadir.AutoSize = true;
            this.metroButtonAñadir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAñadir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonAñadir.Location = new System.Drawing.Point(350, 201);
            this.metroButtonAñadir.Name = "metroButtonAñadir";
            this.metroButtonAñadir.Size = new System.Drawing.Size(47, 29);
            this.metroButtonAñadir.TabIndex = 6;
            this.metroButtonAñadir.Text = "+";
            this.metroButtonAñadir.UseSelectable = true;
            this.metroButtonAñadir.Click += new System.EventHandler(this.metroButtonAñadir_Click);
            // 
            // metroLabelProducto
            // 
            this.metroLabelProducto.Location = new System.Drawing.Point(23, 201);
            this.metroLabelProducto.Name = "metroLabelProducto";
            this.metroLabelProducto.Size = new System.Drawing.Size(63, 29);
            this.metroLabelProducto.TabIndex = 7;
            this.metroLabelProducto.Text = "Producto";
            this.metroLabelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelCliente
            // 
            this.metroLabelCliente.Location = new System.Drawing.Point(23, 60);
            this.metroLabelCliente.Name = "metroLabelCliente";
            this.metroLabelCliente.Size = new System.Drawing.Size(63, 29);
            this.metroLabelCliente.TabIndex = 8;
            this.metroLabelCliente.Text = "Cliente";
            this.metroLabelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelFecha
            // 
            this.metroLabelFecha.Location = new System.Drawing.Point(23, 95);
            this.metroLabelFecha.Name = "metroLabelFecha";
            this.metroLabelFecha.Size = new System.Drawing.Size(63, 29);
            this.metroLabelFecha.TabIndex = 9;
            this.metroLabelFecha.Text = "Fecha";
            this.metroLabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelFactura
            // 
            this.metroLabelFactura.Location = new System.Drawing.Point(23, 130);
            this.metroLabelFactura.Name = "metroLabelFactura";
            this.metroLabelFactura.Size = new System.Drawing.Size(63, 29);
            this.metroLabelFactura.TabIndex = 10;
            this.metroLabelFactura.Text = "Factura";
            this.metroLabelFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelPrecio
            // 
            this.metroLabelPrecio.Location = new System.Drawing.Point(23, 166);
            this.metroLabelPrecio.Name = "metroLabelPrecio";
            this.metroLabelPrecio.Size = new System.Drawing.Size(63, 29);
            this.metroLabelPrecio.TabIndex = 11;
            this.metroLabelPrecio.Text = "Precio";
            this.metroLabelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxCantidad
            // 
            this.metroTextBoxCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCantidad.Lines = new string[0];
            this.metroTextBoxCantidad.Location = new System.Drawing.Point(297, 201);
            this.metroTextBoxCantidad.MaxLength = 32767;
            this.metroTextBoxCantidad.Name = "metroTextBoxCantidad";
            this.metroTextBoxCantidad.PasswordChar = '\0';
            this.metroTextBoxCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCantidad.SelectedText = "";
            this.metroTextBoxCantidad.Size = new System.Drawing.Size(47, 29);
            this.metroTextBoxCantidad.TabIndex = 12;
            this.metroTextBoxCantidad.UseCustomBackColor = true;
            this.metroTextBoxCantidad.UseSelectable = true;
            // 
            // metroLabelCantidad
            // 
            this.metroLabelCantidad.Location = new System.Drawing.Point(229, 201);
            this.metroLabelCantidad.Name = "metroLabelCantidad";
            this.metroLabelCantidad.Size = new System.Drawing.Size(63, 29);
            this.metroLabelCantidad.TabIndex = 13;
            this.metroLabelCantidad.Text = "Cantidad";
            this.metroLabelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroGridProductos
            // 
            this.metroGridProductos.AllowUserToAddRows = false;
            this.metroGridProductos.AllowUserToDeleteRows = false;
            this.metroGridProductos.AllowUserToResizeRows = false;
            this.metroGridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Cantidad});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(23, 236);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.ReadOnly = true;
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(496, 150);
            this.metroGridProductos.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // metroButtonLimpiar
            // 
            this.metroButtonLimpiar.AutoSize = true;
            this.metroButtonLimpiar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLimpiar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonLimpiar.Location = new System.Drawing.Point(403, 201);
            this.metroButtonLimpiar.Name = "metroButtonLimpiar";
            this.metroButtonLimpiar.Size = new System.Drawing.Size(47, 29);
            this.metroButtonLimpiar.TabIndex = 15;
            this.metroButtonLimpiar.Text = "-";
            this.metroButtonLimpiar.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(375, 392);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "Terminar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // toolTipCliente
            // 
            this.toolTipCliente.BackColor = System.Drawing.Color.White;
            // 
            // toolTipPrecio
            // 
            this.toolTipPrecio.BackColor = System.Drawing.Color.White;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButtonLimpiar);
            this.Controls.Add(this.metroGridProductos);
            this.Controls.Add(this.metroLabelCantidad);
            this.Controls.Add(this.metroTextBoxCantidad);
            this.Controls.Add(this.metroLabelPrecio);
            this.Controls.Add(this.metroLabelFactura);
            this.Controls.Add(this.metroLabelFecha);
            this.Controls.Add(this.metroLabelCliente);
            this.Controls.Add(this.metroLabelProducto);
            this.Controls.Add(this.metroButtonAñadir);
            this.Controls.Add(this.metroComboBoxCliente);
            this.Controls.Add(this.metroTextBoxPrecio);
            this.Controls.Add(this.metroTextBoxFactura);
            this.Controls.Add(this.metroDateTimeFecha);
            this.Controls.Add(this.metroComboBoxProducto);
            this.Name = "Ventas";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.Flat;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxProducto;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFactura;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrecio;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCliente;
        private MetroFramework.Controls.MetroButton metroButtonAñadir;
        private MetroFramework.Controls.MetroLabel metroLabelProducto;
        private MetroFramework.Controls.MetroLabel metroLabelCliente;
        private MetroFramework.Controls.MetroLabel metroLabelFecha;
        private MetroFramework.Controls.MetroLabel metroLabelFactura;
        private MetroFramework.Controls.MetroLabel metroLabelPrecio;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCantidad;
        private MetroFramework.Controls.MetroLabel metroLabelCantidad;
        private MetroFramework.Controls.MetroGrid metroGridProductos;
        private MetroFramework.Controls.MetroButton metroButtonLimpiar;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Windows.Forms.ToolTip toolTipCliente;
        private Windows.Forms.ToolTip toolTipPrecio;
        private Windows.Forms.ToolTip toolTipFactura;
    }
}