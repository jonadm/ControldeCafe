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
    public partial class SCM : Form
    {
        public SCM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            this.Hide();
            md.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto pro = new Producto();
            this.Hide();
            pro.Show();
        }
    }
}
