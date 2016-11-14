namespace System
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTileProveedores = new MetroFramework.Controls.MetroTile();
            this.metroTileProductos = new MetroFramework.Controls.MetroTile();
            this.metroTileVentas = new MetroFramework.Controls.MetroTile();
            this.metroTileClientes = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileProveedores
            // 
            this.metroTileProveedores.ActiveControl = null;
            this.metroTileProveedores.Location = new System.Drawing.Point(179, 63);
            this.metroTileProveedores.Name = "metroTileProveedores";
            this.metroTileProveedores.Size = new System.Drawing.Size(150, 90);
            this.metroTileProveedores.TabIndex = 1;
            this.metroTileProveedores.Text = "Proovedores";
            this.metroTileProveedores.UseSelectable = true;
            // 
            // metroTileProductos
            // 
            this.metroTileProductos.ActiveControl = null;
            this.metroTileProductos.Location = new System.Drawing.Point(337, 63);
            this.metroTileProductos.Name = "metroTileProductos";
            this.metroTileProductos.Size = new System.Drawing.Size(150, 90);
            this.metroTileProductos.TabIndex = 2;
            this.metroTileProductos.Text = "Productos";
            this.metroTileProductos.UseSelectable = true;
            // 
            // metroTileVentas
            // 
            this.metroTileVentas.ActiveControl = null;
            this.metroTileVentas.Location = new System.Drawing.Point(23, 159);
            this.metroTileVentas.Name = "metroTileVentas";
            this.metroTileVentas.Size = new System.Drawing.Size(150, 90);
            this.metroTileVentas.TabIndex = 3;
            this.metroTileVentas.Text = "Ventas";
            this.metroTileVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileVentas.TileImage = global::System.Properties.Resources.dollar;
            this.metroTileVentas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileVentas.UseSelectable = true;
            this.metroTileVentas.UseTileImage = true;
            this.metroTileVentas.Click += new System.EventHandler(this.metroTileVentas_Click);
            // 
            // metroTileClientes
            // 
            this.metroTileClientes.ActiveControl = null;
            this.metroTileClientes.Location = new System.Drawing.Point(23, 63);
            this.metroTileClientes.Name = "metroTileClientes";
            this.metroTileClientes.Size = new System.Drawing.Size(150, 90);
            this.metroTileClientes.TabIndex = 0;
            this.metroTileClientes.Text = "Clientes";
            this.metroTileClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileClientes.TileImage = global::System.Properties.Resources.user;
            this.metroTileClientes.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileClientes.UseSelectable = true;
            this.metroTileClientes.UseTileImage = true;
            this.metroTileClientes.Click += new System.EventHandler(this.metroTileClientes_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 303);
            this.Controls.Add(this.metroTileVentas);
            this.Controls.Add(this.metroTileProductos);
            this.Controls.Add(this.metroTileProveedores);
            this.Controls.Add(this.metroTileClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Resizable = false;
            this.Text = "JorgeSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileClientes;
        private MetroFramework.Controls.MetroTile metroTileProveedores;
        private MetroFramework.Controls.MetroTile metroTileProductos;
        private MetroFramework.Controls.MetroTile metroTileVentas;
    }
}

