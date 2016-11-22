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
                return format.ToUpper();
            }
        }

        public Clientes()
        {
            InitializeComponent();
            metroTabControl1.SelectedIndex = 0;
            Tabla();
            
        }
        //Llenar tabla de clientes
        public void Tabla()
        {
            List<Persona> persona_list = controllers.SelectPersona();
            metroGridClientes.Rows.Clear();
            for (int i = 0; i < persona_list.Count; i++)
            {
                if (persona_list[i].Tipo=='C' && persona_list[i].Estado != 'E')
                {
                    metroGridClientes.Rows.Insert(metroGridClientes.Rows.Count, persona_list[i].Id_personas, persona_list[i].Rut, persona_list[i].First_name + " " + persona_list[i].Last_name);
                }        
            }
        }
 
        //TextBox Focus
        private void metroTextBoxRUT_Enter(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Black;
        }

        private void metroTextBoxNombre_Enter(object sender, EventArgs e)
        {
            metroTextBoxNombre.ForeColor = Color.Black;
        }

        private void metroTextBoxApellidos_Enter(object sender, EventArgs e)
        {
            metroTextBoxApellidos.ForeColor = Color.Black;
        }
        //TextBox Leave
        private void metroTextBoxRUT_Leave(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Gray;
            metroTextBoxRUT.Text = FormatoRUT(metroTextBoxRUT.Text);
        }

        private void metroTextBoxNombre_Leave(object sender, EventArgs e)
        {
            metroTextBoxNombre.ForeColor = Color.Gray;
        }

        private void metroTextBoxApellidos_Leave(object sender, EventArgs e)
        {
            metroTextBoxApellidos.ForeColor = Color.Gray;
        }

        //Botones

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
            if (count == 0)
            {
                Persona persona = new Persona();

                persona.Rut = metroTextBoxRUT.Text.Trim();
                persona.First_name = metroTextBoxNombre.Text.Trim();
                persona.Last_name = metroTextBoxApellidos.Text.Trim();
                persona.Tipo = 'C';
                persona.Estado = 'A';

                if (controllers.InsertPersona(persona))
                {
                    //Limpieza de formulario
                    metroTextBoxRUT.Clear();
                    metroTextBoxNombre.Clear();
                    metroTextBoxApellidos.Clear();
                    Tabla();

                    MetroMessageBox.Show(this, "El cliente ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El cliente no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTileDelete_Click(object sender, EventArgs e)
        {
            int id_personas = Convert.ToInt32(metroGridClientes.Rows[metroGridClientes.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el cliente seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteCliente(id_personas))
                {
                    metroGridClientes.Rows.RemoveAt(this.metroGridClientes.SelectedRows[0].Index);
                    MetroMessageBox.Show(this, "El cliente ha sido eliminado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El cliente no ha sido eliminado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTileEdit_Click(object sender, EventArgs e)
        {
            EditCliente winEditCliente = new EditCliente();
            winEditCliente.WinClientes = this;

            Persona persona = controllers.GetPersonaID(metroGridClientes.Rows[metroGridClientes.SelectedRows[0].Index].Cells[0].Value.ToString());

            winEditCliente.metroLabelID2.Text = Convert.ToString(persona.Id_personas);
            winEditCliente.metroTextBoxRUT.Text = persona.Rut;
            winEditCliente.metroTextBoxNombre.Text = persona.First_name;
            winEditCliente.metroTextBoxApellidos.Text = persona.Last_name;

            winEditCliente.ShowDialog();
        }

        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTileClose2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Formato
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

        //Bloqueo de RUT
        private void metroTextBoxRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == 'K' || e.KeyChar == 'k' || e.KeyChar == '.' || e.KeyChar == '-')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
