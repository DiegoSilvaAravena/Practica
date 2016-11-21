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
            this.metroDateTimeFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroLabelHasta = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroGridMovimientos = new MetroFramework.Controls.MetroGrid();
            this.metroTileClose1 = new MetroFramework.Controls.MetroTile();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DINERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONA = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PRODUCTOS = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelNombre
            // 
            this.metroLabelNombre.Location = new System.Drawing.Point(23, 63);
            this.metroLabelNombre.Name = "metroLabelNombre";
            this.metroLabelNombre.Size = new System.Drawing.Size(81, 29);
            this.metroLabelNombre.TabIndex = 6;
            this.metroLabelNombre.Text = "Desde";
            this.metroLabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroDateTimeFecha
            // 
            this.metroDateTimeFecha.Location = new System.Drawing.Point(110, 63);
            this.metroDateTimeFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeFecha.Name = "metroDateTimeFecha";
            this.metroDateTimeFecha.Size = new System.Drawing.Size(234, 29);
            this.metroDateTimeFecha.TabIndex = 18;
            // 
            // metroLabelHasta
            // 
            this.metroLabelHasta.Location = new System.Drawing.Point(350, 63);
            this.metroLabelHasta.Name = "metroLabelHasta";
            this.metroLabelHasta.Size = new System.Drawing.Size(81, 29);
            this.metroLabelHasta.TabIndex = 19;
            this.metroLabelHasta.Text = "Hasta";
            this.metroLabelHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(437, 63);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(234, 29);
            this.metroDateTime1.TabIndex = 20;
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
            this.metroGridMovimientos.Size = new System.Drawing.Size(648, 233);
            this.metroGridMovimientos.TabIndex = 21;
            this.metroGridMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridMovimientos_CellContentClick);
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
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.ControlBox = false;
            this.Controls.Add(this.metroTileClose1);
            this.Controls.Add(this.metroGridMovimientos);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabelHasta);
            this.Controls.Add(this.metroDateTimeFecha);
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
        private MetroFramework.Controls.MetroDateTime metroDateTimeFecha;
        private MetroFramework.Controls.MetroLabel metroLabelHasta;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroGrid metroGridMovimientos;
        private MetroFramework.Controls.MetroTile metroTileClose1;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn FACTURA;
        private Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private Windows.Forms.DataGridViewTextBoxColumn DINERO;
        private Windows.Forms.DataGridViewButtonColumn PERSONA;
        private Windows.Forms.DataGridViewButtonColumn PRODUCTOS;
    }
}