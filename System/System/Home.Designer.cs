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
            this.metroTileCompras = new MetroFramework.Controls.MetroTile();
            this.metroTileOpciones = new MetroFramework.Controls.MetroTile();
            this.metroTileMovimientos = new MetroFramework.Controls.MetroTile();
            this.metroTileInventario = new MetroFramework.Controls.MetroTile();
            this.metroTileVentas = new MetroFramework.Controls.MetroTile();
            this.metroTileProductos = new MetroFramework.Controls.MetroTile();
            this.metroTileProveedores = new MetroFramework.Controls.MetroTile();
            this.metroTileClientes = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileCompras
            // 
            this.metroTileCompras.ActiveControl = null;
            this.metroTileCompras.Location = new System.Drawing.Point(179, 159);
            this.metroTileCompras.Name = "metroTileCompras";
            this.metroTileCompras.Size = new System.Drawing.Size(150, 90);
            this.metroTileCompras.TabIndex = 4;
            this.metroTileCompras.Text = "Compras";
            this.metroTileCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileCompras.TileImage = global::System.Properties.Resources.cart_plus;
            this.metroTileCompras.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileCompras.UseSelectable = true;
            this.metroTileCompras.UseTileImage = true;
            this.metroTileCompras.Click += new System.EventHandler(this.metroTileCompras_Click);
            // 
            // metroTileOpciones
            // 
            this.metroTileOpciones.ActiveControl = null;
            this.metroTileOpciones.Location = new System.Drawing.Point(337, 256);
            this.metroTileOpciones.Name = "metroTileOpciones";
            this.metroTileOpciones.Size = new System.Drawing.Size(150, 90);
            this.metroTileOpciones.TabIndex = 7;
            this.metroTileOpciones.Text = "Opciones";
            this.metroTileOpciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileOpciones.TileImage = global::System.Properties.Resources.cog;
            this.metroTileOpciones.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileOpciones.UseSelectable = true;
            this.metroTileOpciones.UseTileImage = true;
            this.metroTileOpciones.Click += new System.EventHandler(this.metroTileOpciones_Click);
            // 
            // metroTileMovimientos
            // 
            this.metroTileMovimientos.ActiveControl = null;
            this.metroTileMovimientos.Location = new System.Drawing.Point(23, 256);
            this.metroTileMovimientos.Name = "metroTileMovimientos";
            this.metroTileMovimientos.Size = new System.Drawing.Size(306, 90);
            this.metroTileMovimientos.TabIndex = 6;
            this.metroTileMovimientos.Text = "Movimientos";
            this.metroTileMovimientos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileMovimientos.TileImage = global::System.Properties.Resources.bar_chart;
            this.metroTileMovimientos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileMovimientos.UseSelectable = true;
            this.metroTileMovimientos.UseTileImage = true;
            this.metroTileMovimientos.Click += new System.EventHandler(this.metroTileMovimientos_Click);
            // 
            // metroTileInventario
            // 
            this.metroTileInventario.ActiveControl = null;
            this.metroTileInventario.Location = new System.Drawing.Point(337, 159);
            this.metroTileInventario.Name = "metroTileInventario";
            this.metroTileInventario.Size = new System.Drawing.Size(150, 90);
            this.metroTileInventario.TabIndex = 5;
            this.metroTileInventario.Text = "Inventario";
            this.metroTileInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileInventario.TileImage = global::System.Properties.Resources.table;
            this.metroTileInventario.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileInventario.UseSelectable = true;
            this.metroTileInventario.UseTileImage = true;
            this.metroTileInventario.Click += new System.EventHandler(this.metroTileInventario_Click);
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
            // metroTileProductos
            // 
            this.metroTileProductos.ActiveControl = null;
            this.metroTileProductos.Location = new System.Drawing.Point(337, 63);
            this.metroTileProductos.Name = "metroTileProductos";
            this.metroTileProductos.Size = new System.Drawing.Size(150, 90);
            this.metroTileProductos.TabIndex = 2;
            this.metroTileProductos.Text = "Productos";
            this.metroTileProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileProductos.TileImage = global::System.Properties.Resources.archive;
            this.metroTileProductos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileProductos.UseSelectable = true;
            this.metroTileProductos.UseTileImage = true;
            this.metroTileProductos.Click += new System.EventHandler(this.metroTileProductos_Click);
            // 
            // metroTileProveedores
            // 
            this.metroTileProveedores.ActiveControl = null;
            this.metroTileProveedores.Location = new System.Drawing.Point(179, 63);
            this.metroTileProveedores.Name = "metroTileProveedores";
            this.metroTileProveedores.Size = new System.Drawing.Size(150, 90);
            this.metroTileProveedores.TabIndex = 1;
            this.metroTileProveedores.Text = "Proovedores";
            this.metroTileProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileProveedores.TileImage = global::System.Properties.Resources.user_secret;
            this.metroTileProveedores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileProveedores.UseSelectable = true;
            this.metroTileProveedores.UseTileImage = true;
            this.metroTileProveedores.Click += new System.EventHandler(this.metroTileProveedores_Click);
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
            this.ClientSize = new System.Drawing.Size(510, 369);
            this.Controls.Add(this.metroTileOpciones);
            this.Controls.Add(this.metroTileMovimientos);
            this.Controls.Add(this.metroTileInventario);
            this.Controls.Add(this.metroTileCompras);
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
        private MetroFramework.Controls.MetroTile metroTileCompras;
        private MetroFramework.Controls.MetroTile metroTileInventario;
        private MetroFramework.Controls.MetroTile metroTileMovimientos;
        private MetroFramework.Controls.MetroTile metroTileOpciones;
    }
}

