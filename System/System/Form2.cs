using Domain;
using Session;
using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Form2 : Form
    {
        Controllers controllers = new Controllers();

        public class ComboItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() { return Text; }

            public ComboItem(String Text, String Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }


        public Form2()
        {
            InitializeComponent();

            //Combobox
            List<Persona> persona_list = controllers.SelectPersona();
            for (int i = 0; i < persona_list.Count; i++)
            {
                comboBox1.Items.Add(new ComboItem(persona_list[i].Rut, Convert.ToString(persona_list[i].Id_personas)));
            }

            List<Producto> producto_list = controllers.SelectProducto();
            for (int i = 0; i < producto_list.Count; i++)
            {
                comboBox2.Items.Add(new ComboItem(producto_list[i].Codigo.ToString(), producto_list[i].Id_productos.ToString()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboItem items_persona = (ComboItem)comboBox1.SelectedItem;
            int id_personas = Convert.ToInt32(items_persona.Value);
            ComboItem items_producto = (ComboItem)comboBox2.SelectedItem;
            int id_productos = Convert.ToInt32(items_producto.Value);

            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = new DateTime();
            movimiento.Dinero = 0;
            movimiento.Id_personas = id_personas;

            controllers.InsertMovimiento(movimiento);
        }
    }
}
