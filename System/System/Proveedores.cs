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
                return format.ToUpper();
            }
        }

        public Proveedores()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
            Tabla();

        }
        private void Tabla()
        {
            List<Persona> persona_list = controllers.SelectPersona();
            metroGridProv.Rows.Clear();
            for (int i = 0; i < persona_list.Count; i++)
            {
                if (persona_list[i].Tipo == 'P')
                {
                    metroGridProv.Rows.Insert(metroGridProv.Rows.Count, persona_list[i].Id_personas, persona_list[i].Rut, persona_list[i].First_name + " " + persona_list[i].Last_name);
                }
              
            }
        }


        //Botones

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            int count = 0;

            //Validaciones
            try
            {
                if (txtRutProv.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "RUT no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (txtRutProv.Text.Length < 12)
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

            //Acción
            if (count == 0)
            {
                Persona persona = new Persona();

                persona.Rut = txtRutProv.Text.Trim();
                persona.First_name = txtNombreProv.Text.Trim();
                persona.Tipo = 'P';
                persona.Estado = 'A';

                if (controllers.InsertPersona(persona))
                {
                    MetroMessageBox.Show(this, "El proveedor ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Tabla();
                }
                else
                {
                    MetroMessageBox.Show(this, "El proveedor no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void metroTileDelete_Click(object sender, EventArgs e)
        {
            int id_personas = Convert.ToInt32(metroGridProv.Rows[metroGridProv.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el proveedor seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteCliente(id_personas))
                {
                    metroGridProv.Rows.RemoveAt(this.metroGridProv.SelectedRows[0].Index);
                    MetroMessageBox.Show(this, "El proveedor ha sido eliminado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El proveedor no ha sido eliminado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTileEdit_Click(object sender, EventArgs e)
        {

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrarLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Formato
        private void txtNombreProv_TextChanged(object sender, EventArgs e)
        {
            txtNombreProv.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreProv.Text);
            txtNombreProv.SelectionStart = txtNombreProv.Text.Length;
        }


        //Bloqueo de RUT
        private void txtRutProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == 'K' || e.KeyChar == 'k' || e.KeyChar == '.' || e.KeyChar == '-')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRutProv_Enter(object sender, EventArgs e)
        {
            txtRutProv.ForeColor = Color.Black;
        }
        private void txtRutProv_Leave(object sender, EventArgs e)
        {
            txtRutProv.ForeColor = Color.Gray;
            txtRutProv.Text = FormatoRUT(txtRutProv.Text);
        }

        private void txtNombreProv_Enter(object sender, EventArgs e)
        {
            txtNombreProv.ForeColor = Color.Black;
        }
        private void txtNombreProv_Leave(object sender, EventArgs e)
        {
            txtNombreProv.ForeColor = Color.Gray;
        }
    }
}
