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
    public partial class InsertarCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        
        public InsertarCliente()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPICliente", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Decimal).Value = Convert.ToDecimal(cedula.Text, CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = nombre.Text;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = direccion.Text;
            cmd.Parameters.AddWithValue("@Ciudad", SqlDbType.NVarChar).Value = ciudad.Text;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.Decimal).Value = telefono.Text;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Añadido con exito!");
            con.Close();

        }
    }
}
