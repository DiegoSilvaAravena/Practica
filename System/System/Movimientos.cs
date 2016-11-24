using Session;
using Domain;
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
using System.Globalization;

namespace System
{
    public partial class Movimientos : MetroForm
    {
        Controllers controllers = new Controllers();

        public Movimientos()
        {
            InitializeComponent();
            metroGridMovimientos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            metroGridMovimientos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Tabla();
            Total();
        }

        private void Tabla()
        {
            List<Movimiento> movimiento_list = controllers.SelectMovimiento();
            metroGridMovimientos.Rows.Clear();
            for (int i = 0; i < movimiento_list.Count; i++)
            {
                metroGridMovimientos.Rows.Insert(metroGridMovimientos.Rows.Count, movimiento_list[i].Id_movimientos, movimiento_list[i].Factura, movimiento_list[i].Fecha,movimiento_list[i].Dinero, controllers.GetRUT(Convert.ToString(movimiento_list[i].Id_personas)),"Ver");
            }
        }

        private void Total()
        {
            int total = 0;

            for (int i = 0; i < metroGridMovimientos.RowCount; i++)
            {
                total = total + Convert.ToInt32(metroGridMovimientos.Rows[i].Cells[3].Value.ToString());
            }

            metroLabelTotal.Text = "$"+Convert.ToString(total);
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
        }

        private void metroTileFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
