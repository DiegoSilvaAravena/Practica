using Domain;
using MetroFramework;
using MetroFramework.Forms;
using Session;
using System;
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
    public partial class Compras : MetroForm
    {
        Controllers controllers = new Controllers();

        public class ComboItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() { return Text; }

            public ComboItem(string Text, string Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }
        public Compras()
        {
            InitializeComponent();
            //ComboBox
            List<Persona> persona_list = controllers.SelectPersona();
            for (int i = 0; i < persona_list.Count; i++)
            {
                cboProveedor.Items.Add(new ComboItem(persona_list[i].Rut + " | " + persona_list[i].First_name + " " + persona_list[i].Last_name, Convert.ToString(persona_list[i].Id_personas)));
            }
            List<Producto> producto_list = controllers.SelectProducto();
            for (int i = 0; i < producto_list.Count; i++)
            {
                if (persona_list[i].Tipo == 'P')
                {
                    cboProveedor.Items.Add(new ComboItem(persona_list[i].Rut + " | " + persona_list[i].First_name + " " + persona_list[i].Last_name, Convert.ToString(persona_list[i].Id_personas)));
                }
            }

        }

    }
}