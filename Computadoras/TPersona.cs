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
    public partial class TPersona : Form
    {
        public TPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRHH rh = new RRHH();
            this.Hide();
            rh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("tpersona_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_tpers", SqlDbType.VarChar).Value = txtidp.Text;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txttpers.Text;

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

        private void T_Persona_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from tipo_persona", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvtpers.DataSource = tabla;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F6UL2EA;Initial Catalog=Control_Cafe;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("tpersona_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_tpers", SqlDbType.VarChar).Value = txtidp.Text;

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

                SqlCommand cmd = new SqlCommand("tpersona_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_tpers", SqlDbType.VarChar).Value = txtidp.Text;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txttpers.Text;

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
    }
}
