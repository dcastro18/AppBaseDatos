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
        SqlConnection con;
        DataTable dtClientes = new DataTable();
        public ActivarCliente(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();
            SqlDataAdapter sta = new SqlDataAdapter("select Cedula, Nombre from Cliente where idEstado = 3", con);

            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                cedulas.Items.Add(dtClientes.Rows[i][1].ToString());

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
