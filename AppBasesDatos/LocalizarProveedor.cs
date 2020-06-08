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
    public partial class LocalizarProveedor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");


        public LocalizarProveedor()
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
            listaProveedores.Items.Clear();

            con.Open();

            SqlCommand cmd = new SqlCommand("SPSProveedorParte", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreParte", SqlDbType.VarChar).Value = partes.Text;

            DataTable dtListaPartes = new DataTable();
            dtListaPartes.Load(cmd.ExecuteReader());

            for (int i = 0; i < dtListaPartes.Rows.Count; i++)
            {
                listaProveedores.Items.Add(dtListaPartes.Rows[i][1].ToString());
            }

            con.Close();
        }
    }
}
