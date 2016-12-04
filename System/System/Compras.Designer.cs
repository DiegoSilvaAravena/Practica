namespace System
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.GVProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.cboProveedor = new MetroFramework.Controls.MetroComboBox();
            this.lblProducto = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
            this.cboProducto = new MetroFramework.Controls.MetroComboBox();
            this.lblFactura = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioFlete = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecioFlete = new MetroFramework.Controls.MetroLabel();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.btnCerrarLista = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.GVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.CustomButton.Image = null;
            this.txtCantidad.CustomButton.Location = new System.Drawing.Point(20, 1);
            this.txtCantidad.CustomButton.Name = "";
            this.txtCantidad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidad.CustomButton.TabIndex = 1;
            this.txtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidad.CustomButton.UseSelectable = true;
            this.txtCantidad.CustomButton.Visible = false;
            this.txtCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCantidad.Lines = new string[] {
        "1"};
            this.txtCantidad.Location = new System.Drawing.Point(291, 200);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.ShortcutsEnabled = true;
            this.txtCantidad.Size = new System.Drawing.Size(48, 29);
            this.txtCantidad.TabIndex = 30;
            this.txtCantidad.Text = "1";
            this.txtCantidad.UseCustomForeColor = true;
            this.txtCantidad.UseSelectable = true;
            this.txtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(23, 60);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(81, 29);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GVProductos
            // 
            this.GVProductos.AllowUserToAddRows = false;
            this.GVProductos.AllowUserToDeleteRows = false;
            this.GVProductos.AllowUserToResizeRows = false;
            this.GVProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.GVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Cantidad});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVProductos.DefaultCellStyle = dataGridViewCellStyle26;
            this.GVProductos.EnableHeadersVisualStyles = false;
            this.GVProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GVProductos.Location = new System.Drawing.Point(23, 235);
            this.GVProductos.Name = "GVProductos";
            this.GVProductos.ReadOnly = true;
            this.GVProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.GVProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVProductos.Size = new System.Drawing.Size(386, 116);
            this.GVProductos.TabIndex = 29;
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
            // txtFactura
            // 
            // 
            // 
            // 
            this.txtFactura.CustomButton.Image = null;
            this.txtFactura.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtFactura.CustomButton.Name = "";
            this.txtFactura.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFactura.CustomButton.TabIndex = 1;
            this.txtFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFactura.CustomButton.UseSelectable = true;
            this.txtFactura.CustomButton.Visible = false;
            this.txtFactura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFactura.Lines = new string[0];
            this.txtFactura.Location = new System.Drawing.Point(110, 130);
            this.txtFactura.MaxLength = 32767;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.PasswordChar = '\0';
            this.txtFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFactura.SelectedText = "";
            this.txtFactura.SelectionLength = 0;
            this.txtFactura.SelectionStart = 0;
            this.txtFactura.ShortcutsEnabled = true;
            this.txtFactura.Size = new System.Drawing.Size(302, 29);
            this.txtFactura.TabIndex = 19;
            this.txtFactura.UseCustomForeColor = true;
            this.txtFactura.UseSelectable = true;
            this.txtFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFactura.Enter += new System.EventHandler(this.txtFacturaFactura_Enter);
            this.txtFactura.Leave += new System.EventHandler(this.txtFactura_Leave);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(380, 200);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(29, 29);
            this.metroButtonClear.TabIndex = 28;
            this.metroButtonClear.Text = "-";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(345, 200);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(29, 29);
            this.metroButtonAdd.TabIndex = 27;
            this.metroButtonAdd.Text = "+";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.ItemHeight = 23;
            this.cboProveedor.Location = new System.Drawing.Point(110, 60);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(302, 29);
            this.cboProveedor.TabIndex = 20;
            this.cboProveedor.UseSelectable = true;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(23, 200);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(81, 29);
            this.lblProducto.TabIndex = 26;
            this.lblProducto.Text = "Producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.ItemHeight = 23;
            this.cboProducto.Location = new System.Drawing.Point(110, 200);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(175, 29);
            this.cboProducto.TabIndex = 25;
            this.cboProducto.UseSelectable = true;
            // 
            // lblFactura
            // 
            this.lblFactura.Location = new System.Drawing.Point(23, 130);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(81, 29);
            this.lblFactura.TabIndex = 22;
            this.lblFactura.Text = "Nº Factura";
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(23, 165);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(81, 29);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(110, 165);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(132, 29);
            this.txtPrecio.TabIndex = 23;
            this.txtPrecio.UseCustomForeColor = true;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtPrecioFlete
            // 
            // 
            // 
            // 
            this.txtPrecioFlete.CustomButton.Image = null;
            this.txtPrecioFlete.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtPrecioFlete.CustomButton.Name = "";
            this.txtPrecioFlete.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecioFlete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioFlete.CustomButton.TabIndex = 1;
            this.txtPrecioFlete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioFlete.CustomButton.UseSelectable = true;
            this.txtPrecioFlete.CustomButton.Visible = false;
            this.txtPrecioFlete.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioFlete.Lines = new string[] {
        "0"};
            this.txtPrecioFlete.Location = new System.Drawing.Point(291, 165);
            this.txtPrecioFlete.MaxLength = 32767;
            this.txtPrecioFlete.Name = "txtPrecioFlete";
            this.txtPrecioFlete.PasswordChar = '\0';
            this.txtPrecioFlete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioFlete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioFlete.SelectedText = "";
            this.txtPrecioFlete.SelectionLength = 0;
            this.txtPrecioFlete.SelectionStart = 0;
            this.txtPrecioFlete.ShortcutsEnabled = true;
            this.txtPrecioFlete.Size = new System.Drawing.Size(121, 29);
            this.txtPrecioFlete.TabIndex = 32;
            this.txtPrecioFlete.Text = "0";
            this.txtPrecioFlete.UseCustomForeColor = true;
            this.txtPrecioFlete.UseSelectable = true;
            this.txtPrecioFlete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioFlete.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioFlete.Enter += new System.EventHandler(this.txtPrecioFlete_Enter);
            this.txtPrecioFlete.Leave += new System.EventHandler(this.txtPrecioFlete_Leave);
            // 
            // lblPrecioFlete
            // 
            this.lblPrecioFlete.Location = new System.Drawing.Point(248, 165);
            this.lblPrecioFlete.Name = "lblPrecioFlete";
            this.lblPrecioFlete.Size = new System.Drawing.Size(37, 29);
            this.lblPrecioFlete.TabIndex = 33;
            this.lblPrecioFlete.Text = "Flete";
            this.lblPrecioFlete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(337, 357);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 35;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroDateTimeFecha.Location = new System.Drawing.Point(110, 95);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(302, 29);
            this.metroDateTimeFecha.TabIndex = 36;
            // 
            // btnCerrarLista
            // 
            this.btnCerrarLista.ActiveControl = null;
            this.btnCerrarLista.Location = new System.Drawing.Point(23, 357);
            this.btnCerrarLista.Name = "btnCerrarLista";
            this.btnCerrarLista.Size = new System.Drawing.Size(75, 75);
            this.btnCerrarLista.Style = MetroFramework.MetroColorStyle.White;
            this.btnCerrarLista.TabIndex = 37;
            this.btnCerrarLista.TileImage = global::System.Properties.Resources.chevron_left;
            this.btnCerrarLista.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarLista.UseSelectable = true;
            this.btnCerrarLista.UseTileImage = true;
            this.btnCerrarLista.Click += new System.EventHandler(this.btnCerrarLista_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 455);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarLista);
            this.Controls.Add(this.metroDateTimeFecha);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.lblPrecioFlete);
            this.Controls.Add(this.txtPrecioFlete);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.GVProductos);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.metroLabelFecha);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Compras";
            this.Resizable = false;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.GVProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroLabel lblProveedor;
        private MetroFramework.Controls.MetroGrid GVProductos;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private MetroFramework.Controls.MetroTextBox txtFactura;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroComboBox cboProveedor;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroLabel metroLabelFecha;
        private MetroFramework.Controls.MetroComboBox cboProducto;
        private MetroFramework.Controls.MetroLabel lblFactura;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtPrecioFlete;
        private MetroFramework.Controls.MetroLabel lblPrecioFlete;
        private MetroFramework.Controls.MetroTile metroTileAccept;
        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
        private MetroFramework.Controls.MetroTile btnCerrarLista;
    }
}