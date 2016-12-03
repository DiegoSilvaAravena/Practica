namespace System
{
    partial class Proveedores
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
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblRUT = new MetroFramework.Controls.MetroLabel();
            this.txtRutProv = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProv = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAgregarProv = new MetroFramework.Controls.MetroTile();
            this.btnCerrar = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGridProv = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileEdit = new MetroFramework.Controls.MetroTile();
            this.metroTileDelete = new MetroFramework.Controls.MetroTile();
            this.btnCerrarLista = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(51, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRUT
            // 
            this.lblRUT.AutoSize = true;
            this.lblRUT.Location = new System.Drawing.Point(78, 39);
            this.lblRUT.Name = "lblRUT";
            this.lblRUT.Size = new System.Drawing.Size(33, 19);
            this.lblRUT.TabIndex = 1;
            this.lblRUT.Text = "RUT";
            // 
            // txtRutProv
            // 
            // 
            // 
            // 
            this.txtRutProv.CustomButton.Image = null;
            this.txtRutProv.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txtRutProv.CustomButton.Name = "";
            this.txtRutProv.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRutProv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutProv.CustomButton.TabIndex = 1;
            this.txtRutProv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutProv.CustomButton.UseSelectable = true;
            this.txtRutProv.CustomButton.Visible = false;
            this.txtRutProv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRutProv.Lines = new string[0];
            this.txtRutProv.Location = new System.Drawing.Point(117, 35);
            this.txtRutProv.MaxLength = 12;
            this.txtRutProv.Name = "txtRutProv";
            this.txtRutProv.PasswordChar = '\0';
            this.txtRutProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutProv.SelectedText = "";
            this.txtRutProv.SelectionLength = 0;
            this.txtRutProv.SelectionStart = 0;
            this.txtRutProv.ShortcutsEnabled = true;
            this.txtRutProv.Size = new System.Drawing.Size(300, 29);
            this.txtRutProv.TabIndex = 2;
            this.txtRutProv.UseCustomForeColor = true;
            this.txtRutProv.UseSelectable = true;
            this.txtRutProv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutProv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRutProv.Enter += new System.EventHandler(this.txtRutProv_Enter);
            this.txtRutProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutProv_KeyPress);
            this.txtRutProv.Leave += new System.EventHandler(this.txtRutProv_Leave);
            // 
            // txtNombreProv
            // 
            // 
            // 
            // 
            this.txtNombreProv.CustomButton.Image = null;
            this.txtNombreProv.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txtNombreProv.CustomButton.Name = "";
            this.txtNombreProv.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombreProv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProv.CustomButton.TabIndex = 1;
            this.txtNombreProv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProv.CustomButton.UseSelectable = true;
            this.txtNombreProv.CustomButton.Visible = false;
            this.txtNombreProv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreProv.Lines = new string[0];
            this.txtNombreProv.Location = new System.Drawing.Point(117, 73);
            this.txtNombreProv.MaxLength = 32767;
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.PasswordChar = '\0';
            this.txtNombreProv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProv.SelectedText = "";
            this.txtNombreProv.SelectionLength = 0;
            this.txtNombreProv.SelectionStart = 0;
            this.txtNombreProv.ShortcutsEnabled = true;
            this.txtNombreProv.Size = new System.Drawing.Size(300, 29);
            this.txtNombreProv.TabIndex = 3;
            this.txtNombreProv.UseCustomForeColor = true;
            this.txtNombreProv.UseSelectable = true;
            this.txtNombreProv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreProv.TextChanged += new System.EventHandler(this.txtNombreProv_TextChanged);
            this.txtNombreProv.Enter += new System.EventHandler(this.txtNombreProv_Enter);
            this.txtNombreProv.Leave += new System.EventHandler(this.txtNombreProv_Leave);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(37, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(474, 313);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnAgregarProv);
            this.metroTabPage1.Controls.Add(this.btnCerrar);
            this.metroTabPage1.Controls.Add(this.txtRutProv);
            this.metroTabPage1.Controls.Add(this.txtNombreProv);
            this.metroTabPage1.Controls.Add(this.lblNombre);
            this.metroTabPage1.Controls.Add(this.lblRUT);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(466, 271);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Nuevo";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.ActiveControl = null;
            this.btnAgregarProv.Location = new System.Drawing.Point(342, 193);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(75, 75);
            this.btnAgregarProv.Style = MetroFramework.MetroColorStyle.White;
            this.btnAgregarProv.TabIndex = 8;
            this.btnAgregarProv.TileImage = global::System.Properties.Resources.check;
            this.btnAgregarProv.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProv.UseSelectable = true;
            this.btnAgregarProv.UseTileImage = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveControl = null;
            this.btnCerrar.Location = new System.Drawing.Point(3, 193);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 75);
            this.btnCerrar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TileImage = global::System.Properties.Resources.chevron_left;
            this.btnCerrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.UseTileImage = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGridProv);
            this.metroTabPage2.Controls.Add(this.metroTileEdit);
            this.metroTabPage2.Controls.Add(this.metroTileDelete);
            this.metroTabPage2.Controls.Add(this.btnCerrarLista);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(466, 271);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Lista";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroGridProv
            // 
            this.metroGridProv.AllowUserToAddRows = false;
            this.metroGridProv.AllowUserToDeleteRows = false;
            this.metroGridProv.AllowUserToResizeRows = false;
            this.metroGridProv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RUT,
            this.NOMBRE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProv.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridProv.EnableHeadersVisualStyles = false;
            this.metroGridProv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProv.Location = new System.Drawing.Point(3, 3);
            this.metroGridProv.Name = "metroGridProv";
            this.metroGridProv.ReadOnly = true;
            this.metroGridProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridProv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProv.Size = new System.Drawing.Size(460, 184);
            this.metroGridProv.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 41;
            // 
            // RUT
            // 
            this.RUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RUT.HeaderText = "RUT";
            this.RUT.Name = "RUT";
            this.RUT.ReadOnly = true;
            this.RUT.Width = 50;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRE.HeaderText = "NOMBRE COMPLETO";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // metroTileEdit
            // 
            this.metroTileEdit.ActiveControl = null;
            this.metroTileEdit.Location = new System.Drawing.Point(307, 193);
            this.metroTileEdit.Name = "metroTileEdit";
            this.metroTileEdit.Size = new System.Drawing.Size(75, 75);
            this.metroTileEdit.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileEdit.TabIndex = 8;
            this.metroTileEdit.TileImage = global::System.Properties.Resources.pencil;
            this.metroTileEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEdit.UseSelectable = true;
            this.metroTileEdit.UseTileImage = true;
            this.metroTileEdit.Click += new System.EventHandler(this.metroTileEdit_Click);
            // 
            // metroTileDelete
            // 
            this.metroTileDelete.ActiveControl = null;
            this.metroTileDelete.Location = new System.Drawing.Point(388, 193);
            this.metroTileDelete.Name = "metroTileDelete";
            this.metroTileDelete.Size = new System.Drawing.Size(75, 75);
            this.metroTileDelete.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileDelete.TabIndex = 9;
            this.metroTileDelete.TileImage = global::System.Properties.Resources.times;
            this.metroTileDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDelete.UseSelectable = true;
            this.metroTileDelete.UseTileImage = true;
            this.metroTileDelete.Click += new System.EventHandler(this.metroTileDelete_Click_1);
            // 
            // btnCerrarLista
            // 
            this.btnCerrarLista.ActiveControl = null;
            this.btnCerrarLista.Location = new System.Drawing.Point(3, 193);
            this.btnCerrarLista.Name = "btnCerrarLista";
            this.btnCerrarLista.Size = new System.Drawing.Size(75, 75);
            this.btnCerrarLista.Style = MetroFramework.MetroColorStyle.White;
            this.btnCerrarLista.TabIndex = 7;
            this.btnCerrarLista.TileImage = global::System.Properties.Resources.chevron_left;
            this.btnCerrarLista.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarLista.UseSelectable = true;
            this.btnCerrarLista.UseTileImage = true;
            this.btnCerrarLista.Click += new System.EventHandler(this.btnCerrarLista_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 384);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProv)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblRUT;
        private MetroFramework.Controls.MetroTextBox txtRutProv;
        private MetroFramework.Controls.MetroTextBox txtNombreProv;
        private MetroFramework.Controls.MetroTile btnAgregarProv;
        private MetroFramework.Controls.MetroTile btnCerrar;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile metroTileEdit;
        private MetroFramework.Controls.MetroTile metroTileDelete;
        private MetroFramework.Controls.MetroTile btnCerrarLista;
        public MetroFramework.Controls.MetroGrid metroGridProv;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn RUT;
        private Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
    }
}