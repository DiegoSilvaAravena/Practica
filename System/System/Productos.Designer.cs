namespace System
{
    partial class Productos
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
            this.metroLabelCodigo = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroTileClose1 = new MetroFramework.Controls.MetroTile();
            this.metroTileAccept = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroLabelCantidad = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCantidad = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabelCodigo
            // 
            this.metroLabelCodigo.Location = new System.Drawing.Point(23, 60);
            this.metroLabelCodigo.Name = "metroLabelCodigo";
            this.metroLabelCodigo.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCodigo.TabIndex = 3;
            this.metroLabelCodigo.Text = "Codigo";
            this.metroLabelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxCodigo
            // 
            // 
            // 
            // 
            this.metroTextBoxCodigo.CustomButton.Image = null;
            this.metroTextBoxCodigo.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.metroTextBoxCodigo.CustomButton.Name = "";
            this.metroTextBoxCodigo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCodigo.CustomButton.TabIndex = 1;
            this.metroTextBoxCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCodigo.CustomButton.UseSelectable = true;
            this.metroTextBoxCodigo.CustomButton.Visible = false;
            this.metroTextBoxCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCodigo.Lines = new string[0];
            this.metroTextBoxCodigo.Location = new System.Drawing.Point(110, 60);
            this.metroTextBoxCodigo.MaxLength = 12;
            this.metroTextBoxCodigo.Name = "metroTextBoxCodigo";
            this.metroTextBoxCodigo.PasswordChar = '\0';
            this.metroTextBoxCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCodigo.SelectedText = "";
            this.metroTextBoxCodigo.SelectionLength = 0;
            this.metroTextBoxCodigo.SelectionStart = 0;
            this.metroTextBoxCodigo.ShortcutsEnabled = true;
            this.metroTextBoxCodigo.Size = new System.Drawing.Size(387, 29);
            this.metroTextBoxCodigo.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.metroTextBoxCodigo, "Ingrese código del producto");
            this.metroTextBoxCodigo.UseCustomForeColor = true;
            this.metroTextBoxCodigo.UseSelectable = true;
            this.metroTextBoxCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCodigo.Enter += new System.EventHandler(this.metroTextBoxCodigo_Enter);
            this.metroTextBoxCodigo.Leave += new System.EventHandler(this.metroTextBoxCodigo_Leave);
            // 
            // metroTileClose1
            // 
            this.metroTileClose1.ActiveControl = null;
            this.metroTileClose1.Location = new System.Drawing.Point(23, 141);
            this.metroTileClose1.Name = "metroTileClose1";
            this.metroTileClose1.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose1.TabIndex = 3;
            this.metroTileClose1.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileClose1, "Volver");
            this.metroTileClose1.UseSelectable = true;
            this.metroTileClose1.UseTileImage = true;
            this.metroTileClose1.Click += new System.EventHandler(this.metroTileClose1_Click);
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(422, 141);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 4;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileAccept, "Ingresar");
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabelCantidad
            // 
            this.metroLabelCantidad.Location = new System.Drawing.Point(23, 95);
            this.metroLabelCantidad.Name = "metroLabelCantidad";
            this.metroLabelCantidad.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCantidad.TabIndex = 8;
            this.metroLabelCantidad.Text = "Cantidad";
            this.metroLabelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTextBoxCantidad
            // 
            // 
            // 
            // 
            this.metroTextBoxCantidad.CustomButton.Image = null;
            this.metroTextBoxCantidad.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.metroTextBoxCantidad.CustomButton.Name = "";
            this.metroTextBoxCantidad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCantidad.CustomButton.TabIndex = 1;
            this.metroTextBoxCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCantidad.CustomButton.UseSelectable = true;
            this.metroTextBoxCantidad.CustomButton.Visible = false;
            this.metroTextBoxCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCantidad.Lines = new string[] {
        "0"};
            this.metroTextBoxCantidad.Location = new System.Drawing.Point(110, 95);
            this.metroTextBoxCantidad.MaxLength = 5;
            this.metroTextBoxCantidad.Name = "metroTextBoxCantidad";
            this.metroTextBoxCantidad.PasswordChar = '\0';
            this.metroTextBoxCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCantidad.SelectedText = "";
            this.metroTextBoxCantidad.SelectionLength = 0;
            this.metroTextBoxCantidad.SelectionStart = 0;
            this.metroTextBoxCantidad.ShortcutsEnabled = true;
            this.metroTextBoxCantidad.Size = new System.Drawing.Size(387, 29);
            this.metroTextBoxCantidad.TabIndex = 2;
            this.metroTextBoxCantidad.Text = "0";
            this.metroToolTip1.SetToolTip(this.metroTextBoxCantidad, "Ingrese código del producto");
            this.metroTextBoxCantidad.UseCustomForeColor = true;
            this.metroTextBoxCantidad.UseSelectable = true;
            this.metroTextBoxCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCantidad.Click += new System.EventHandler(this.metroTextBoxCantidad_Click);
            this.metroTextBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxCantidad_KeyPress);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 239);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabelCantidad);
            this.Controls.Add(this.metroTextBoxCantidad);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTileClose1);
            this.Controls.Add(this.metroLabelCodigo);
            this.Controls.Add(this.metroTextBoxCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Resizable = false;
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelCodigo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCodigo;
        private MetroFramework.Controls.MetroTile metroTileClose1;
        private MetroFramework.Controls.MetroTile metroTileAccept;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabelCantidad;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCantidad;
    }
}