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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabelNombre1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRUT = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRUT = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNombre1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNumero = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBanco = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxBanco = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelCorreo = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarProv = new MetroFramework.Controls.MetroTile();
            this.btnCerrar = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonFiltrar = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxNombre2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNombre2 = new MetroFramework.Controls.MetroLabel();
            this.metroGridProveedores = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileEdit = new MetroFramework.Controls.MetroTile();
            this.metroTileDelete = new MetroFramework.Controls.MetroTile();
            this.btnCerrarLista = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelNombre1
            // 
            this.metroLabelNombre1.Location = new System.Drawing.Point(192, 79);
            this.metroLabelNombre1.Name = "metroLabelNombre1";
            this.metroLabelNombre1.Size = new System.Drawing.Size(81, 29);
            this.metroLabelNombre1.TabIndex = 0;
            this.metroLabelNombre1.Text = "Nombre";
            this.metroLabelNombre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelRUT
            // 
            this.metroLabelRUT.Location = new System.Drawing.Point(192, 44);
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
            this.metroTextBoxRUT.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.metroTextBoxRUT.CustomButton.Name = "";
            this.metroTextBoxRUT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxRUT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRUT.CustomButton.TabIndex = 1;
            this.metroTextBoxRUT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRUT.CustomButton.UseSelectable = true;
            this.metroTextBoxRUT.CustomButton.Visible = false;
            this.metroTextBoxRUT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxRUT.Lines = new string[0];
            this.metroTextBoxRUT.Location = new System.Drawing.Point(279, 44);
            this.metroTextBoxRUT.MaxLength = 12;
            this.metroTextBoxRUT.Name = "metroTextBoxRUT";
            this.metroTextBoxRUT.PasswordChar = '\0';
            this.metroTextBoxRUT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRUT.SelectedText = "";
            this.metroTextBoxRUT.SelectionLength = 0;
            this.metroTextBoxRUT.SelectionStart = 0;
            this.metroTextBoxRUT.ShortcutsEnabled = true;
            this.metroTextBoxRUT.Size = new System.Drawing.Size(280, 29);
            this.metroTextBoxRUT.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.metroTextBoxRUT, "Ingrese el RUT del proveedor");
            this.metroTextBoxRUT.UseCustomForeColor = true;
            this.metroTextBoxRUT.UseSelectable = true;
            this.metroTextBoxRUT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRUT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxRUT.Enter += new System.EventHandler(this.txtRutProv_Enter);
            this.metroTextBoxRUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutProv_KeyPress);
            this.metroTextBoxRUT.Leave += new System.EventHandler(this.txtRutProv_Leave);
            // 
            // metroTextBoxNombre1
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre1.CustomButton.Image = null;
            this.metroTextBoxNombre1.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.metroTextBoxNombre1.CustomButton.Name = "";
            this.metroTextBoxNombre1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxNombre1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre1.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre1.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre1.CustomButton.Visible = false;
            this.metroTextBoxNombre1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxNombre1.Lines = new string[0];
            this.metroTextBoxNombre1.Location = new System.Drawing.Point(279, 79);
            this.metroTextBoxNombre1.MaxLength = 32767;
            this.metroTextBoxNombre1.Name = "metroTextBoxNombre1";
            this.metroTextBoxNombre1.PasswordChar = '\0';
            this.metroTextBoxNombre1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre1.SelectedText = "";
            this.metroTextBoxNombre1.SelectionLength = 0;
            this.metroTextBoxNombre1.SelectionStart = 0;
            this.metroTextBoxNombre1.ShortcutsEnabled = true;
            this.metroTextBoxNombre1.Size = new System.Drawing.Size(280, 29);
            this.metroTextBoxNombre1.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.metroTextBoxNombre1, "Ingrese el nombre del proveedor");
            this.metroTextBoxNombre1.UseCustomForeColor = true;
            this.metroTextBoxNombre1.UseSelectable = true;
            this.metroTextBoxNombre1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre1.TextChanged += new System.EventHandler(this.txtNombreProv_TextChanged);
            this.metroTextBoxNombre1.Enter += new System.EventHandler(this.txtNombreProv_Enter);
            this.metroTextBoxNombre1.Leave += new System.EventHandler(this.txtNombreProv_Leave);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(804, 376);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroTextBoxNumero);
            this.metroTabPage1.Controls.Add(this.metroLabelNumero);
            this.metroTabPage1.Controls.Add(this.metroLabelBanco);
            this.metroTabPage1.Controls.Add(this.metroComboBoxBanco);
            this.metroTabPage1.Controls.Add(this.metroTextBoxCorreo);
            this.metroTabPage1.Controls.Add(this.metroLabelCorreo);
            this.metroTabPage1.Controls.Add(this.btnAgregarProv);
            this.metroTabPage1.Controls.Add(this.btnCerrar);
            this.metroTabPage1.Controls.Add(this.metroTextBoxRUT);
            this.metroTabPage1.Controls.Add(this.metroTextBoxNombre1);
            this.metroTabPage1.Controls.Add(this.metroLabelNombre1);
            this.metroTabPage1.Controls.Add(this.metroLabelRUT);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(796, 334);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Nuevo";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(192, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(460, 29);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Datos de la cuenta";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(192, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(460, 29);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Información del proveedor";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTextBoxNumero
            // 
            // 
            // 
            // 
            this.metroTextBoxNumero.CustomButton.Image = null;
            this.metroTextBoxNumero.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.metroTextBoxNumero.CustomButton.Name = "";
            this.metroTextBoxNumero.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNumero.CustomButton.TabIndex = 1;
            this.metroTextBoxNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNumero.CustomButton.UseSelectable = true;
            this.metroTextBoxNumero.CustomButton.Visible = false;
            this.metroTextBoxNumero.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxNumero.Lines = new string[0];
            this.metroTextBoxNumero.Location = new System.Drawing.Point(279, 178);
            this.metroTextBoxNumero.MaxLength = 50;
            this.metroTextBoxNumero.Name = "metroTextBoxNumero";
            this.metroTextBoxNumero.PasswordChar = '\0';
            this.metroTextBoxNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNumero.SelectedText = "";
            this.metroTextBoxNumero.SelectionLength = 0;
            this.metroTextBoxNumero.SelectionStart = 0;
            this.metroTextBoxNumero.ShortcutsEnabled = true;
            this.metroTextBoxNumero.Size = new System.Drawing.Size(280, 29);
            this.metroTextBoxNumero.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.metroTextBoxNumero, "Ingrese el RUT del proveedor");
            this.metroTextBoxNumero.UseCustomForeColor = true;
            this.metroTextBoxNumero.UseSelectable = true;
            this.metroTextBoxNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNumero.Enter += new System.EventHandler(this.metroTextBoxNumero_Enter);
            this.metroTextBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxNumero_KeyPress);
            this.metroTextBoxNumero.Leave += new System.EventHandler(this.metroTextBoxNumero_Leave);
            // 
            // metroLabelNumero
            // 
            this.metroLabelNumero.Location = new System.Drawing.Point(192, 178);
            this.metroLabelNumero.Name = "metroLabelNumero";
            this.metroLabelNumero.Size = new System.Drawing.Size(81, 29);
            this.metroLabelNumero.TabIndex = 21;
            this.metroLabelNumero.Text = "Número";
            this.metroLabelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabelBanco
            // 
            this.metroLabelBanco.Location = new System.Drawing.Point(192, 213);
            this.metroLabelBanco.Name = "metroLabelBanco";
            this.metroLabelBanco.Size = new System.Drawing.Size(81, 29);
            this.metroLabelBanco.TabIndex = 20;
            this.metroLabelBanco.Text = "Banco";
            this.metroLabelBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroComboBoxBanco
            // 
            this.metroComboBoxBanco.FormattingEnabled = true;
            this.metroComboBoxBanco.ItemHeight = 23;
            this.metroComboBoxBanco.Items.AddRange(new object[] {
            "BancoEstado",
            "Banco de Chile",
            "Banco Internacional",
            "Scotibank",
            "CorpBanca",
            "BICE",
            "HSBC Chile",
            "Banco Santander",
            "Banco Itau",
            "Banco Security",
            "Banco Falabella",
            "Banco Ripley",
            "Banco Consorcio",
            "Banco Paris",
            "Banco BBVA",
            "COOPEUCH"});
            this.metroComboBoxBanco.Location = new System.Drawing.Point(279, 213);
            this.metroComboBoxBanco.Name = "metroComboBoxBanco";
            this.metroComboBoxBanco.Size = new System.Drawing.Size(280, 29);
            this.metroComboBoxBanco.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.metroComboBoxBanco, "Seleccione el proveedor");
            this.metroComboBoxBanco.UseSelectable = true;
            // 
            // metroTextBoxCorreo
            // 
            // 
            // 
            // 
            this.metroTextBoxCorreo.CustomButton.Image = null;
            this.metroTextBoxCorreo.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.metroTextBoxCorreo.CustomButton.Name = "";
            this.metroTextBoxCorreo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCorreo.CustomButton.TabIndex = 1;
            this.metroTextBoxCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCorreo.CustomButton.UseSelectable = true;
            this.metroTextBoxCorreo.CustomButton.Visible = false;
            this.metroTextBoxCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCorreo.Lines = new string[0];
            this.metroTextBoxCorreo.Location = new System.Drawing.Point(279, 114);
            this.metroTextBoxCorreo.MaxLength = 32767;
            this.metroTextBoxCorreo.Name = "metroTextBoxCorreo";
            this.metroTextBoxCorreo.PasswordChar = '\0';
            this.metroTextBoxCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCorreo.SelectedText = "";
            this.metroTextBoxCorreo.SelectionLength = 0;
            this.metroTextBoxCorreo.SelectionStart = 0;
            this.metroTextBoxCorreo.ShortcutsEnabled = true;
            this.metroTextBoxCorreo.Size = new System.Drawing.Size(280, 29);
            this.metroTextBoxCorreo.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.metroTextBoxCorreo, "Ingrese el nombre del proveedor");
            this.metroTextBoxCorreo.UseCustomForeColor = true;
            this.metroTextBoxCorreo.UseSelectable = true;
            this.metroTextBoxCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCorreo.Enter += new System.EventHandler(this.metroTextBoxCorreo_Enter);
            this.metroTextBoxCorreo.Leave += new System.EventHandler(this.metroTextBoxCorreo_Leave);
            // 
            // metroLabelCorreo
            // 
            this.metroLabelCorreo.Location = new System.Drawing.Point(192, 114);
            this.metroLabelCorreo.Name = "metroLabelCorreo";
            this.metroLabelCorreo.Size = new System.Drawing.Size(81, 29);
            this.metroLabelCorreo.TabIndex = 9;
            this.metroLabelCorreo.Text = "Correo";
            this.metroLabelCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.ActiveControl = null;
            this.btnAgregarProv.Location = new System.Drawing.Point(718, 256);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(75, 75);
            this.btnAgregarProv.Style = MetroFramework.MetroColorStyle.White;
            this.btnAgregarProv.TabIndex = 8;
            this.btnAgregarProv.TileImage = global::System.Properties.Resources.check;
            this.btnAgregarProv.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.btnAgregarProv, "Ingresar");
            this.btnAgregarProv.UseSelectable = true;
            this.btnAgregarProv.UseTileImage = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveControl = null;
            this.btnCerrar.Location = new System.Drawing.Point(3, 256);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 75);
            this.btnCerrar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TileImage = global::System.Properties.Resources.chevron_left;
            this.btnCerrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.btnCerrar, "Volver");
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.UseTileImage = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonFiltrar);
            this.metroTabPage2.Controls.Add(this.metroTextBoxNombre2);
            this.metroTabPage2.Controls.Add(this.metroLabelNombre2);
            this.metroTabPage2.Controls.Add(this.metroGridProveedores);
            this.metroTabPage2.Controls.Add(this.metroTileEdit);
            this.metroTabPage2.Controls.Add(this.metroTileDelete);
            this.metroTabPage2.Controls.Add(this.btnCerrarLista);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(796, 334);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Lista";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButtonFiltrar
            // 
            this.metroButtonFiltrar.Location = new System.Drawing.Point(718, 10);
            this.metroButtonFiltrar.Name = "metroButtonFiltrar";
            this.metroButtonFiltrar.Size = new System.Drawing.Size(75, 29);
            this.metroButtonFiltrar.TabIndex = 20;
            this.metroButtonFiltrar.Text = "Buscar";
            this.metroButtonFiltrar.UseSelectable = true;
            this.metroButtonFiltrar.Click += new System.EventHandler(this.metroButtonFiltrar_Click);
            // 
            // metroTextBoxNombre2
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre2.CustomButton.Image = null;
            this.metroTextBoxNombre2.CustomButton.Location = new System.Drawing.Point(594, 1);
            this.metroTextBoxNombre2.CustomButton.Name = "";
            this.metroTextBoxNombre2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxNombre2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre2.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre2.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre2.CustomButton.Visible = false;
            this.metroTextBoxNombre2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxNombre2.Lines = new string[0];
            this.metroTextBoxNombre2.Location = new System.Drawing.Point(90, 10);
            this.metroTextBoxNombre2.MaxLength = 12;
            this.metroTextBoxNombre2.Name = "metroTextBoxNombre2";
            this.metroTextBoxNombre2.PasswordChar = '\0';
            this.metroTextBoxNombre2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre2.SelectedText = "";
            this.metroTextBoxNombre2.SelectionLength = 0;
            this.metroTextBoxNombre2.SelectionStart = 0;
            this.metroTextBoxNombre2.ShortcutsEnabled = true;
            this.metroTextBoxNombre2.Size = new System.Drawing.Size(622, 29);
            this.metroTextBoxNombre2.TabIndex = 11;
            this.metroToolTip1.SetToolTip(this.metroTextBoxNombre2, "Ingrese el nombre del proveedor");
            this.metroTextBoxNombre2.UseCustomForeColor = true;
            this.metroTextBoxNombre2.UseSelectable = true;
            this.metroTextBoxNombre2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBoxNombre2_KeyDown);
            // 
            // metroLabelNombre2
            // 
            this.metroLabelNombre2.Location = new System.Drawing.Point(3, 10);
            this.metroLabelNombre2.Name = "metroLabelNombre2";
            this.metroLabelNombre2.Size = new System.Drawing.Size(81, 29);
            this.metroLabelNombre2.TabIndex = 10;
            this.metroLabelNombre2.Text = "Nombre";
            this.metroLabelNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroGridProveedores
            // 
            this.metroGridProveedores.AllowUserToAddRows = false;
            this.metroGridProveedores.AllowUserToDeleteRows = false;
            this.metroGridProveedores.AllowUserToResizeRows = false;
            this.metroGridProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RUT,
            this.NOMBRE,
            this.CORREO,
            this.NCUENTA,
            this.BANCO});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProveedores.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGridProveedores.EnableHeadersVisualStyles = false;
            this.metroGridProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProveedores.Location = new System.Drawing.Point(3, 45);
            this.metroGridProveedores.Name = "metroGridProveedores";
            this.metroGridProveedores.ReadOnly = true;
            this.metroGridProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGridProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProveedores.Size = new System.Drawing.Size(790, 205);
            this.metroGridProveedores.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOMBRE.HeaderText = "NOMBRE COMPLETO";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 124;
            // 
            // CORREO
            // 
            this.CORREO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            this.CORREO.ReadOnly = true;
            this.CORREO.Width = 75;
            // 
            // NCUENTA
            // 
            this.NCUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NCUENTA.HeaderText = "NÚMERO DE CUENTA";
            this.NCUENTA.Name = "NCUENTA";
            this.NCUENTA.ReadOnly = true;
            this.NCUENTA.Width = 90;
            // 
            // BANCO
            // 
            this.BANCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            this.BANCO.ReadOnly = true;
            // 
            // metroTileEdit
            // 
            this.metroTileEdit.ActiveControl = null;
            this.metroTileEdit.Location = new System.Drawing.Point(644, 256);
            this.metroTileEdit.Name = "metroTileEdit";
            this.metroTileEdit.Size = new System.Drawing.Size(75, 75);
            this.metroTileEdit.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileEdit.TabIndex = 8;
            this.metroTileEdit.TileImage = global::System.Properties.Resources.pencil;
            this.metroTileEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileEdit, "Editar proveedor seleccionado");
            this.metroTileEdit.UseSelectable = true;
            this.metroTileEdit.UseTileImage = true;
            this.metroTileEdit.Click += new System.EventHandler(this.metroTileEdit_Click);
            // 
            // metroTileDelete
            // 
            this.metroTileDelete.ActiveControl = null;
            this.metroTileDelete.Location = new System.Drawing.Point(725, 256);
            this.metroTileDelete.Name = "metroTileDelete";
            this.metroTileDelete.Size = new System.Drawing.Size(75, 75);
            this.metroTileDelete.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileDelete.TabIndex = 9;
            this.metroTileDelete.TileImage = global::System.Properties.Resources.times;
            this.metroTileDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileDelete, "Eliminar proveedor seleccionado");
            this.metroTileDelete.UseSelectable = true;
            this.metroTileDelete.UseTileImage = true;
            this.metroTileDelete.Click += new System.EventHandler(this.metroTileDelete_Click_1);
            // 
            // btnCerrarLista
            // 
            this.btnCerrarLista.ActiveControl = null;
            this.btnCerrarLista.Location = new System.Drawing.Point(3, 256);
            this.btnCerrarLista.Name = "btnCerrarLista";
            this.btnCerrarLista.Size = new System.Drawing.Size(75, 75);
            this.btnCerrarLista.Style = MetroFramework.MetroColorStyle.White;
            this.btnCerrarLista.TabIndex = 7;
            this.btnCerrarLista.TileImage = global::System.Properties.Resources.chevron_left;
            this.btnCerrarLista.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.btnCerrarLista, "Volver");
            this.btnCerrarLista.UseSelectable = true;
            this.btnCerrarLista.UseTileImage = true;
            this.btnCerrarLista.Click += new System.EventHandler(this.btnCerrarLista_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 462);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proveedores";
            this.Resizable = false;
            this.Text = "Proveedores";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProveedores)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelNombre1;
        private MetroFramework.Controls.MetroLabel metroLabelRUT;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRUT;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre1;
        private MetroFramework.Controls.MetroTile btnAgregarProv;
        private MetroFramework.Controls.MetroTile btnCerrar;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile metroTileEdit;
        private MetroFramework.Controls.MetroTile metroTileDelete;
        private MetroFramework.Controls.MetroTile btnCerrarLista;
        public MetroFramework.Controls.MetroGrid metroGridProveedores;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre2;
        private MetroFramework.Controls.MetroLabel metroLabelNombre2;
        private MetroFramework.Controls.MetroButton metroButtonFiltrar;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCorreo;
        private MetroFramework.Controls.MetroLabel metroLabelCorreo;
        private MetroFramework.Controls.MetroLabel metroLabelBanco;
        private MetroFramework.Controls.MetroComboBox metroComboBoxBanco;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNumero;
        private MetroFramework.Controls.MetroLabel metroLabelNumero;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Windows.Forms.DataGridViewTextBoxColumn ID;
        private Windows.Forms.DataGridViewTextBoxColumn RUT;
        private Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private Windows.Forms.DataGridViewTextBoxColumn NCUENTA;
        private Windows.Forms.DataGridViewTextBoxColumn BANCO;
    }
}