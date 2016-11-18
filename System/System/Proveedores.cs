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
    public partial class Proveedores : MetroForm
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
        public Proveedores()
        {
            InitializeComponent();
        }
        ////TextBox Focus
        //private void metroTextBoxFactura_Enter(object sender, EventArgs e)
        //{
        //    txtRutProv.ForeColor = Color.Black;
        //}

        //private void metroTextBoxPrecio_Enter(object sender, EventArgs e)
        //{
        //    txtNombreProv.ForeColor = Color.Black;
        //}

        ////TextBox Leave
        //private void metroTextBoxFactura_Leave(object sender, EventArgs e)
        //{
        //    txtRutProv.ForeColor = Color.Gray;
        //}

        //private void metroTextBoxPrecio_Leave(object sender, EventArgs e)
        //{
        //    txtNombreProv.ForeColor = Color.Gray;
        //}


        private void btnIngresarProv_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                if (txtRutProv.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "RUT no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (txtNombreProv.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Nombre no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
            }
            catch
            {

            }

            if (count == 0)
            {
                Persona persona = new Persona();

                persona.Rut = txtRutProv.Text.Trim();
                persona.First_name = txtNombreProv.Text.Trim();
                persona.Tipo = 'P';

                if (controllers.InsertPersona(persona))
                {
                    MetroMessageBox.Show(this, "El proveedor ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {

                    MetroMessageBox.Show(this, "El proveedor no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}