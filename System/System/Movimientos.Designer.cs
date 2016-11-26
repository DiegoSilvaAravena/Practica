namespace System
{
    partial class Movimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelNombre = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeDesde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelHasta = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroGridMovimientos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONA = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PRODUCTOS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTotal = new MetroFramework.Controls.MetroLabel();
            this.metroTileFiltro = new MetroFramework.Controls.MetroTile();
            this.metroTileClose1 = new MetroFramework.Controls.MetroTile();
            this.metroToggleFecha = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEgresos = new MetroFramework.Controls.MetroLabel();
            this.metroLabelIngresos = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelNombre
            // 
            this.metroLabelNombre.Location = new System.Drawing.Point(141, 63);
            this.metroLabelNombre.Name = "metroLabelNombre";
            this.metroLabelNombre.Size = new System.Drawing.Size(47, 29);
            this.metroLabelNombre.TabIndex = 6;
            this.metroLabelNombre.Text = "Desde";
            this.metroLabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroDateTimeDesde
            // 
            this.metroDateTimeDesde.Checked = false;
            this.metroDateTimeDesde.Location = new System.Drawing.Point(194, 63);
            this.metroDateTimeDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDesde.Name = "metroDateTimeDesde";
            this.metroDateTimeDesde.Size = new System.Drawing.Size(234, 29);
            this.metroDateTimeDesde.TabIndex = 18;
            this.metroDateTimeDesde.ValueChanged += new System.EventHandler(this.metroDateTimeDesde_ValueChanged);
            // 
            // metroLabelHasta
            // 
            this.metroLabelHasta.Location = new System.Drawing.Point(434, 63);
            this.metroLabelHasta.Name = "metroLabelHasta";
            this.metroLabelHasta.Size = new System.Drawing.Size(41, 29);
            this.metroLabelHasta.TabIndex = 19;
            this.metroLabelHasta.Text = "Hasta";
            this.metroLabelHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroDateTimeHasta
            // 
            this.metroDateTimeHasta.Checked = false;
            this.metroDateTimeHasta.Location = new System.Drawing.Point(481, 63);
            this.metroDateTimeHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeHasta.Name = "metroDateTimeHasta";
            this.metroDateTimeHasta.Size = new System.Drawing.Size(234, 29);
            this.metroDateTimeHasta.TabIndex = 20;
            // 
            // metroGridMovimientos
            // 
            this.metroGridMovimientos.AllowUserToAddRows = false;
            this.metroGridMovimientos.AllowUserToDeleteRows = false;
            this.metroGridMovimientos.AllowUserToResizeRows = false;
            this.metroGridMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FACTURA,
            this.FECHA,
            this.DINERO,
            this.PERSONA,
            this.PRODUCTOS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridMovimientos.EnableHeadersVisualStyles = false;
            this.metroGridMovimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMovimientos.Location = new System.Drawing.Point(23, 98);
            this.metroGridMovimientos.Name = "metroGridMovimientos";
            this.metroGridMovimientos.ReadOnly = true;
            this.metroGridMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMovimientos.Size = new System.Drawing.Size(692, 233);
            this.metroGridMovimientos.TabIndex = 21;
            this.metroGridMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridMovimientos_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 41;
            // 
            // FACTURA
            // 
            this.FACTURA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FACTURA.HeaderText = "FACTURA";
            this.FACTURA.Name = "FACTURA";
            this.FACTURA.ReadOnly = true;
            this.FACTURA.Width = 76;
            // 
            // FECHA
            // 
            this.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 64;
            // 
            // DINERO
            // 
            this.DINERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DINERO.HeaderText = "DINERO";
            this.DINERO.Name = "DINERO";
            this.DINERO.ReadOnly = true;
            this.DINERO.Width = 71;
            // 
            // PERSONA
            // 
            this.PERSONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PERSONA.HeaderText = "CLIENTE - PROVEEDOR";
            this.PERSONA.Name = "PERSONA";
            this.PERSONA.ReadOnly = true;
            this.PERSONA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PRODUCTOS
            // 
            this.PRODUCTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCTOS.HeaderText = "PRODUCTOS";
            this.PRODUCTOS.Name = "PRODUCTOS";
            this.PRODUCTOS.ReadOnly = true;
            this.PRODUCTOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRODUCTOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 379);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 29);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Total";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelTotal
            // 
            this.metroLabelTotal.Location = new System.Drawing.Point(110, 379);
            this.metroLabelTotal.Name = "metroLabelTotal";
            this.metroLabelTotal.Size = new System.Drawing.Size(139, 29);
            this.metroLabelTotal.TabIndex = 24;
            this.metroLabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTileFiltro
            // 
            this.metroTileFiltro.ActiveControl = null;
            this.metroTileFiltro.Location = new System.Drawing.Point(596, 411);
            this.metroTileFiltro.Name = "metroTileFiltro";
            this.metroTileFiltro.Size = new System.Drawing.Size(75, 75);
            this.metroTileFiltro.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileFiltro.TabIndex = 25;
            this.metroTileFiltro.TileImage = global::System.Properties.Resources.search;
            this.metroTileFiltro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFiltro.UseSelectable = true;
            this.metroTileFiltro.UseTileImage = true;
            this.metroTileFiltro.Click += new System.EventHandler(this.metroTileFiltro_Click);
            // 
            // metroTileClose1
            // 
            this.metroTileClose1.ActiveControl = null;
            this.metroTileClose1.Location = new System.Drawing.Point(23, 411);
            this.metroTileClose1.Name = "metroTileClose1";
            this.metroTileClose1.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose1.TabIndex = 22;
            this.metroTileClose1.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose1.UseSelectable = true;
            this.metroTileClose1.UseTileImage = true;
            this.metroTileClose1.Click += new System.EventHandler(this.metroTileClose1_Click);
            // 
            // metroToggleFecha
            // 
            this.metroToggleFecha.Location = new System.Drawing.Point(44, 69);
            this.metroToggleFecha.Name = "metroToggleFecha";
            this.metroToggleFecha.Size = new System.Drawing.Size(80, 20);
            this.metroToggleFecha.TabIndex = 26;
            this.metroToggleFecha.Text = "Off";
            this.metroToggleFecha.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(255, 379);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 29);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Ingresos";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(466, 379);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 29);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Egresos";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelEgresos
            // 
            this.metroLabelEgresos.Location = new System.Drawing.Point(547, 379);
            this.metroLabelEgresos.Name = "metroLabelEgresos";
            this.metroLabelEgresos.Size = new System.Drawing.Size(139, 29);
            this.metroLabelEgresos.TabIndex = 30;
            this.metroLabelEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabelIngresos
            // 
            this.metroLabelIngresos.Location = new System.Drawing.Point(321, 379);
            this.metroLabelIngresos.Name = "metroLabelIngresos";
            this.metroLabelIngresos.Size = new System.Drawing.Size(139, 29);
            this.metroLabelIngresos.TabIndex = 31;
            this.metroLabelIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 509);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabelIngresos);
            this.Controls.Add(this.metroLabelEgresos);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroToggleFecha);
            this.Controls.Add(this.metroTileFiltro);
            this.Controls.Add(this.metroLabelTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTileClose1);
            this.Controls.Add(this.metroGridMovimientos);
            this.Controls.Add(this.metroDateTimeHasta);
            this.Controls.Add(this.metroLabelHasta);
            this.Controls.Add(this.metroDateTimeDesde);
            this.Controls.Add(this.metroLabelNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelNombre;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDesde;
        private MetroFramework.Controls.MetroLabel metroLabelHasta;
        private MetroFramework.Controls.MetroDateTime metroDateTimeHasta;
        private MetroFramework.Controls.MetroGrid metroGridMovimientos;
        private MetroFramework.Controls.MetroTile metroTileClose1;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn FACTURA;
        private Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private Windows.Forms.DataGridViewTextBoxColumn DINERO;
        private Windows.Forms.DataGridViewButtonColumn PERSONA;
        private Windows.Forms.DataGridViewButtonColumn PRODUCTOS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelTotal;
        private MetroFramework.Controls.MetroTile metroTileFiltro;
        private MetroFramework.Controls.MetroToggle metroToggleFecha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabelEgresos;
        private MetroFramework.Controls.MetroLabel metroLabelIngresos;
    }
}