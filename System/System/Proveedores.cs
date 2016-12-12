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
        public void Tabla()
        {
            List<Persona> persona_list = controllers.SelectPersona();
            metroGridProveedores.Rows.Clear();
            for (int i = 0; i < persona_list.Count; i++)
            {
                if (persona_list[i].Tipo == 'P' && persona_list[i].Estado != 'E')
                {
                    metroGridProveedores.Rows.Insert(metroGridProveedores.Rows.Count, persona_list[i].Id_personas, persona_list[i].Rut, persona_list[i].First_name + " " + persona_list[i].Last_name,persona_list[i].Correo, persona_list[i].Numero_cuenta, persona_list[i].Banco);
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
                if (metroTextBoxRUT.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "RUT no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxRUT.Text.Length > 12)
                {
                    MetroMessageBox.Show(this, "RUT no válido.\n El RUT tiene más de 12 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxRUT.Text.Length < 11)
                {
                    MetroMessageBox.Show(this, "RUT no válido.\n El RUT tiene menos de 11 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxNombre1.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Nombre no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroTextBoxNumero.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Número no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    count++;
                    return;
                }
                if (metroComboBoxBanco.SelectedIndex==-1)
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
            if (count == 0)
            {
                Persona persona = new Persona();

                persona.Rut = metroTextBoxRUT.Text.Trim();
                persona.First_name = metroTextBoxNombre1.Text.Trim();
                persona.Tipo = 'P';
                persona.Estado = 'A';
                persona.Correo = metroTextBoxCorreo.Text.Trim().ToLower();
                persona.Numero_cuenta = metroTextBoxNumero.Text;
                persona.Banco = metroComboBoxBanco.SelectedItem.ToString();

                if (controllers.InsertPersona(persona))
                {
                    metroTextBoxRUT.Clear();
                    metroTextBoxNombre1.Clear();
                    metroTextBoxCorreo.Clear();
                    metroTextBoxNumero.Clear();
                    metroComboBoxBanco.SelectedIndex=-1;
                    Tabla();

                    MetroMessageBox.Show(this, "El proveedor ha sido ingresado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                }
                else
                {
                    MetroMessageBox.Show(this, "El proveedor no ha sido ingresado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void metroTileDelete_Click(object sender, EventArgs e)
        {
            int id_personas = Convert.ToInt32(metroGridProveedores.Rows[metroGridProveedores.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el proveedor seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteCliente(id_personas))
                {
                    metroGridProveedores.Rows.RemoveAt(this.metroGridProveedores.SelectedRows[0].Index);
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
            EditProveedor winEditProveedor = new EditProveedor();
            winEditProveedor.WinProveedor = this;

            Persona persona = controllers.GetPersonaID(metroGridProveedores.Rows[metroGridProveedores.SelectedRows[0].Index].Cells[0].Value.ToString());

            winEditProveedor.metroLabelID2.Text = Convert.ToString(persona.Id_personas);
            winEditProveedor.metroTextBoxRUT.Text = persona.Rut;
            winEditProveedor.metroTextBoxNombre.Text = persona.First_name;
            winEditProveedor.metroTextBoxCorreo.Text = persona.Correo;
            winEditProveedor.metroTextBoxCuenta.Text = persona.Numero_cuenta;
            winEditProveedor.metroComboBoxBanco.SelectedItem = persona.Banco;

            winEditProveedor.ShowDialog();
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
            metroTextBoxNombre1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metroTextBoxNombre1.Text);
            metroTextBoxNombre1.SelectionStart = metroTextBoxNombre1.Text.Length;
        }


        //Bloqueo de RUT
        private void txtRutProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)
                || (e.KeyChar == 'K'
                || e.KeyChar == 'k'
                || e.KeyChar == '.'
                || e.KeyChar == '-')) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        //txt Enter y Leave
        private void txtRutProv_Enter(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Black;
        }
        private void txtRutProv_Leave(object sender, EventArgs e)
        {
            metroTextBoxRUT.ForeColor = Color.Gray;
            metroTextBoxRUT.Text = FormatoRUT(metroTextBoxRUT.Text);
        }

        private void txtNombreProv_Enter(object sender, EventArgs e)
        {
            metroTextBoxNombre1.ForeColor = Color.Black;
        }
        private void txtNombreProv_Leave(object sender, EventArgs e)
        {
            metroTextBoxNombre1.ForeColor = Color.Gray;
        }
        

        private void metroTileDelete_Click_1(object sender, EventArgs e)
        {
            int id_personas = Convert.ToInt32(metroGridProveedores.Rows[metroGridProveedores.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el proveedor "+ metroGridProveedores.Rows[metroGridProveedores.SelectedRows[0].Index].Cells[2].Value.ToString() + "?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteCliente(id_personas))
                {
                    metroGridProveedores.Rows.RemoveAt(this.metroGridProveedores.SelectedRows[0].Index);
                    MetroMessageBox.Show(this, "El proveedor ha sido eliminado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El proveedor no ha sido eliminado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (!metroTextBoxNombre2.Text.Equals(""))
            {
                List<Persona> persona_list = controllers.SelectPersona();
                metroGridProveedores.Rows.Clear();
                for (int i = 0; i < persona_list.Count; i++)   
                {
                    string nom = persona_list[i].First_name + " " + persona_list[i].Last_name;

                    if (persona_list[i].Tipo == 'P' && nom.ToLower().Contains(metroTextBoxNombre2.Text.ToLower()) && persona_list[i].Estado != 'E')
                    {
                        metroGridProveedores.Rows.Insert(metroGridProveedores.Rows.Count, persona_list[i].Id_personas, persona_list[i].Rut, persona_list[i].First_name + " " + persona_list[i].Last_name);
                    }

                }
            }
            else
            {
                Tabla();
            }
        }

        private void metroTextBoxNombre2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButtonFiltrar_Click(this, new EventArgs());
            }
        }

        private void metroTextBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void metroTextBoxCorreo_Enter(object sender, EventArgs e)
        {
            metroTextBoxCorreo.ForeColor = Color.Black;
        }

        private void metroTextBoxCorreo_Leave(object sender, EventArgs e)
        {
            metroTextBoxCorreo.ForeColor = Color.Gray;
        }

        private void metroTextBoxNumero_Enter(object sender, EventArgs e)
        {
            metroTextBoxNumero.ForeColor = Color.Black;
        }

        private void metroTextBoxNumero_Leave(object sender, EventArgs e)
        {
            metroTextBoxNumero.ForeColor = Color.Gray;
        }
    }
}