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
    public partial class InsertarOrganizacion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");

        public InsertarOrganizacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPIOrganizacion", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Decimal).Value = Convert.ToDecimal(cedula.Text, CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = nombre.Text;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.VarChar).Value = direccion.Text;
            cmd.Parameters.AddWithValue("@Ciudad", SqlDbType.VarChar).Value = ciudad.Text;
            cmd.Parameters.AddWithValue("@NombreEncargado", SqlDbType.VarChar).Value = nomContacto.Text;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.Int).Value = telefono.Text;
            cmd.Parameters.AddWithValue("@CargoEncargado", SqlDbType.VarChar).Value = cargo.Text;


            cmd.ExecuteNonQuery();

            MessageBox.Show("Añadido con exito!");
            con.Close();
        }
    }
}
