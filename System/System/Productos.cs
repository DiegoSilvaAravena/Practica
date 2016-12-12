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

                producto.Codigo = metroTextBoxCodigo.Text.Trim().ToUpper();
                producto.Cantidad = Convert.ToInt32(metroTextBoxCantidad.Text);
                producto.Estado ='A';

                if (controllers.InsertProducto(producto))
                {
                    //Limpieza de formulario
                    metroTextBoxCodigo.Clear();
                    metroTextBoxCantidad.Text = "0";

                    MetroMessageBox.Show(this, "El producto ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El producto no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTextBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void metroTextBoxCantidad_Click(object sender, EventArgs e)
        {
            metroTextBoxCantidad.SelectionStart = 0;
            metroTextBoxCantidad.SelectionLength = metroTextBoxCantidad.Text.Length;
        }
    }
}
