﻿using Domain;
using MetroFramework;
using MetroFramework.Forms;
using Session;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
            public string Codigo { get; set; }
            public int Cantidad { get; set; }
            public override string ToString() { return Text; }

            public ComboItem(String Text, String Value)
            {
                this.Text = Text;
                this.Value = Value;
            }

            public ComboItem(String Text, String Value, string Codigo, int Cantidad)
            {
                this.Text = Text;
                this.Value = Value;
                this.Codigo = Codigo;
                this.Cantidad = Cantidad;
            }
        }
        public Compras()
        {
            InitializeComponent();
            LlenarCombo();
            //ComboBox
            List<Persona> persona_list = controllers.SelectPersona();
            for (int i = 0; i < persona_list.Count; i++)
            {
                if (persona_list[i].Tipo == 'P' && persona_list[i].Estado != 'E')
                {
                    cboProveedor.Items.Add(new ComboItem(persona_list[i].First_name + " | " + persona_list[i].Rut , Convert.ToString(persona_list[i].Id_personas)));
                }

            }

        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public void LlenarCombo()
        {
            List<Producto> producto_list = controllers.SelectProducto();
            for (int i = 0; i < producto_list.Count; i++)
            {
                if (producto_list[i].Estado != 'E')
                {
                    cboProducto.Items.Add(new ComboItem(Convert.ToString(producto_list[i].Codigo + " | Stock: " + producto_list[i].Cantidad), Convert.ToString(producto_list[i].Id_productos), producto_list[i].Codigo, producto_list[i].Cantidad));
                }

            }
        }

        //TextBox Focus
        private void txtFacturaFactura_Enter(object sender, EventArgs e)
        {
            txtFactura.ForeColor = Color.Black;
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            txtPrecio.ForeColor = Color.Black;
        }
        private void txtPrecioFlete_Enter(object sender, EventArgs e)
        {
            txtPrecioFlete.ForeColor = Color.Black;
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.ForeColor = Color.Black;
        }
        //TextBox Leave
        private void txtFactura_Leave(object sender, EventArgs e)
        {
            txtFactura.ForeColor = Color.Gray;
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            txtPrecio.ForeColor = Color.Gray;
        }
        private void txtPrecioFlete_Leave(object sender, EventArgs e)
        {
            txtPrecioFlete.ForeColor = Color.Gray;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtCantidad.ForeColor = Color.Gray;
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            //Validaciones
            int count = 0;
            ComboItem items_producto = (ComboItem)cboProducto.SelectedItem;
            try
            {
                if (cboProducto.SelectedIndex == -1)
                {
                    count++;
                    return;
                }

                if (txtCantidad.Text.Equals("") || Convert.ToInt32(txtCantidad.Text) == 0)
                {
                    MetroMessageBox.Show(this, "Cantidad no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }


                for (int i = 0; i < GVProductos.Rows.Count; i++)
                {
                    if (GVProductos.Rows[i].Cells[0].Value.ToString().Equals(items_producto.Value))
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
                string codigo = items_producto.Codigo;
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                GVProductos.Rows.Insert(0, id_productos, codigo, cantidad);
            }
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            GVProductos.Rows.Clear();
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
                if (cboProveedor.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Cliente no válido.\nSeleccione un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (txtFactura.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Factura no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (txtPrecio.Text.Equals(""))
                {
                    MetroMessageBox.Show(this, "Precio no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (cboProducto.SelectedIndex == -1)
                {
                    MetroMessageBox.Show(this, "Producto no válido.\nSeleccione un producto de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count++;
                    return;
                }
                if (txtCantidad.Text.Equals(""))
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
                ComboItem selected_proveedor = (ComboItem)cboProveedor.SelectedItem;

                Movimiento movimiento = new Movimiento();
                ArrayList producto_list = new ArrayList();
                ArrayList producto_cantidad = new ArrayList();

                movimiento.Factura = Convert.ToInt32(txtFactura.Text);
                movimiento.Fecha = metroDateTimeFecha.Value;
                movimiento.Dinero = (Convert.ToSingle(txtPrecio.Text) + Convert.ToSingle(txtPrecioFlete.Text)) * -1;
                movimiento.Id_personas = Convert.ToInt32(selected_proveedor.Value);

                for (int i = 0; i < GVProductos.Rows.Count; i++)
                {
                    producto_list.Add(GVProductos.Rows[i].Cells[0].Value.ToString());
                    producto_cantidad.Add(GVProductos.Rows[i].Cells[2].Value.ToString());
                }
                if (MetroMessageBox.Show(this, "¿Está seguro de que desea ingresar la siguiente compra?\nProveedor: " + selected_proveedor.Text + "\nFecha: " + metroDateTimeFecha.Value+ "\nN° Factura: " + txtFactura.Text + "\nPrecio: $" + ((Convert.ToSingle(txtPrecio.Text) + Convert.ToSingle(txtPrecioFlete.Text))), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (controllers.InsertMovimiento(movimiento))
                    {
                        controllers.InsertMasMovimiento_Productos(producto_list, producto_cantidad);
                        //Limpieza de formulario
                        cboProveedor.SelectedIndex = -1;
                        //metroDateTimeFecha.Value = new DateTime();
                        txtFactura.Clear();
                        txtPrecio.Clear();
                        txtPrecioFlete.Clear();
                        cboProducto.SelectedIndex = -1;
                        GVProductos.Rows.Clear();
                        txtCantidad.Text = "1";
                        txtPrecioFlete.Text = "0";
                        cboProducto.Items.Clear();
                        LlenarCombo();

                        MetroMessageBox.Show(this, "La compra ha sido ingresada correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "La compra no ha sido ingresada correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Botones
        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarLista_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrecioFlete_Click(object sender, EventArgs e)
        {
            txtPrecioFlete.SelectionStart = 0;
            txtPrecioFlete.SelectionLength = txtPrecioFlete.Text.Length;
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.SelectionStart = 0;
            txtCantidad.SelectionLength = txtCantidad.Text.Length;
        }
    }
}