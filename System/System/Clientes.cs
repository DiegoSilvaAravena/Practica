using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;
using MetroFramework;

namespace System
{
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {

        Controllers controllers = new Controllers();

        public Clientes()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Rut = metroTextBox1.Text;
            persona.First_name = metroTextBox2.Text;
            persona.Last_name = metroTextBox3.Text;

            if (controllers.InsertPersona(persona))
            {
                MetroMessageBox.Show(this,"El cliente ha sido ingresado correctamente.","EXITO");
            }
            else
            {
                MetroMessageBox.Show(this, "El cliente no ha sido ingresado correctamente.", "ERROR");
            }

        }
    }
}
