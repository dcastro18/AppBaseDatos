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
    public partial class BorrarParte : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        DataTable dtParte = new DataTable();

        public BorrarParte()
        {
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Parte", con);
            
            sta.Fill(dtParte);

            for (int i = 0; i < dtParte.Rows.Count; i++)
            {
                partes.Items.Add(dtParte.Rows[i][1].ToString());
            }

            partes.SelectedIndex = 0;

        }

        private void partes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idParte = (dtParte.Rows[partes.SelectedIndex][0]).ToString();

            SqlCommand cmd = new SqlCommand("SPDParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            DataTable dtBorrar = new DataTable();
            dtBorrar.Load(cmd.ExecuteReader());

            if (dtBorrar.Rows.Count == 0)
            {
                MessageBox.Show("Parte eliminada con exito!");
                
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar pues esta en una orden");

            }

            
            con.Close();
        }
    }
}
