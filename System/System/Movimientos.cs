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

namespace System
{
    public partial class Movimientos : MetroForm
    {
        Controllers controllers = new Controllers();

        public Movimientos()
        {
            InitializeComponent();
            Tabla();
        }
        //Llenar tabla
        private void Tabla()
        {
            List<Movimiento> movimiento_list = controllers.SelectMovimiento();
            metroGridMovimientos.Rows.Clear();
            for (int i = 0; i < movimiento_list.Count; i++)
            {
                metroGridMovimientos.Rows.Insert(metroGridMovimientos.Rows.Count, movimiento_list[i].Id_movimientos, movimiento_list[i].Factura, movimiento_list[i].Fecha,movimiento_list[i].Dinero, controllers.GetRUT(movimiento_list[i].Id_personas),"Ver");
            }
        }

        private void metroTileClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
