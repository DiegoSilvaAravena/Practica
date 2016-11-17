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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelCliente = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFactura = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPrecio = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxProducto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelProducto = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.metroTileClose = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabelCliente
            // 
            this.metroLabelCliente.Location = new System.Drawing.Point(-4, 10);
            this.metroLabelCliente.Name = "metroLabelCliente";
            this.metroLabelCliente.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCliente.TabIndex = 0;
            this.metroLabelCliente.Text = "Cliente";
            this.metroLabelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxFactura
            // 
            // 
            // 
            // 
            this.metroTextBoxFactura.CustomButton.Image = null;
            this.metroTextBoxFactura.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.metroTextBoxFactura.CustomButton.Name = "";
            this.metroTextBoxFactura.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFactura.CustomButton.TabIndex = 1;
            this.metroTextBoxFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFactura.CustomButton.UseSelectable = true;
            this.metroTextBoxFactura.CustomButton.Visible = false;
            this.metroTextBoxFactura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFactura.Lines = new string[0];
            this.metroTextBoxFactura.Location = new System.Drawing.Point(83, 80);
            this.metroTextBoxFactura.MaxLength = 32767;
            this.metroTextBoxFactura.Name = "metroTextBoxFactura";
            this.metroTextBoxFactura.PasswordChar = '\0';
            this.metroTextBoxFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFactura.SelectedText = "";
            this.metroTextBoxFactura.SelectionLength = 0;
            this.metroTextBoxFactura.SelectionStart = 0;
            this.metroTextBoxFactura.ShortcutsEnabled = true;
            this.metroTextBoxFactura.Size = new System.Drawing.Size(293, 29);
            this.metroTextBoxFactura.TabIndex = 1;
            this.metroTextBoxFactura.UseCustomForeColor = true;
            this.metroTextBoxFactura.UseSelectable = true;
            this.metroTextBoxFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFactura.Enter += new System.EventHandler(this.metroTextBoxFactura_Enter);
            this.metroTextBoxFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxFactura_KeyPress);
            this.metroTextBoxFactura.Leave += new System.EventHandler(this.metroTextBoxFactura_Leave);
            // 
            // metroComboBoxCliente
            // 
            this.metroComboBoxCliente.FormattingEnabled = true;
            this.metroComboBoxCliente.ItemHeight = 23;
            this.metroComboBoxCliente.Location = new System.Drawing.Point(83, 10);
            this.metroComboBoxCliente.Name = "metroComboBoxCliente";
            this.metroComboBoxCliente.Size = new System.Drawing.Size(293, 29);
            this.metroComboBoxCliente.TabIndex = 4;
            this.metroComboBoxCliente.UseSelectable = true;
            // 
            // metroLabelFecha
            // 
            this.metroLabelFecha.Location = new System.Drawing.Point(-4, 45);
            this.metroLabelFecha.Name = "metroLabelFecha";
            this.metroLabelFecha.Size = new System.Drawing.Size(81, 29);
            this.metroLabelFecha.TabIndex = 5;
            this.metroLabelFecha.Text = "Fecha";
            this.metroLabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelFactura
            // 
            this.metroLabelFactura.Location = new System.Drawing.Point(-4, 80);
            this.metroLabelFactura.Name = "metroLabelFactura";
            this.metroLabelFactura.Size = new System.Drawing.Size(81, 29);
            this.metroLabelFactura.TabIndex = 6;
            this.metroLabelFactura.Text = "Nº Factura";
            this.metroLabelFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelPrecio
            // 
            this.metroLabelPrecio.Location = new System.Drawing.Point(-4, 115);
            this.metroLabelPrecio.Name = "metroLabelPrecio";
            this.metroLabelPrecio.Size = new System.Drawing.Size(81, 29);
            this.metroLabelPrecio.TabIndex = 8;
            this.metroLabelPrecio.Text = "Precio";
            this.metroLabelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroComboBoxProducto
            // 
            this.metroComboBoxProducto.FormattingEnabled = true;
            this.metroComboBoxProducto.ItemHeight = 23;
            this.metroComboBoxProducto.Location = new System.Drawing.Point(83, 150);
            this.metroComboBoxProducto.Name = "metroComboBoxProducto";
            this.metroComboBoxProducto.Size = new System.Drawing.Size(165, 29);
            this.metroComboBoxProducto.TabIndex = 9;
            this.metroComboBoxProducto.UseSelectable = true;
            // 
            // metroLabelProducto
            // 
            this.metroLabelProducto.Location = new System.Drawing.Point(-4, 150);
            this.metroLabelProducto.Name = "metroLabelProducto";
            this.metroLabelProducto.Size = new System.Drawing.Size(81, 29);
            this.metroLabelProducto.TabIndex = 10;
            this.metroLabelProducto.Text = "Producto";
            this.metroLabelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(308, 150);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(29, 29);
            this.metroButtonAdd.TabIndex = 11;
            this.metroButtonAdd.Text = "+";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(347, 150);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(29, 29);
            this.metroButtonClear.TabIndex = 12;
            this.metroButtonClear.Text = "-";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
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
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(3, 185);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.ReadOnly = true;
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(373, 108);
            this.metroGridProductos.TabIndex = 13;
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
            // metroTextBoxPrecio
            // 
            // 
            // 
            // 
            this.metroTextBoxPrecio.CustomButton.Image = null;
            this.metroTextBoxPrecio.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.metroTextBoxPrecio.CustomButton.Name = "";
            this.metroTextBoxPrecio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrecio.CustomButton.TabIndex = 1;
            this.metroTextBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrecio.CustomButton.UseSelectable = true;
            this.metroTextBoxPrecio.CustomButton.Visible = false;
            this.metroTextBoxPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPrecio.Lines = new string[0];
            this.metroTextBoxPrecio.Location = new System.Drawing.Point(83, 115);
            this.metroTextBoxPrecio.MaxLength = 32767;
            this.metroTextBoxPrecio.Name = "metroTextBoxPrecio";
            this.metroTextBoxPrecio.PasswordChar = '\0';
            this.metroTextBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrecio.SelectedText = "";
            this.metroTextBoxPrecio.SelectionLength = 0;
            this.metroTextBoxPrecio.SelectionStart = 0;
            this.metroTextBoxPrecio.ShortcutsEnabled = true;
            this.metroTextBoxPrecio.Size = new System.Drawing.Size(293, 29);
            this.metroTextBoxPrecio.TabIndex = 7;
            this.metroTextBoxPrecio.UseCustomForeColor = true;
            this.metroTextBoxPrecio.UseSelectable = true;
            this.metroTextBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxPrecio.Enter += new System.EventHandler(this.metroTextBoxPrecio_Enter);
            this.metroTextBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            this.metroTextBoxPrecio.Leave += new System.EventHandler(this.metroTextBoxPrecio_Leave);
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
            this.metroTextBoxCantidad.Lines = new string[0];
            this.metroTextBoxCantidad.Location = new System.Drawing.Point(254, 150);
            this.metroTextBoxCantidad.MaxLength = 32767;
            this.metroTextBoxCantidad.Name = "metroTextBoxCantidad";
            this.metroTextBoxCantidad.PasswordChar = '\0';
            this.metroTextBoxCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCantidad.SelectedText = "";
            this.metroTextBoxCantidad.SelectionLength = 0;
            this.metroTextBoxCantidad.SelectionStart = 0;
            this.metroTextBoxCantidad.ShortcutsEnabled = true;
            this.metroTextBoxCantidad.Size = new System.Drawing.Size(48, 29);
            this.metroTextBoxCantidad.TabIndex = 16;
            this.metroTextBoxCantidad.UseCustomForeColor = true;
            this.metroTextBoxCantidad.UseSelectable = true;
            this.metroTextBoxCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCantidad.Enter += new System.EventHandler(this.metroTextBoxCantidad_Enter);
            this.metroTextBoxCantidad.Leave += new System.EventHandler(this.metroTextBoxCantidad_Leave);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(387, 439);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroDateTimeFecha);
            this.metroTabPage1.Controls.Add(this.metroTextBoxCantidad);
            this.metroTabPage1.Controls.Add(this.metroTileAccept);
            this.metroTabPage1.Controls.Add(this.metroTileClose);
            this.metroTabPage1.Controls.Add(this.metroLabelCliente);
            this.metroTabPage1.Controls.Add(this.metroGridProductos);
            this.metroTabPage1.Controls.Add(this.metroTextBoxFactura);
            this.metroTabPage1.Controls.Add(this.metroButtonClear);
            this.metroTabPage1.Controls.Add(this.metroButtonAdd);
            this.metroTabPage1.Controls.Add(this.metroComboBoxCliente);
            this.metroTabPage1.Controls.Add(this.metroLabelProducto);
            this.metroTabPage1.Controls.Add(this.metroLabelFecha);
            this.metroTabPage1.Controls.Add(this.metroComboBoxProducto);
            this.metroTabPage1.Controls.Add(this.metroLabelFactura);
            this.metroTabPage1.Controls.Add(this.metroLabelPrecio);
            this.metroTabPage1.Controls.Add(this.metroTextBoxPrecio);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(379, 397);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Nuevo";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(301, 299);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 15;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // metroTileClose
            // 
            this.metroTileClose.ActiveControl = null;
            this.metroTileClose.Location = new System.Drawing.Point(3, 299);
            this.metroTileClose.Name = "metroTileClose";
            this.metroTileClose.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose.TabIndex = 14;
            this.metroTileClose.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose.UseSelectable = true;
            this.metroTileClose.UseTileImage = true;
            this.metroTileClose.Click += new System.EventHandler(this.metroTileClose1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(379, 397);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Lista";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.Location = new System.Drawing.Point(83, 45);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(293, 29);
            this.metroDateTimeFecha.TabIndex = 17;
            this.metroDateTimeFecha.ValueChanged += new System.EventHandler(this.metroDateTimeFecha_ValueChanged);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 528);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.Resizable = false;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelCliente;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFactura;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCliente;
        private MetroFramework.Controls.MetroLabel metroLabelFecha;
        private MetroFramework.Controls.MetroLabel metroLabelFactura;
        private MetroFramework.Controls.MetroLabel metroLabelPrecio;
        private MetroFramework.Controls.MetroComboBox metroComboBoxProducto;
        private MetroFramework.Controls.MetroLabel metroLabelProducto;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroGrid metroGridProductos;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private MetroFramework.Controls.MetroTile metroTileClose;
        private MetroFramework.Controls.MetroTile metroTileAccept;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrecio;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCantidad;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
    }
}