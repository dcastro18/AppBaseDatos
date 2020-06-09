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
    public partial class ActualizarPrecios : Form
    {
        private SqlConnection con;
        DataTable dtParte = new DataTable();
        DataTable dtProvParte = new DataTable();

        public ActualizarPrecios(string datosConexion)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string idParte = dtParte.Rows[partes.SelectedIndex][0].ToString();
            string idProveedor = dtProvParte.Rows[proveedores.SelectedIndex][0].ToString();

            SqlCommand cmd = new SqlCommand("SPUProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            cmd.Parameters.AddWithValue("@idProveedor", SqlDbType.Int).Value = idProveedor;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Float).Value = precio.Text;
            
            if (ganancia.Text.Length > 0)
            {
                int numerador = Int32.Parse(ganancia.Text);
                float result = numerador/100f;
                cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Float).Value = result;
                
            }

            cmd.ExecuteNonQuery();

            MessageBox.Show("Precios Actualizados.");
            
            con.Close();

        }

        private void partes_SelectedIndexChanged(object sender, EventArgs e)
        {

            proveedores.Items.Clear();

            dtProvParte.Clear();
           
            con.Open();

            SqlCommand cmd = new SqlCommand("SPSProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreParte", SqlDbType.VarChar).Value = partes.Text;

            
            dtProvParte.Load(cmd.ExecuteReader());


            for (int i = 0; i < dtProvParte.Rows.Count; i++)
            {
                proveedores.Items.Add(dtProvParte.Rows[i][1].ToString());
            }

            proveedores.SelectedIndex = 0;
            con.Close();

        }
    }
}
