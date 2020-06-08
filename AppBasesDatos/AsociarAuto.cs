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

namespace pruebaInterfaz
{
    public partial class AsociarAuto : Form
    {
        private SqlConnection con;
        DataTable dtAuto = new DataTable();
        DataTable dtParte = new DataTable();
        public AsociarAuto(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Parte", con);
            
            sta.Fill(dtParte);

            for (int i = 0; i < dtParte.Rows.Count; i++)
            {
                partes.Items.Add(dtParte.Rows[i][1].ToString());
            }

            partes.SelectedIndex = 0;

            sta = new SqlDataAdapter("SELECT * FROM Automovil", con);
            
            sta.Fill(dtAuto);


            for (int i = 0; i < dtAuto.Rows.Count; i++)
            {
                auto.Items.Add(dtAuto.Rows[i][1].ToString());
            }

            auto.SelectedIndex = 0;
        }

        private void partes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idParte = (dtParte.Rows[partes.SelectedIndex][0]).ToString();
            string idAutomovil = (dtAuto.Rows[auto.SelectedIndex][0]).ToString();

            SqlCommand cmd = new SqlCommand("SPIParteAutomovil", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            cmd.Parameters.AddWithValue("@idAutomovil", SqlDbType.Int).Value = idAutomovil;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Parte asociada con exito!");
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void auto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
