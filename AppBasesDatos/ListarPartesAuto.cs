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

        public ListarPartesAuto(string datosConexion)
        {
            con = new SqlConnection(datosConexion);

            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Automovil", con);
            DataTable dtAuto = new DataTable();
            sta.Fill(dtAuto);


            for (int i = 0; i < dtAuto.Rows.Count; i++)
            {
                modelo.Items.Add(dtAuto.Rows[i][1].ToString());

                //listaPartes.Items.Add(anno.FindStringExact(dtAuto.Rows[i][2].ToString()));
                
                if (!anno.Items.Contains(dtAuto.Rows[i][2].ToString()))
                {
                    anno.Items.Add(dtAuto.Rows[i][2].ToString());
                }
               
            }

            anno.SelectedIndex = 0;

            modelo.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            listaPartes.Items.Clear();

            SqlCommand cmd = new SqlCommand("SPSPartesAutomovil", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@modelo", SqlDbType.VarChar).Value = modelo.Text;
            cmd.Parameters.AddWithValue("@anno", SqlDbType.Int).Value = anno.Text;

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
