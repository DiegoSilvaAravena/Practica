namespace System
{
    partial class Clientes
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
            this.metroLabelRUT = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRUT = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxApellidos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabelApellidos = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.metroTileClose1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGridClientes = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileEdit = new MetroFramework.Controls.MetroTile();
            this.metroTileDelete = new MetroFramework.Controls.MetroTile();
            this.metroTileClose2 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelRUT
            // 
            this.metroLabelRUT.Location = new System.Drawing.Point(0, 13);
            this.metroLabelRUT.Name = "metroLabelRUT";
            this.metroLabelRUT.Size = new System.Drawing.Size(81, 29);
            this.metroLabelRUT.TabIndex = 1;
            this.metroLabelRUT.Text = "RUT";
            this.metroLabelRUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxRUT
            // 
            // 
            // 
            // 
            this.metroTextBoxRUT.CustomButton.Image = null;
            this.metroTextBoxRUT.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.metroTextBoxRUT.CustomButton.Name = "";
            this.metroTextBoxRUT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxRUT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRUT.CustomButton.TabIndex = 1;
            this.metroTextBoxRUT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRUT.CustomButton.UseSelectable = true;
            this.metroTextBoxRUT.CustomButton.Visible = false;
            this.metroTextBoxRUT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxRUT.Lines = new string[0];
            this.metroTextBoxRUT.Location = new System.Drawing.Point(87, 13);
            this.metroTextBoxRUT.MaxLength = 12;
            this.metroTextBoxRUT.Name = "metroTextBoxRUT";
            this.metroTextBoxRUT.PasswordChar = '\0';
            this.metroTextBoxRUT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRUT.SelectedText = "";
            this.metroTextBoxRUT.SelectionLength = 0;
            this.metroTextBoxRUT.SelectionStart = 0;
            this.metroTextBoxRUT.ShortcutsEnabled = true;
            this.metroTextBoxRUT.Size = new System.Drawing.Size(376, 29);
            this.metroTextBoxRUT.TabIndex = 2;
            this.metroTextBoxRUT.UseCustomForeColor = true;
            this.metroTextBoxRUT.UseSelectable = true;
            this.metroTextBoxRUT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRUT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxRUT.Enter += new System.EventHandler(this.metroTextBoxRUT_Enter);
            this.metroTextBoxRUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxRUT_KeyPress);
            this.metroTextBoxRUT.Leave += new System.EventHandler(this.metroTextBoxRUT_Leave);
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(87, 48);
            this.metroTextBoxNombre.MaxLength = 45;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(376, 29);
            this.metroTextBoxNombre.TabIndex = 3;
            this.metroTextBoxNombre.UseCustomForeColor = true;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            this.metroTextBoxNombre.Enter += new System.EventHandler(this.metroTextBoxNombre_Enter);
            this.metroTextBoxNombre.Leave += new System.EventHandler(this.metroTextBoxNombre_Leave);
            // 
            // metroTextBoxApellidos
            // 
            // 
            // 
            // 
            this.metroTextBoxApellidos.CustomButton.Image = null;
            this.metroTextBoxApellidos.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.metroTextBoxApellidos.CustomButton.Name = "";
            this.metroTextBoxApellidos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxApellidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxApellidos.CustomButton.TabIndex = 1;
            this.metroTextBoxApellidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxApellidos.CustomButton.UseSelectable = true;
            this.metroTextBoxApellidos.CustomButton.Visible = false;
            this.metroTextBoxApellidos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxApellidos.Lines = new string[0];
            this.metroTextBoxApellidos.Location = new System.Drawing.Point(87, 83);
            this.metroTextBoxApellidos.MaxLength = 45;
            this.metroTextBoxApellidos.Name = "metroTextBoxApellidos";
            this.metroTextBoxApellidos.PasswordChar = '\0';
            this.metroTextBoxApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxApellidos.SelectedText = "";
            this.metroTextBoxApellidos.SelectionLength = 0;
            this.metroTextBoxApellidos.SelectionStart = 0;
            this.metroTextBoxApellidos.ShortcutsEnabled = true;
            this.metroTextBoxApellidos.Size = new System.Drawing.Size(376, 29);
            this.metroTextBoxApellidos.TabIndex = 4;
            this.metroTextBoxApellidos.UseCustomForeColor = true;
            this.metroTextBoxApellidos.UseSelectable = true;
            this.metroTextBoxApellidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxApellidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxApellidos.TextChanged += new System.EventHandler(this.metroTextBoxApellidos_TextChanged);
            this.metroTextBoxApellidos.Enter += new System.EventHandler(this.metroTextBoxApellidos_Leave);
            this.metroTextBoxApellidos.Leave += new System.EventHandler(this.metroTextBoxApellidos_Leave);
            // 
            // metroLabelNombre
            // 
            this.metroLabelNombre.Location = new System.Drawing.Point(0, 48);
            this.metroLabelNombre.Name = "metroLabelNombre";
            this.metroLabelNombre.Size = new System.Drawing.Size(81, 29);
            this.metroLabelNombre.TabIndex = 5;
            this.metroLabelNombre.Text = "Nombre";
            this.metroLabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelApellidos
            // 
            this.metroLabelApellidos.Location = new System.Drawing.Point(0, 83);
            this.metroLabelApellidos.Name = "metroLabelApellidos";
            this.metroLabelApellidos.Size = new System.Drawing.Size(81, 29);
            this.metroLabelApellidos.TabIndex = 6;
            this.metroLabelApellidos.Text = "Apellidos";
            this.metroLabelApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(474, 313);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTileAccept);
            this.metroTabPage1.Controls.Add(this.metroTileClose1);
            this.metroTabPage1.Controls.Add(this.metroLabelApellidos);
            this.metroTabPage1.Controls.Add(this.metroLabelRUT);
            this.metroTabPage1.Controls.Add(this.metroLabelNombre);
            this.metroTabPage1.Controls.Add(this.metroTextBoxRUT);
            this.metroTabPage1.Controls.Add(this.metroTextBoxApellidos);
            this.metroTabPage1.Controls.Add(this.metroTextBoxNombre);
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
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(388, 193);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 6;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // metroTileClose1
            // 
            this.metroTileClose1.ActiveControl = null;
            this.metroTileClose1.Location = new System.Drawing.Point(3, 193);
            this.metroTileClose1.Name = "metroTileClose1";
            this.metroTileClose1.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose1.TabIndex = 5;
            this.metroTileClose1.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose1.UseSelectable = true;
            this.metroTileClose1.UseTileImage = true;
            this.metroTileClose1.Click += new System.EventHandler(this.metroTileClose1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGridClientes);
            this.metroTabPage2.Controls.Add(this.metroTileEdit);
            this.metroTabPage2.Controls.Add(this.metroTileDelete);
            this.metroTabPage2.Controls.Add(this.metroTileClose2);
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
            // metroGridClientes
            // 
            this.metroGridClientes.AllowUserToAddRows = false;
            this.metroGridClientes.AllowUserToDeleteRows = false;
            this.metroGridClientes.AllowUserToResizeRows = false;
            this.metroGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RUT,
            this.NOMBRE});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridClientes.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridClientes.EnableHeadersVisualStyles = false;
            this.metroGridClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridClientes.Location = new System.Drawing.Point(3, 3);
            this.metroGridClientes.Name = "metroGridClientes";
            this.metroGridClientes.ReadOnly = true;
            this.metroGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridClientes.Size = new System.Drawing.Size(460, 184);
            this.metroGridClientes.TabIndex = 18;
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
            this.metroTileDelete.Click += new System.EventHandler(this.metroTileDelete_Click);
            // 
            // metroTileClose2
            // 
            this.metroTileClose2.ActiveControl = null;
            this.metroTileClose2.Location = new System.Drawing.Point(3, 193);
            this.metroTileClose2.Name = "metroTileClose2";
            this.metroTileClose2.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose2.TabIndex = 7;
            this.metroTileClose2.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose2.UseSelectable = true;
            this.metroTileClose2.UseTileImage = true;
            this.metroTileClose2.Click += new System.EventHandler(this.metroTileClose2_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.Resizable = false;
            this.Text = "Clientes";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelRUT;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRUT;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroTextBox metroTextBoxApellidos;
        private MetroFramework.Controls.MetroLabel metroLabelNombre;
        private MetroFramework.Controls.MetroLabel metroLabelApellidos;
        private MetroFramework.Controls.MetroTile metroTileClose1;
        private MetroFramework.Controls.MetroTile metroTileAccept;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile metroTileClose2;
        private MetroFramework.Controls.MetroTile metroTileDelete;
        private MetroFramework.Controls.MetroGrid metroGridClientes;
        private MetroFramework.Controls.MetroTile metroTileEdit;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn RUT;
        private Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
    }
}