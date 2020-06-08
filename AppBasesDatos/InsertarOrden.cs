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
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        DataTable dtClientes = new DataTable();

        public InsertarOrden()
        {
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
            cmd.ExecuteNonQuery();

            con.Close();

        }
    }
}
