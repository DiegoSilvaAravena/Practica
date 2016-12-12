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
    public partial class EditProveedor : MetroForm
    {
        Controllers controllers = new Controllers();
        Proveedores winProveedor;
        public EditProveedor()
        {
            InitializeComponent();
        }

        public Proveedores WinProveedor
        {
            get
            {
                return winProveedor;
            }

            set
            {
                winProveedor = value;
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
                if (metroTextBoxCuenta.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Número no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroComboBoxBanco.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Seleccione un banco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }


            }
            catch
            {

            }

            //Acción
            if (MetroMessageBox.Show(this, "¿Está seguro de que desea editar el proveedor seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (count == 0)
                {
                    Persona persona = new Persona();

                    persona.Id_personas = Convert.ToInt32(metroLabelID2.Text);
                    persona.Rut = metroTextBoxRUT.Text.Trim();
                    persona.First_name = metroTextBoxNombre.Text.Trim();
                    persona.Tipo = 'P';
                    persona.Estado = 'A';
                    persona.Correo = metroTextBoxCorreo.Text.Trim().ToLower();
                    persona.Numero_cuenta = metroTextBoxCuenta.Text;
                    persona.Banco = metroComboBoxBanco.SelectedItem.ToString();

                    if (controllers.UpdatePersona(persona))
                    {
                        MetroMessageBox.Show(this, "El proveedor ha sido actualizado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        winProveedor.metroGridProveedores.Rows.Clear();
                        winProveedor.Tabla();
                        this.Dispose();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El proveedor no ha sido actualizado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
