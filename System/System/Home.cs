﻿using MetroFramework.Forms;
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

        private void metroTileVentas_Click(object sender, EventArgs e)
        {
            Ventas winVentas = new Ventas();
            winVentas.ShowDialog();
        }

    }
}
