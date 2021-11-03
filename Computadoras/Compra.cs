using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadoras
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor pr = new Proveedor();
            this.Hide();
            pr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_Compras co = new T_Compras();
            this.Hide();
            co.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            this.Hide();
            md.Show();
        }
    }
}
