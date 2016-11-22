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
    public partial class EditCliente : MetroForm
    {
        Controllers controllers = new Controllers();
        Clientes winClientes;
        public EditCliente()
        {
            InitializeComponent();
        }

        public Clientes WinClientes
        {
            get
            {
                return winClientes;
            }

            set
            {
                winClientes = value;
            }
        }

        private void metroTileClose2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTileEdit_Click(object sender, EventArgs e)
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
                if (metroTextBoxRUT.Text.Length < 11)
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
            if (MetroMessageBox.Show(this, "¿Está seguro de que desea editar el cliente seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (count == 0)
                {
                    Persona persona = new Persona();

                    persona.Id_personas = Convert.ToInt32(metroLabelID2.Text);
                    persona.Rut = metroTextBoxRUT.Text.Trim();
                    persona.First_name = metroTextBoxNombre.Text.Trim();
                    persona.Last_name = metroTextBoxApellidos.Text.Trim();
                    persona.Tipo = 'C';
                    persona.Estado = 'A';

                    if (controllers.UpdatePersona(persona))
                    {
                        MetroMessageBox.Show(this, "El cliente ha sido actualizado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        winClientes.metroGridClientes.Rows.Clear();
                        winClientes.Tabla();
                        this.Dispose();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El cliente no ha sido actualizado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
