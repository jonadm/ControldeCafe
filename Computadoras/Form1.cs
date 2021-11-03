using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computadoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

        public void logear(String nomb_usuario, String contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * From usuario where nomb_usuario=@nomb_usuario AND contraseña=@contraseña", con);
                cmd.Parameters.AddWithValue("nomb_usuario", nomb_usuario);
                cmd.Parameters.AddWithValue("contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Modulos Abrir = new Modulos();
                    this.Hide();
                    Abrir.Show();
                }
                else 
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                logear(this.txtusu.Text, this.txtpas.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
  