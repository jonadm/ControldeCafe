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
using System.Data.OleDb;

namespace Computadoras
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRHH rh = new RRHH();
            this.Hide();
            rh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Persona_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from persona", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvpers.DataSource = tabla;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("persona_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpers.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtapelli.Text;
                cmd.Parameters.Add("@dpi", SqlDbType.VarChar).Value = txtdpi.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtdirecc.Text;
                cmd.Parameters.Add("@tipo_persona_id_tpers", SqlDbType.VarChar).Value = txtidtpers.Text;

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

                SqlCommand cmd = new SqlCommand("persona_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpers.Text;

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

                SqlCommand cmd = new SqlCommand("persona_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpers.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtapelli.Text;
                cmd.Parameters.Add("@dpi", SqlDbType.VarChar).Value = txtdpi.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtdirecc.Text;
                cmd.Parameters.Add("@tipo_persona_id_tpers", SqlDbType.VarChar).Value = txtidtpers.Text;

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

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
