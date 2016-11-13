using Domain;
using MetroFramework;
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
    public partial class Ventas : MetroFramework.Forms.MetroForm
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

        public Ventas()
        {
            InitializeComponent();
            //ComboBox
            List<Persona> persona_list = controllers.SelectPersona();
            for (int i = 0; i < persona_list.Count; i++)
            {
                metroComboBoxCliente.Items.Add(new ComboItem(persona_list[i].Rut, Convert.ToString(persona_list[i].Id_personas)));
            }
            List<Producto> producto_list = controllers.SelectProducto();
            for (int i = 0; i < producto_list.Count; i++)
            {
                metroComboBoxProducto.Items.Add(new ComboItem(producto_list[i].Codigo.ToString(), producto_list[i].Id_productos.ToString()));
            }

        }

        private void metroButtonAñadir_Click(object sender, EventArgs e)
        {
            //Validaciones
            int count = 0;
            ComboItem items_producto = (ComboItem)metroComboBoxProducto.SelectedItem;
            try
            {
                if (metroTextBoxCantidad.Text.Equals("") || Convert.ToInt32(metroTextBoxCantidad.Text) == 0)
                {
                    MetroMessageBox.Show(this, "Cantidad no válido.", "Advertencia");
                    count++;
                    return;
                }

                for (int i = 0; i < metroGridProductos.Rows.Count; i++)
                {
                    if (metroGridProductos.Rows[i].Cells[0].Value.ToString().Equals(items_producto.Value))
                    {
                        MetroMessageBox.Show(this, "El producto ya esta en la lista.", "Advertencia");
                        count++;
                        return;
                    }
                }

                
            }
            catch
            {

            }

            if (count == 0)
            {
                
                int id_productos = Convert.ToInt32(items_producto.Value);
                int codigo = Convert.ToInt32(items_producto.Text);
                int cantidad = Convert.ToInt32(metroTextBoxCantidad.Text);

                metroGridProductos.Rows.Insert(0, id_productos, codigo, cantidad);
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Validaciones

            int count = 0;

            try
            {
                if (metroComboBoxCliente.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Cliente no válido.\nSeleccione un cliente de la lista.", "Advertencia");
                    count++;
                    return;
                }
                if (metroTextBoxFactura.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Factura no válida.", "Advertencia");
                    count++;
                    return;
                }
                if (metroTextBoxPrecio.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Precio no válida.", "Advertencia");
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

            }
            
        }

        private void metroTextBoxFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia");
                e.Handled = true;
                return;
            }
        }

        private void metroTextBoxVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia");
                e.Handled = true;
                return;
            }
        }

        private void metroButtonLimpiar_Click(object sender, EventArgs e)
        {
            metroGridProductos.Rows.Clear();
        }
    }
}
