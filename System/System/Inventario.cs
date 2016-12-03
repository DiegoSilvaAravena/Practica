using Domain;
using Session;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                }
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridProductos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTileDelete = new MetroFramework.Controls.MetroTile();
            this.metroTileClose2 = new MetroFramework.Controls.MetroTile();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CÓDIGO,
            this.CANTIDAD});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridProductos.EnableHeadersVisualStyles = false;
            this.metroGridProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridProductos.Location = new System.Drawing.Point(23, 63);
            this.metroGridProductos.Name = "metroGridProductos";
            this.metroGridProductos.ReadOnly = true;
            this.metroGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridProductos.Size = new System.Drawing.Size(347, 205);
            this.metroGridProductos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.HeaderText = "CODIGO";
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // metroTileDelete
            // 
            this.metroTileDelete.ActiveControl = null;
            this.metroTileDelete.Location = new System.Drawing.Point(295, 274);
            this.metroTileDelete.Name = "metroTileDelete";
            this.metroTileDelete.Size = new System.Drawing.Size(75, 75);
            this.metroTileDelete.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileDelete.TabIndex = 11;
            this.metroTileDelete.TileImage = global::System.Properties.Resources.times;
            this.metroTileDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDelete.UseSelectable = true;
            this.metroTileDelete.UseTileImage = true;
            this.metroTileDelete.Click += new System.EventHandler(this.metroTileDelete_Click);
            // 
            // metroTileClose2
            // 
            this.metroTileClose2.ActiveControl = null;
            this.metroTileClose2.Location = new System.Drawing.Point(23, 274);
            this.metroTileClose2.Name = "metroTileClose2";
            this.metroTileClose2.Size = new System.Drawing.Size(75, 75);
            this.metroTileClose2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTileClose2.TabIndex = 10;
            this.metroTileClose2.TileImage = global::System.Properties.Resources.chevron_left;
            this.metroTileClose2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClose2.UseSelectable = true;
            this.metroTileClose2.UseTileImage = true;
            this.metroTileClose2.Click += new System.EventHandler(this.metroTileClose2_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 372);
            this.Controls.Add(this.metroTileDelete);
            this.Controls.Add(this.metroTileClose2);
            this.Controls.Add(this.metroGridProductos);
            this.Name = "Inventario";
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
