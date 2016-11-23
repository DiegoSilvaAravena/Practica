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
            this.metroTextBoxCodigo.CustomButton.Location = new System.Drawing.Point(348, 1);
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
            this.metroTextBoxCodigo.Size = new System.Drawing.Size(376, 29);
            this.metroTextBoxCodigo.TabIndex = 4;
            this.metroTextBoxCodigo.UseCustomForeColor = true;
            this.metroTextBoxCodigo.UseSelectable = true;
            this.metroTextBoxCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCodigo.Enter += new System.EventHandler(this.metroTextBoxCodigo_Enter);
            this.metroTextBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxCodigo_KeyPress);
            this.metroTextBoxCodigo.Leave += new System.EventHandler(this.metroTextBoxCodigo_Leave);
            // 
            // metroTileClose1
            // 
            this.metroTileClose1.ActiveControl = null;
            this.metroTileClose1.Location = new System.Drawing.Point(29, 301);
            this.metroTileClose1.Name = "metroTileClose1";
            this.metroTileClose1.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose1.TabIndex = 6;
            this.metroTileClose1.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose1.UseSelectable = true;
            this.metroTileClose1.UseTileImage = true;
            this.metroTileClose1.Click += new System.EventHandler(this.metroTileClose1_Click);
            // 
            // metroTileAccept
            // 
            this.metroTileAccept.ActiveControl = null;
            this.metroTileAccept.Location = new System.Drawing.Point(422, 301);
            this.metroTileAccept.Name = "metroTileAccept";
            this.metroTileAccept.Size = new System.Drawing.Size(75, 75);
            this.metroTileAccept.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileAccept.TabIndex = 7;
            this.metroTileAccept.TileImage = global::System.Properties.Resources.check;
            this.metroTileAccept.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAccept.UseSelectable = true;
            this.metroTileAccept.UseTileImage = true;
            this.metroTileAccept.Click += new System.EventHandler(this.metroTileAccept_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.metroTileAccept);
            this.Controls.Add(this.metroTileClose1);
            this.Controls.Add(this.metroLabelCodigo);
            this.Controls.Add(this.metroTextBoxCodigo);
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelCodigo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCodigo;
        private MetroFramework.Controls.MetroTile metroTileClose1;
        private MetroFramework.Controls.MetroTile metroTileAccept;
    }
}