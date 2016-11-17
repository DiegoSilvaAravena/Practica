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
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblRUT = new MetroFramework.Controls.MetroLabel();
            this.txtRutProv = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProv = new MetroFramework.Controls.MetroTextBox();
            this.btnIngresarProv = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(17, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRUT
            // 
            this.lblRUT.AutoSize = true;
            this.lblRUT.Location = new System.Drawing.Point(44, 92);
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
            this.txtRutProv.Location = new System.Drawing.Point(83, 88);
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
            this.txtNombreProv.Location = new System.Drawing.Point(83, 126);
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
            // 
            // btnIngresarProv
            // 
            this.btnIngresarProv.Location = new System.Drawing.Point(276, 202);
            this.btnIngresarProv.Name = "btnIngresarProv";
            this.btnIngresarProv.Size = new System.Drawing.Size(107, 30);
            this.btnIngresarProv.TabIndex = 4;
            this.btnIngresarProv.Text = "Ingresar";
            this.btnIngresarProv.UseSelectable = true;
            this.btnIngresarProv.Click += new System.EventHandler(this.btnIngresarProv_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 267);
            this.Controls.Add(this.btnIngresarProv);
            this.Controls.Add(this.txtNombreProv);
            this.Controls.Add(this.txtRutProv);
            this.Controls.Add(this.lblRUT);
            this.Controls.Add(this.lblNombre);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblRUT;
        private MetroFramework.Controls.MetroTextBox txtRutProv;
        private MetroFramework.Controls.MetroTextBox txtNombreProv;
        private MetroFramework.Controls.MetroButton btnIngresarProv;
    }
}