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
    public partial class ModificarCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");

        public ModificarCliente()
        {
            InitializeComponent();


            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);
            DataTable dtClientes = new DataTable();
            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                if(dtClientes.Rows[i][2].ToString() == "1")
                {
                    cedulas.Items.Add(dtClientes.Rows[i][0].ToString());
                }
                
            }

            cedulas.SelectedIndex = 0;

        }

        private void cedulas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPUCliente", con);


            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Decimal).Value = cedulas.Text;
            if(nombre.Text.Length>0)
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
            if (telefono.Text.Length > 0)
            {
                cmd.Parameters.AddWithValue("@Telefono", SqlDbType.Int).Value = telefono.Text;
            }
            
            cmd.ExecuteNonQuery();

            MessageBox.Show("Modificado con exito!");
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
