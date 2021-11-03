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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SCM scm = new SCM();
            this.Hide();
            scm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from producto", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvproduc.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("producto_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_producto", SqlDbType.VarChar).Value = txtidprod.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@marca_id_marca", SqlDbType.VarChar).Value = txtidmarca.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato Insertado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no Ingresado" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("producto_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_producto", SqlDbType.VarChar).Value = txtidprod.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no eliminado" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("producto_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_producto", SqlDbType.VarChar).Value = txtidprod.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@marca_id_marca", SqlDbType.VarChar).Value = txtidmarca.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato actualizado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no actualizado" + ex.Message);
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
