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
    public partial class ListarOrganizacion : Form
    {
        private SqlConnection con;

        public ListarOrganizacion(string datosConexion)
        {
            con = new SqlConnection(datosConexion);
            InitializeComponent();
            SqlDataAdapter sta = new SqlDataAdapter("exec SPSOrganizacion", con);
            DataTable dtClientes = new DataTable();
            sta.Fill(dtClientes);

            string linea = "";
            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {

                for (int c = 0; c < dtClientes.Columns.Count; c++)
                {
                    if (c == 0)
                    {
                        linea += dtClientes.Rows[i][c].ToString();
                    }
                    else
                    {
                        linea += " - " + dtClientes.Rows[i][c].ToString();
                    }


                }


                listaClientes.Items.Add(linea);
                linea = "";
            }
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
