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
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");

        public ActualizarPrecios()
        {
            InitializeComponent();
            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Parte", con);
            DataTable dtParte = new DataTable();
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

            string idParte = (partes.SelectedIndex + 1).ToString();
            string idProveedor = (proveedores.SelectedIndex + 1).ToString();

            SqlCommand cmd = new SqlCommand("SPUProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            cmd.Parameters.AddWithValue("@idProveedor", SqlDbType.Int).Value = idProveedor;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Float).Value = precio.Text;
            if (ganancia.Text.Length > 0)
            {
                int nGanacia = Int16.Parse(ganancia.Text) / 100;
                cmd.Parameters.AddWithValue("@Ganancia", SqlDbType.Float).Value = nGanacia;
            }

            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void partes_SelectedIndexChanged(object sender, EventArgs e)
        {

            proveedores.Items.Clear();
           
            con.Open();

            SqlCommand cmd = new SqlCommand("SPSProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreParte", SqlDbType.VarChar).Value = partes.Text;

            DataTable dtProvParte = new DataTable();
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
