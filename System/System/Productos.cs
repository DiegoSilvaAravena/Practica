using Domain;
using MetroFramework;
using MetroFramework.Forms;
using Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Productos : MetroForm
    {
        Controllers controllers = new Controllers();

        public Productos()
        {
            InitializeComponent();
        }

        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTextBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        //TextBox Focus
        private void metroTextBoxCodigo_Enter(object sender, EventArgs e)
        {
            metroTextBoxCodigo.ForeColor = Color.Black;
        }

        //TextBox Leave
        private void metroTextBoxCodigo_Leave(object sender, EventArgs e)
        {
            metroTextBoxCodigo.ForeColor = Color.Gray;
        }


        private void metroTileAccept_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (count == 0)
            {
                Producto producto = new Producto();

                producto.Codigo = Convert.ToInt32(metroTextBoxCodigo.Text.Trim());
                producto.Cantidad = 0;
                producto.Estado ='A';

                if (controllers.InsertProducto(producto))
                {
                    //Limpieza de formulario
                    metroTextBoxCodigo.Clear();

                    MetroMessageBox.Show(this, "El producto ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El producto no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
