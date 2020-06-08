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
    public partial class ActivarCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        DataTable dtClientes = new DataTable();
        public ActivarCliente()
        {
            InitializeComponent();
            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);

            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                if (dtClientes.Rows[i][3].ToString() == "3")
                {
                    cedulas.Items.Add(dtClientes.Rows[i][1].ToString());
                }

            }

            cedulas.SelectedIndex = 0;
        }

        private void ActivarCliente_Load(object sender, EventArgs e)
        {

        }

        private void cedulas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idCliente = (dtClientes.Rows[cedulas.SelectedIndex][0]).ToString();

            SqlCommand cmd = new SqlCommand("SPUACliente", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Decimal).Value = Convert.ToDecimal(idCliente, CultureInfo.InvariantCulture);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente Activado");
            con.Close();
        }
    }
}
