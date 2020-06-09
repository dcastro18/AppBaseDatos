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
    public partial class ListarPartesAuto : Form
    {
        private SqlConnection con;
        DataTable dtAuto = new DataTable();

        public ListarPartesAuto(string datosConexion)
        {
            con = new SqlConnection(datosConexion);

            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Automovil", con);
            
            sta.Fill(dtAuto);

            for (int i = 0; i < dtAuto.Rows.Count; i++)
            {
                modelo.Items.Add(dtAuto.Rows[i][1].ToString() + " - " + dtAuto.Rows[i][2].ToString());
            }

            modelo.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            listaPartes.Items.Clear();

            SqlCommand cmd = new SqlCommand("SPSPartesAutomovil", con);

            string pModelo = (dtAuto.Rows[modelo.SelectedIndex][1]).ToString();
            string anno = (dtAuto.Rows[modelo.SelectedIndex][2]).ToString();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@modelo", SqlDbType.VarChar).Value = pModelo;
            cmd.Parameters.AddWithValue("@anno", SqlDbType.Int).Value = anno;

            DataTable dtListaPartes = new DataTable();
            dtListaPartes.Load(cmd.ExecuteReader());

            if(dtListaPartes.Rows.Count == 0)
            {
                listaPartes.Items.Add("No hay partes registradas para este automovil");
            }
            else
            {
                for (int i = 0; i < dtListaPartes.Rows.Count; i++)
                {
                    listaPartes.Items.Add(dtListaPartes.Rows[i][1].ToString());
                }

            }
            

            
            con.Close();
        }
    }

    
}
