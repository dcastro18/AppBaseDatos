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
    public partial class InsertarOrden : Form
    {
        private SqlConnection con;
        DataTable dtClientes = new DataTable();

        public InsertarOrden(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);
            
            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                cedulas.Items.Add(dtClientes.Rows[i][1].ToString());
            }

            cedulas.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPIOrden", con);

            string idCliente = (dtClientes.Rows[cedulas.SelectedIndex][0]).ToString();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", SqlDbType.VarChar).Value = idCliente;
            cmd.Parameters.AddWithValue("@Fecha", SqlDbType.VarChar).Value = fecha.Text;

            DataTable dtValidar = new DataTable();
            dtValidar.Load(cmd.ExecuteReader());

            if (dtValidar.Rows.Count != 0)
            {
                MessageBox.Show("No se ha podido crear la orden pues el cliente esta suspendido.");

            }
            else
            {
                MessageBox.Show("Orden registrada correctamente."); ;

            }

            

            con.Close();

        }
    }
}
