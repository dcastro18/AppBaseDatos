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
using System.Globalization;

namespace pruebaInterfaz
{
    public partial class SuspenderCliente : Form
    {
        private SqlConnection con;
        DataTable dtClientes = new DataTable();
        public SuspenderCliente(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);
           
            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                if(dtClientes.Rows[i][3].ToString() == "1")
                {
                    cedulas.Items.Add(dtClientes.Rows[i][1].ToString());
                }
                
            }

            cedulas.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idCliente = (dtClientes.Rows[cedulas.SelectedIndex][0]).ToString();

            SqlCommand cmd = new SqlCommand("SPUSClientes", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", SqlDbType.Decimal).Value = Convert.ToDecimal(idCliente, CultureInfo.InvariantCulture);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente Suspendido");
            con.Close();
        
        }

        private void cedulas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
