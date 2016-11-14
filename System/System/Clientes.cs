using Session;
using Domain;
using MetroFramework;
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

namespace System
{
    public partial class Clientes : MetroForm
    {
        Controllers controllers = new Controllers();

        public string FormatoRUT(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public Clientes()
        {
            InitializeComponent();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TextBox Focus
        private void metroTextBoxFactura_Enter(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Black;
        }

        private void metroTextBoxPrecio_Enter(object sender, EventArgs e)
        {
            metroTextBoxNombre.ForeColor = Color.Black;
        }

        private void metroTextBoxCantidad_Enter(object sender, EventArgs e)
        {
            metroTextBoxApellidos.ForeColor = Color.Black;
        }
        //TextBox Leave
        private void metroTextBoxFactura_Leave(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Gray;
        }

        private void metroTextBoxPrecio_Leave(object sender, EventArgs e)
        {
            metroTextBoxNombre.ForeColor = Color.Gray;
        }

        private void metroTextBoxCantidad_Leave(object sender, EventArgs e)
        {
            metroTextBoxApellidos.ForeColor = Color.Gray;
        }

        private void metroTileAccept_Click(object sender, EventArgs e)
        {
            int count = 0;

            //Validaciones
            try
            {
                if (metroTextBoxRUT.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "RUT no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxNombre.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Nombre no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxApellidos.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Apellidos no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
            }
            catch
            {

            }

            //Acción
            if (count == 0)
            {
                Persona persona = new Persona();

                persona.Rut = metroTextBoxRUT.Text.Trim();
                persona.First_name = metroTextBoxNombre.Text.Trim();
                persona.Last_name = metroTextBoxApellidos.Text.Trim();
                persona.Tipo = 'C';

                if (controllers.InsertPersona(persona))
                {
                    MetroMessageBox.Show(this, "El cliente ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {

                    MetroMessageBox.Show(this, "El cliente no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Formato
        private void metroTextBoxRUT_Leave(object sender, EventArgs e)
        {
            metroTextBoxRUT.Text = FormatoRUT(metroTextBoxRUT.Text);
        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            metroTextBoxNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metroTextBoxNombre.Text);
            metroTextBoxNombre.SelectionStart = metroTextBoxNombre.Text.Length;
        }

        private void metroTextBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            metroTextBoxApellidos.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metroTextBoxApellidos.Text);
            metroTextBoxApellidos.SelectionStart = metroTextBoxApellidos.Text.Length;
        }
    }
}
