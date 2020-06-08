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
    public partial class InsertarParte : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        DataTable dtMarcas = new DataTable();
        DataTable dtFabricante = new DataTable();
        public InsertarParte()
        {
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Marca", con);
            
            sta.Fill(dtMarcas);

            for (int i = 0; i < dtMarcas.Rows.Count; i++)
            {
                marcas.Items.Add(dtMarcas.Rows[i][1].ToString());
            }

            marcas.SelectedIndex = 0;

            sta = new SqlDataAdapter("SELECT * FROM Fabricante", con);
            
            sta.Fill(dtFabricante);

            for (int i = 0; i < dtFabricante.Rows.Count; i++)
            {
                fabricantes.Items.Add(dtFabricante.Rows[i][1].ToString());
            }

            fabricantes.SelectedIndex = 0;
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idMarca = dtMarcas.Rows[marcas.SelectedIndex][0].ToString();
            string idFabricante = dtFabricante.Rows[fabricantes.SelectedIndex][0].ToString();

            SqlCommand cmd = new SqlCommand("SPIPartes", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar).Value = nombre.Text;
            cmd.Parameters.AddWithValue("@idMarca", SqlDbType.Int).Value = idMarca;
            cmd.Parameters.AddWithValue("@idFabricante", SqlDbType.Int).Value = idFabricante;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Parte registrada con exito!");
            con.Close();
        }
    }
}
