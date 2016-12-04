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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroLabelCliente = new MetroFramework.Controls.MetroLabel();
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBoxFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelProducto = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxProducto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelFactura = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPrecio = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.Location = new System.Drawing.Point(110, 95);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(302, 29);
            this.metroDateTimeFecha.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.metroDateTimeFecha, "Seleccione la fecha");
            // 
            // metroTextBoxCantidad
            // 
            // 
            // 
            // 
            this.metroTextBoxCantidad.CustomButton.Image = null;
            this.metroTextBoxCantidad.CustomButton.Location = new System.Drawing.Point(20, 1);
            this.metroTextBoxCantidad.CustomButton.Name = "";
            this.metroTextBoxCantidad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCantidad.CustomButton.TabIndex = 1;
            this.metroTextBoxCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCantidad.CustomButton.UseSelectable = true;
            this.metroTextBoxCantidad.CustomButton.Visible = false;
            this.metroTextBoxCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCantidad.Lines = new string[] {
        "1"};
            this.metroTextBoxCantidad.Location = new System.Drawing.Point(294, 200);
            this.metroTextBoxCantidad.MaxLength = 32767;
            this.metroTextBoxCantidad.Name = "metroTextBoxCantidad";
            this.metroTextBoxCantidad.PasswordChar = '\0';
            this.metroTextBoxCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCantidad.SelectedText = "";
            this.metroTextBoxCantidad.SelectionLength = 0;
            this.metroTextBoxCantidad.SelectionStart = 0;
            this.metroTextBoxCantidad.ShortcutsEnabled = true;
            this.metroTextBoxCantidad.Size = new System.Drawing.Size(48, 29);
            this.metroTextBoxCantidad.TabIndex = 6;
            this.metroTextBoxCantidad.Text = "1";
            this.metroTextBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroToolTip1.SetToolTip(this.metroTextBoxCantidad, "Ingrese la cantidad del producto");
            this.metroTextBoxCantidad.UseCustomForeColor = true;
            this.metroTextBoxCantidad.UseSelectable = true;
            this.metroTextBoxCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCantidad.Click += new System.EventHandler(this.metroTextBoxCantidad_Click);
            this.metroTextBoxCantidad.Enter += new System.EventHandler(this.metroTextBoxCantidad_Enter);
            this.metroTextBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxCantidad_KeyPress);
            this.metroTextBoxCantidad.Leave += new System.EventHandler(this.metroTextBoxCantidad_Leave);
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(337, 357);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 10;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileAccept, "Ingresar");
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Location = new System.Drawing.Point(23, 357);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose.TabIndex = 9;
            this.metroTileClose.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileClose, "Volver");
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseTileImage = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose_Click_1);
            // 
            // metroLabelCliente
            // 
            this.metroLabelCliente.Location = new System.Drawing.Point(23, 60);
            this.metroLabelCliente.Name = "metroLabelCliente";
            this.metroLabelCliente.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCliente.TabIndex = 18;
            this.metroLabelCliente.Text = "Cliente";
            this.metroLabelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Cantidad});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(23, 235);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.ReadOnly = true;
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(389, 116);
            this.metroGridProductos.TabIndex = 29;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // metroTextBoxFactura
            // 
            // 
            // 
            // 
            this.metroTextBoxFactura.CustomButton.Image = null;
            this.metroTextBoxFactura.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.metroTextBoxFactura.CustomButton.Name = "";
            this.metroTextBoxFactura.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFactura.CustomButton.TabIndex = 1;
            this.metroTextBoxFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFactura.CustomButton.UseSelectable = true;
            this.metroTextBoxFactura.CustomButton.Visible = false;
            this.metroTextBoxFactura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFactura.Lines = new string[0];
            this.metroTextBoxFactura.Location = new System.Drawing.Point(110, 130);
            this.metroTextBoxFactura.MaxLength = 32767;
            this.metroTextBoxFactura.Name = "metroTextBoxFactura";
            this.metroTextBoxFactura.PasswordChar = '\0';
            this.metroTextBoxFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFactura.SelectedText = "";
            this.metroTextBoxFactura.SelectionLength = 0;
            this.metroTextBoxFactura.SelectionStart = 0;
            this.metroTextBoxFactura.ShortcutsEnabled = true;
            this.metroTextBoxFactura.Size = new System.Drawing.Size(302, 29);
            this.metroTextBoxFactura.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.metroTextBoxFactura, "Ingrese el número de factura");
            this.metroTextBoxFactura.UseCustomForeColor = true;
            this.metroTextBoxFactura.UseSelectable = true;
            this.metroTextBoxFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFactura.Enter += new System.EventHandler(this.metroTextBoxFactura_Enter);
            this.metroTextBoxFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxFactura_KeyPress);
            this.metroTextBoxFactura.Leave += new System.EventHandler(this.metroTextBoxFactura_Leave);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(383, 200);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(29, 29);
            this.metroButtonClear.TabIndex = 8;
            this.metroButtonClear.Text = "-";
            this.metroToolTip1.SetToolTip(this.metroButtonClear, "Limpiar tabla de productos");
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(348, 200);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(29, 29);
            this.metroButtonAdd.TabIndex = 7;
            this.metroButtonAdd.Text = "+";
            this.metroToolTip1.SetToolTip(this.metroButtonAdd, "Agregar producto y cantidad seleccionada");
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroComboBoxCliente
            // 
            this.metroComboBoxCliente.FormattingEnabled = true;
            this.metroComboBoxCliente.ItemHeight = 23;
            this.metroComboBoxCliente.Location = new System.Drawing.Point(110, 60);
            this.metroComboBoxCliente.Name = "metroComboBoxCliente";
            this.metroComboBoxCliente.Size = new System.Drawing.Size(302, 29);
            this.metroComboBoxCliente.TabIndex = 20;
            this.metroToolTip1.SetToolTip(this.metroComboBoxCliente, "Seleccione el cliente");
            this.metroComboBoxCliente.UseSelectable = true;
            // 
            // metroLabelProducto
            // 
            this.metroLabelProducto.Location = new System.Drawing.Point(23, 200);
            this.metroLabelProducto.Name = "metroLabelProducto";
            this.metroLabelProducto.Size = new System.Drawing.Size(81, 29);
            this.metroLabelProducto.TabIndex = 26;
            this.metroLabelProducto.Text = "Producto";
            this.metroLabelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelFecha
            // 
            this.metroLabelFecha.Location = new System.Drawing.Point(23, 95);
            this.metroLabelFecha.Name = "metroLabelFecha";
            this.metroLabelFecha.Size = new System.Drawing.Size(81, 29);
            this.metroLabelFecha.TabIndex = 21;
            this.metroLabelFecha.Text = "Fecha";
            this.metroLabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroComboBoxProducto
            // 
            this.metroComboBoxProducto.FormattingEnabled = true;
            this.metroComboBoxProducto.ItemHeight = 23;
            this.metroComboBoxProducto.Location = new System.Drawing.Point(110, 200);
            this.metroComboBoxProducto.Name = "metroComboBoxProducto";
            this.metroComboBoxProducto.Size = new System.Drawing.Size(178, 29);
            this.metroComboBoxProducto.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.metroComboBoxProducto, "Seleccione el producto");
            this.metroComboBoxProducto.UseSelectable = true;
            // 
            // metroLabelFactura
            // 
            this.metroLabelFactura.Location = new System.Drawing.Point(23, 130);
            this.metroLabelFactura.Name = "metroLabelFactura";
            this.metroLabelFactura.Size = new System.Drawing.Size(81, 29);
            this.metroLabelFactura.TabIndex = 22;
            this.metroLabelFactura.Text = "Nº Factura";
            this.metroLabelFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelPrecio
            // 
            this.metroLabelPrecio.Location = new System.Drawing.Point(23, 165);
            this.metroLabelPrecio.Name = "metroLabelPrecio";
            this.metroLabelPrecio.Size = new System.Drawing.Size(81, 29);
            this.metroLabelPrecio.TabIndex = 24;
            this.metroLabelPrecio.Text = "Precio";
            this.metroLabelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxPrecio
            // 
            // 
            // 
            // 
            this.metroTextBoxPrecio.CustomButton.Image = null;
            this.metroTextBoxPrecio.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.metroTextBoxPrecio.CustomButton.Name = "";
            this.metroTextBoxPrecio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrecio.CustomButton.TabIndex = 1;
            this.metroTextBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrecio.CustomButton.UseSelectable = true;
            this.metroTextBoxPrecio.CustomButton.Visible = false;
            this.metroTextBoxPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPrecio.Lines = new string[0];
            this.metroTextBoxPrecio.Location = new System.Drawing.Point(110, 165);
            this.metroTextBoxPrecio.MaxLength = 32767;
            this.metroTextBoxPrecio.Name = "metroTextBoxPrecio";
            this.metroTextBoxPrecio.PasswordChar = '\0';
            this.metroTextBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrecio.SelectedText = "";
            this.metroTextBoxPrecio.SelectionLength = 0;
            this.metroTextBoxPrecio.SelectionStart = 0;
            this.metroTextBoxPrecio.ShortcutsEnabled = true;
            this.metroTextBoxPrecio.Size = new System.Drawing.Size(302, 29);
            this.metroTextBoxPrecio.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.metroTextBoxPrecio, "Ingrese el precio");
            this.metroTextBoxPrecio.UseCustomForeColor = true;
            this.metroTextBoxPrecio.UseSelectable = true;
            this.metroTextBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPrecio.Enter += new System.EventHandler(this.metroTextBoxPrecio_Enter);
            this.metroTextBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxPrecio_KeyPress);
            this.metroTextBoxPrecio.Leave += new System.EventHandler(this.metroTextBoxPrecio_Leave);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 455);
            this.ControlBox = false;
            this.Controls.Add(this.metroDateTimeFecha);
            this.Controls.Add(this.metroTextBoxCantidad);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTileClose);
            this.Controls.Add(this.metroLabelCliente);
            this.Controls.Add(this.metroGridProductos);
            this.Controls.Add(this.metroTextBoxFactura);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroComboBoxCliente);
            this.Controls.Add(this.metroLabelProducto);
            this.Controls.Add(this.metroLabelFecha);
            this.Controls.Add(this.metroComboBoxProducto);
            this.Controls.Add(this.metroLabelFactura);
            this.Controls.Add(this.metroLabelPrecio);
            this.Controls.Add(this.metroTextBoxPrecio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.Resizable = false;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCantidad;
        private MetroFramework.Controls.MetroTile metroTileAccept;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroLabel metroLabelCliente;
        private MetroFramework.Controls.MetroGrid metroGridProductos;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFactura;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCliente;
        private MetroFramework.Controls.MetroLabel metroLabelProducto;
        private MetroFramework.Controls.MetroLabel metroLabelFecha;
        private MetroFramework.Controls.MetroComboBox metroComboBoxProducto;
        private MetroFramework.Controls.MetroLabel metroLabelFactura;
        private MetroFramework.Controls.MetroLabel metroLabelPrecio;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrecio;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}