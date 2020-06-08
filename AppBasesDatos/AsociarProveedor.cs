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
    public partial class AsociarProveedor : Form
    {
        private SqlConnection con;
        DataTable dtParte = new DataTable();
        DataTable dtProveedor = new DataTable();

        public AsociarProveedor(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();


            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Parte", con);
           
            sta.Fill(dtParte);

            for (int i = 0; i < dtParte.Rows.Count; i++)
            {
                partes.Items.Add(dtParte.Rows[i][1].ToString());
            }

            partes.SelectedIndex = 0;

            sta = new SqlDataAdapter("SELECT * FROM Proveedor", con);
            
            sta.Fill(dtProveedor);


            for (int i = 0; i < dtProveedor.Rows.Count; i++)
            {
                proveedores.Items.Add(dtProveedor.Rows[i][1].ToString());
            }

            proveedores.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idParte = dtParte.Rows[partes.SelectedIndex][0].ToString();
            string idProveedor = dtProveedor.Rows[proveedores.SelectedIndex][0].ToString();

            int nGanacia = Int16.Parse(ganancia.Text)/100;

            SqlCommand cmd = new SqlCommand("SPIProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            cmd.Parameters.AddWithValue("@idProveedor", SqlDbType.Int).Value = idProveedor;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Float).Value = precio.Text;
            cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Float).Value = nGanacia;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Parte asociada con exito!");
            con.Close();

        }

        private void partes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
