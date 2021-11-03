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
    public partial class RRHH : Form
    {
        public RRHH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TPersona t = new TPersona();
            this.Hide();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            this.Hide();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado();
            this.Hide();
            em.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            this.Hide();
            md.Show();
        }

        private void RRHH_Load(object sender, EventArgs e)
        {

        }
    }
}
