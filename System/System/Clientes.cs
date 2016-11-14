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

        public Clientes()
        {
            InitializeComponent();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                persona.Rut = metroTextBoxRUT.Text;
                persona.First_name = metroTextBoxNombre.Text;
                persona.Last_name = metroTextBoxApellidos.Text;
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
    }
}
