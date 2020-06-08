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
    public partial class ModificarOrganizacion : Form
    {
        private SqlConnection con;

        public ModificarOrganizacion(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();
            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);
            DataTable dtClientes = new DataTable();
            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                if (dtClientes.Rows[i][2].ToString() == "2")
                {
                    cedulas.Items.Add(dtClientes.Rows[i][0].ToString());
                }

            }

            cedulas.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPUOrganizacion", con);


            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Decimal).Value = cedulas.Text;
            if (nombre.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = nombre.Text;
            }
            if (direccion.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@Direccion", SqlDbType.VarChar).Value = direccion.Text;
            }
            if (ciudad.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@Ciudad", SqlDbType.VarChar).Value = ciudad.Text;
            }
            if (nomContacto.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@NombreContacto", SqlDbType.Int).Value = nomContacto.Text;
            }
            if (telefono.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@Telefono", SqlDbType.Int).Value = telefono.Text;
            }
            if (cargo.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@CargoContacto", SqlDbType.Int).Value = cargo.Text;
            }

            cmd.ExecuteNonQuery();

            MessageBox.Show("Modificado con exito!");
            con.Close();
        }
    }
}
