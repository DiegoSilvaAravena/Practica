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
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void metroTileClientes_Click(object sender, EventArgs e)
        {
            Clientes winClientes = new Clientes();
            winClientes.ShowDialog();
        }

        private void metroTileProveedores_Click(object sender, EventArgs e)
        {
            Proveedores winProveedores = new Proveedores();
            winProveedores.ShowDialog();
        }

        private void metroTileVentas_Click(object sender, EventArgs e)
        {
            Ventas winVentas = new Ventas();
            winVentas.ShowDialog();
        }

        private void metroTileCompras_Click(object sender, EventArgs e)
        {
            Compras winCompras = new Compras();
            winCompras.ShowDialog();
        }

        private void metroTileMovimientos_Click(object sender, EventArgs e)
        {
            Movimientos winMovimientos = new Movimientos();
            winMovimientos.ShowDialog();
        }

        private void metroTileOpciones_Click(object sender, EventArgs e)
        {

        }

        private void metroTileProductos_Click(object sender, EventArgs e)
        {
            Productos winProductos = new Productos();
            winProductos.ShowDialog();
        }
    }
}
