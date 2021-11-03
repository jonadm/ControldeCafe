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
    public partial class Producción : Form
    {
        public Producción()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            this.Hide();
            md.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            this.Hide();
            m.Show();
        }

        private void Producción_Load(object sender, EventArgs e)
        {

        }
    }
}
