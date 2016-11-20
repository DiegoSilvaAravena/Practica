namespace System
{
    partial class ViewCliente
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
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRUT = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabelApellidos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabelID
            // 
            this.metroLabelID.Location = new System.Drawing.Point(23, 60);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(81, 29);
            this.metroLabelID.TabIndex = 1;
            this.metroLabelID.Text = "ID";
            this.metroLabelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelRUT
            // 
            this.metroLabelRUT.Location = new System.Drawing.Point(23, 89);
            this.metroLabelRUT.Name = "metroLabelRUT";
            this.metroLabelRUT.Size = new System.Drawing.Size(81, 29);
            this.metroLabelRUT.TabIndex = 2;
            this.metroLabelRUT.Text = "RUT";
            this.metroLabelRUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelCNombre
            // 
            this.metroLabelCNombre.Location = new System.Drawing.Point(23, 118);
            this.metroLabelCNombre.Name = "metroLabelCNombre";
            this.metroLabelCNombre.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCNombre.TabIndex = 3;
            this.metroLabelCNombre.Text = "Nombre";
            this.metroLabelCNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelApellidos
            // 
            this.metroLabelApellidos.Location = new System.Drawing.Point(23, 147);
            this.metroLabelApellidos.Name = "metroLabelApellidos";
            this.metroLabelApellidos.Size = new System.Drawing.Size(81, 29);
            this.metroLabelApellidos.TabIndex = 4;
            this.metroLabelApellidos.Text = "Apellidos";
            this.metroLabelApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(110, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 29);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "aa";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(110, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(167, 29);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "aa";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(110, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(167, 29);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "aa";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(110, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(167, 29);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "aa";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelApellidos);
            this.Controls.Add(this.metroLabelCNombre);
            this.Controls.Add(this.metroLabelRUT);
            this.Controls.Add(this.metroLabelID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewCliente";
            this.Resizable = false;
            this.Text = "Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelID;
        private MetroFramework.Controls.MetroLabel metroLabelRUT;
        private MetroFramework.Controls.MetroLabel metroLabelCNombre;
        private MetroFramework.Controls.MetroLabel metroLabelApellidos;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel4;
    }
}