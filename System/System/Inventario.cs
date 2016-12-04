using Domain;
using Session;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;

namespace System
{
    public partial class Inventario : MetroForm
    {
        Controllers controllers = new Controllers();
        public Inventario()
        {
            InitializeComponent();
            Tabla();
        }

        public void Tabla()
        {
            List<Producto> producto_list = controllers.SelectProducto();
            metroGridProductos.Rows.Clear();
            for (int i = 0; i < producto_list.Count; i++)
            {
                if (producto_list[i].Estado != 'E')
                {
                    metroGridProductos.Rows.Insert(metroGridProductos.Rows.Count, producto_list[i].Id_productos, producto_list[i].Codigo, producto_list[i].Cantidad);
                    if (producto_list[i].Cantidad < 1)
                    {
                        metroGridProductos.Rows[metroGridProductos.Rows.Count - 1].Cells[2].Style.ForeColor = Color.Red;
                    }
                }
                
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileDelete = new MetroFramework.Controls.MetroTile();
            this.metroTileClose2 = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridProductos
            // 
            this.metroGridProductos.AllowUserToAddRows = false;
            this.metroGridProductos.AllowUserToDeleteRows = false;
            this.metroGridProductos.AllowUserToResizeRows = false;
            this.metroGridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CÓDIGO,
            this.CANTIDAD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(23, 63);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.ReadOnly = true;
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(474, 232);
            this.metroGridProductos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CÓDIGO.HeaderText = "CODIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // metroTileDelete
            // 
            this.metroTileDelete.ActiveControl = null;
            this.metroTileDelete.Location = new System.Drawing.Point(422, 301);
            this.metroTileDelete.Name = "metroTileDelete";
            this.metroTileDelete.Size = new System.Drawing.Size(75, 75);
            this.metroTileDelete.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileDelete.TabIndex = 11;
            this.metroTileDelete.TileImage = global::System.Properties.Resources.times;
            this.metroTileDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileDelete, "Eliminar producto seleccionado");
            this.metroTileDelete.UseSelectable = true;
            this.metroTileDelete.UseTileImage = true;
            this.metroTileDelete.Click += new System.EventHandler(this.metroTileDelete_Click);
            // 
            // metroTileClose2
            // 
            this.metroTileClose2.ActiveControl = null;
            this.metroTileClose2.Location = new System.Drawing.Point(23, 301);
            this.metroTileClose2.Name = "metroTileClose2";
            this.metroTileClose2.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose2.TabIndex = 10;
            this.metroTileClose2.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileClose2, "Volver");
            this.metroTileClose2.UseSelectable = true;
            this.metroTileClose2.UseTileImage = true;
            this.metroTileClose2.Click += new System.EventHandler(this.metroTileClose2_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.ControlBox = false;
            this.Controls.Add(this.metroTileDelete);
            this.Controls.Add(this.metroTileClose2);
            this.Controls.Add(this.metroGridProductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventario";
            this.Resizable = false;
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        private void metroTileClose2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTileDelete_Click(object sender, EventArgs e)
        {
            int id_productos = Convert.ToInt32(metroGridProductos.Rows[metroGridProductos.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el producto "+ metroGridProductos.Rows[metroGridProductos.SelectedRows[0].Index].Cells[1].Value.ToString() + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteProducto(id_productos))
                {
                    metroGridProductos.Rows.RemoveAt(this.metroGridProductos.SelectedRows[0].Index);
                    MetroMessageBox.Show(this, "El producto se ha sido eliminado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El producto no ha sido eliminado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
