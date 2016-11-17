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
    public partial class Ventas : MetroForm
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
                if (persona_list[i].Tipo == 'C')
                {
                    metroComboBoxCliente.Items.Add(new ComboItem(persona_list[i].Rut + " | " + persona_list[i].First_name + " " + persona_list[i].Last_name, Convert.ToString(persona_list[i].Id_personas)));
                }
                
            }
            List<Producto> producto_list = controllers.SelectProducto();
            for (int i = 0; i < producto_list.Count; i++)
            {
                metroComboBoxProducto.Items.Add(new ComboItem(producto_list[i].Codigo.ToString(), producto_list[i].Id_productos.ToString()));
            }

        }

        private void metroTextBoxFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        //TextBox Focus
        private void metroTextBoxFactura_Enter(object sender, EventArgs e)
        {
        metroTextBoxFactura.ForeColor = Color.Black;
        }

        private void metroTextBoxPrecio_Enter(object sender, EventArgs e)
        {
            metroTextBoxPrecio.ForeColor = Color.Black;
        }

        private void metroTextBoxCantidad_Enter(object sender, EventArgs e)
        {
            metroTextBoxCantidad.ForeColor = Color.Black;
        }
        //TextBox Leave
        private void metroTextBoxFactura_Leave(object sender, EventArgs e)
        {
        metroTextBoxFactura.ForeColor = Color.Gray;
        }

        private void metroTextBoxPrecio_Leave(object sender, EventArgs e)
        {
            metroTextBoxPrecio.ForeColor = Color.Gray;
        }

        private void metroTextBoxCantidad_Leave(object sender, EventArgs e)
        {
            metroTextBoxCantidad.ForeColor = Color.Gray;
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            //Validaciones
            int count = 0;
            ComboItem items_producto = (ComboItem)metroComboBoxProducto.SelectedItem;
            try
            {
                if (metroTextBoxCantidad.Text.Equals("") || Convert.ToInt32(metroTextBoxCantidad.Text) == 0)
                {
                    MetroMessageBox.Show(this, "Cantidad no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }

                for (int i = 0; i < metroGridProductos.Rows.Count; i++)
                {
                    if (metroGridProductos.Rows[i].Cells[0].Value.ToString().Equals(items_producto.Value))
                    {
                        MetroMessageBox.Show(this, "El producto ya esta en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroGridProductos.Rows.Clear();
        }

        private void metroTileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTileAccept_Click(object sender, EventArgs e)
        {
            //Validaciones

            int count = 0;

            try
            {
                if (metroComboBoxCliente.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Cliente no válido.\nSeleccione un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (metroTextBoxFactura.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Factura no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (metroTextBoxPrecio.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Precio no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (metroComboBoxProducto.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Producto no válido.\nSeleccione un producto de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (metroTextBoxCantidad.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Cantidad no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ComboItem selected_cliente = (ComboItem) metroComboBoxCliente.SelectedItem;

                Movimiento movimiento = new Movimiento();

                movimiento.Factura = Convert.ToInt32(metroTextBoxFactura.Text);
                movimiento.Fecha = metroDateTimeFecha.Value;
                movimiento.Dinero = Convert.ToSingle(metroTextBoxPrecio.Text);
                movimiento.Id_personas = Convert.ToInt32(selected_cliente.Value);

                if (controllers.InsertMovimiento(movimiento))
                {
                    MetroMessageBox.Show(this, "La venta ha sido ingresada correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {

                    MetroMessageBox.Show(this, "La venta no ha sido ingresada correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Botones
        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroDateTimeFecha_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeFecha.Show();
        }
    }
}
