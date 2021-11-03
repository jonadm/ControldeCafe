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
    public partial class T_Inventario : Form
    {
        public T_Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            this.Hide();
            inv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from inventario", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvinven.DataSource = tabla;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("inventario_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_inventario", SqlDbType.VarChar).Value = txtidinven.Text;
                cmd.Parameters.Add("@cantidad", SqlDbType.VarChar).Value = txtcantidad.Text;
                cmd.Parameters.Add("@producto_id_produc", SqlDbType.VarChar).Value = txtidpro.Text;
                cmd.Parameters.Add("@compra_id_compra", SqlDbType.VarChar).Value = txtidcomp.Text;

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

                SqlCommand cmd = new SqlCommand("inventario_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_inventario", SqlDbType.VarChar).Value = txtidinven.Text;

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

                SqlCommand cmd = new SqlCommand("inventario_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_inventario", SqlDbType.VarChar).Value = txtidinven.Text;
                cmd.Parameters.Add("@cantidad", SqlDbType.VarChar).Value = txtcantidad.Text;
                cmd.Parameters.Add("@producto_id_produc", SqlDbType.VarChar).Value = txtidpro.Text;
                cmd.Parameters.Add("@compra_id_compra", SqlDbType.VarChar).Value = txtidcomp.Text;

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

        private void T_Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
