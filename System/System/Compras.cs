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
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }
    }
}
