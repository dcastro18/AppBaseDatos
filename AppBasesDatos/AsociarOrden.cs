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
    public partial class AsociarOrden : Form
    {
        SqlConnection con = new SqlConnection("Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro");
        DataTable dtClientes = new DataTable();
        DataTable dtOrdenes = new DataTable();
        DataTable dtProvParte = new DataTable();
        DataTable dtParte = new DataTable();

        public AsociarOrden()
        {
            InitializeComponent();

            SqlDataAdapter sta = new SqlDataAdapter("SELECT * FROM Cliente", con);

            sta.Fill(dtClientes);

            for (int i = 0; i < dtClientes.Rows.Count; i++)
            {
                cedulas.Items.Add(dtClientes.Rows[i][1].ToString());
            }

            cedulas.SelectedIndex = 0;

            sta = new SqlDataAdapter("SELECT * FROM Parte", con);
            
            sta.Fill(dtParte);

            for (int i = 0; i < dtParte.Rows.Count; i++)
            {
                partes.Items.Add(dtParte.Rows[i][1].ToString());
            }

            partes.SelectedIndex = 0;
        }

        private void AsociarOrden_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDetalles()
        {
            //con.Open();

            detalleOrden.Items.Clear();

            SqlCommand cmd = new SqlCommand("SPSDetalleOrden", con);

           
            string idOrden = (dtOrdenes.Rows[Ordenes.SelectedIndex][0]).ToString();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idOrden", SqlDbType.Int).Value = idOrden;

            DataTable dtDetalles = new DataTable();
            dtDetalles.Load(cmd.ExecuteReader());

            string linea = "";
            for (int i = 0; i < dtDetalles.Rows.Count; i++)
            {

                for (int c = 0; c < dtDetalles.Columns.Count; c++)
                {
                    if (c == 0)
                    {
                        linea += dtDetalles.Rows[i][c].ToString();
                    }
                    else
                    {
                        linea += " - " + dtDetalles.Rows[i][c].ToString();
                    }
                }
                detalleOrden.Items.Add(linea);
                linea = "";
            }
            con.Close();

        }

        private void Ordenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // aca se actualiza el cuadro
            actualizarDetalles();
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

        private void cedulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ordenes.Items.Clear();

            dtOrdenes.Clear();

            con.Open();

            SqlCommand cmd = new SqlCommand("SPSOrden", con);

            string idCliente = (dtClientes.Rows[cedulas.SelectedIndex][0]).ToString();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cedula", SqlDbType.Int).Value = idCliente;

            dtOrdenes.Load(cmd.ExecuteReader());

            if (dtOrdenes.Rows.Count > 0)
            {
                for (int i = 0; i < dtOrdenes.Rows.Count; i++)
                {
                    Ordenes.Items.Add(dtOrdenes.Rows[i][1].ToString());
                }

                Ordenes.SelectedIndex = 0;
            }
            else
            {
                detalleOrden.Items.Clear();
                detalleOrden.Items.Add("No existen ordenes registradas para este cliente");
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPIDetalleOrden", con);

            string idOrden = (dtOrdenes.Rows[Ordenes.SelectedIndex][0]).ToString();
            string idParte = dtParte.Rows[partes.SelectedIndex][0].ToString();
            string idProveedor = dtProvParte.Rows[proveedores.SelectedIndex][0].ToString();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idParte", SqlDbType.Int).Value = idParte;
            cmd.Parameters.AddWithValue("@idProveedor", SqlDbType.Int).Value = idProveedor;
            cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Int).Value = cantidad.Value;
            cmd.Parameters.AddWithValue("@idOrden", SqlDbType.Int).Value = idOrden;

            cmd.ExecuteNonQuery();

            cantidad.Value = 0;

            actualizarDetalles();

            con.Close();

        }
    }
}
