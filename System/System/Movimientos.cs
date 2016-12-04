using Session;
using Domain;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using System.Drawing;

namespace System
{
    public partial class Movimientos : MetroForm
    {
        Controllers controllers = new Controllers();

        public Movimientos()
        {
            InitializeComponent();
            metroGridMovimientos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            metroDateTimeDesde.CustomFormat = "dd/MM/yyyy";
            metroGridMovimientos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Tabla();
            Total();
        }

        private void Tabla()
        {
            List<Movimiento> movimiento_list = controllers.SelectMovimientoConRUT();
            metroGridMovimientos.Rows.Clear();
            for (int i = 0; i < movimiento_list.Count; i++)
            {
                metroGridMovimientos.Rows.Insert(metroGridMovimientos.Rows.Count, movimiento_list[i].Id_movimientos, movimiento_list[i].Factura, movimiento_list[i].Fecha, movimiento_list[i].Dinero, movimiento_list[i].Rut_personas, "Ver");
                if (movimiento_list[i].Dinero <= 0)
                {
                    metroGridMovimientos.Rows[metroGridMovimientos.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Red;

                }
                else
                {
                    metroGridMovimientos.Rows[metroGridMovimientos.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Green;
                }
            }
        }

        private void TablaFiltroFecha()
        {
            List<Movimiento> movimiento_list = controllers.SelectMovimientoConRUT();
            metroGridMovimientos.Rows.Clear();
            for (int i = 0; i < movimiento_list.Count; i++)
            {
                if (Convert.ToDateTime(movimiento_list[i].Fecha.ToString("MMMM dd, yyyy")) >= Convert.ToDateTime(metroDateTimeDesde.Value.ToString("MMMM dd, yyyy")) && Convert.ToDateTime(movimiento_list[i].Fecha.ToString("MMMM dd, yyyy")) <= Convert.ToDateTime(metroDateTimeHasta.Value.ToString("MMMM dd, yyyy")))
                {
                    metroGridMovimientos.Rows.Insert(metroGridMovimientos.Rows.Count, movimiento_list[i].Id_movimientos, movimiento_list[i].Factura, movimiento_list[i].Fecha, movimiento_list[i].Dinero, movimiento_list[i].Rut_personas, "Ver");
                    if (movimiento_list[i].Dinero <= 0)
                    {
                        metroGridMovimientos.Rows[metroGridMovimientos.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        metroGridMovimientos.Rows[metroGridMovimientos.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void Total()
        {
            int total = 0;
            int ingresos = 0;
            int egresos = 0;

            for (int i = 0; i < metroGridMovimientos.RowCount; i++)
            {
                total = total + Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString());
                if (Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString()) > 0)
                {
                    ingresos = ingresos + Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString());
                }

                if (Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString()) < 0)
                {
                    egresos = egresos + Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString());
                }
            }

            
            if (total <= 0)
            {
                metroLabelTotal.ForeColor = Color.Red;
            }
            else{
                metroLabelTotal.ForeColor = Color.Green;
            }
            if (ingresos <= 0)
            {
                metroLabelIngresos.ForeColor = Color.Red;
            }
            else
            {
                metroLabelIngresos.ForeColor = Color.Green;
            }
            if (egresos <= 0)
            {
                metroLabelEgresos.ForeColor = Color.Red;
            }
            else
            {
                metroLabelEgresos.ForeColor = Color.Green;
            }
            metroLabelTotal.Text = "$" + Convert.ToString(total);
            metroLabelIngresos.Text = "$" + Convert.ToString(ingresos);
            metroLabelEgresos.Text = "$" + Convert.ToString(egresos);
        }

        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroGridMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                ViewCliente winViewCliente = new ViewCliente();

                Persona persona = controllers.GetPersonaRUT(metroGridMovimientos.Rows[e.RowIndex].Cells[4].Value.ToString());

                winViewCliente.metroLabel1.Text = Convert.ToString(persona.Id_personas);
                winViewCliente.metroLabel2.Text = persona.Rut;
                winViewCliente.metroLabel3.Text = persona.First_name;
                winViewCliente.metroLabel4.Text = persona.Last_name;
                winViewCliente.ShowDialog();
            }

            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                ViewProducto winViewProducto = new ViewProducto();

                List<Producto> movimiento_producto_list = controllers.SelectMovimientos_Productos(Convert.ToInt32(metroGridMovimientos.Rows[e.RowIndex].Cells[0].Value.ToString()));

                for (int i = 0; i < movimiento_producto_list.Count; i++)
                {
                    winViewProducto.metroGridProductos.Rows.Insert(winViewProducto.metroGridProductos.Rows.Count, movimiento_producto_list[i].Id_productos, movimiento_producto_list[i].Codigo, movimiento_producto_list[i].Cantidad);
                }

                winViewProducto.ShowDialog();
            }
        }

        private void metroTileFiltro_Click(object sender, EventArgs e)
        {
            if (metroToggleFecha.Checked == true)
            {
                TablaFiltroFecha();
            }
            else
            {
                Tabla();
            }

            Total();
        }

        private void metroDateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            if (metroDateTimeDesde.Value > metroDateTimeHasta.Value)
            {
                metroDateTimeHasta.Value = metroDateTimeDesde.Value;
            }
        }

        private void metroTileDelete_Click(object sender, EventArgs e)
        {
            int id_movimientos = Convert.ToInt32(metroGridMovimientos.Rows[metroGridMovimientos.SelectedRows[0].Index].Cells[0].Value.ToString());

            if (MetroMessageBox.Show(this, "¿Está seguro de que desea eliminar el movimiento seleccionado?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controllers.DeleteMovimiento(id_movimientos))
                {
                    metroGridMovimientos.Rows.RemoveAt(this.metroGridMovimientos.SelectedRows[0].Index);
                    MetroMessageBox.Show(this, "El cliente ha sido eliminado correctamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MetroMessageBox.Show(this, "El cliente no ha sido eliminado correctamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
