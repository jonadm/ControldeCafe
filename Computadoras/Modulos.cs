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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRHH r = new RRHH();
            this.Hide();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            this.Hide();
            inv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producción pr = new Producción();
            this.Hide();
            pr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compra co = new Compra();
            this.Hide();
            co.Show();
        }


        private void Modulos_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SCM scm = new SCM();
            this.Hide();
            scm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
