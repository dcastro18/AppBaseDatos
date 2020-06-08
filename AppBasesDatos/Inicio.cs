using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pruebaInterfaz
{
    public partial class Inicio : Form
    {
        public string datos;
        public Inicio()
        {
            datos = "Data Source=172.19.127.67\\ESTUDIANTES;Initial Catalog=VentaRepuestos;User ID=dacastro;Password=dacastro";
            InitializeComponent();
        }

        private void asociarPartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarProveedor(datos).Show();
        }

        private void partesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertarClienteNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new InsertarCliente().Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ListarClientes().Show();
        }

        private void modificarClienteViejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ModificarCliente().Show();
        }

        private void suspenderClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuspenderCliente(datos).Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarCliente(datos).Show();
        }

        private void organizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarOrganizacion(datos).Show();
        }

        private void insertarParteNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarParte(datos).Show();
        }

        private void borrarUnaParteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BorrarParte(datos).Show();
        }

        private void asociarPartesConTipoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarAuto(datos).Show();
        }

        private void actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarPrecios(datos).Show();
        }

        private void listarPartesPorTiposDeAutomóvilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarPartesAuto(datos).Show();
        }

        private void insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarOrden(datos).Show();
        }

        private void asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarOrden(datos).Show();
        }

        private void listarPartesPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LocalizarProveedor(datos).Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes(datos).Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModificarCliente(datos).Show();
        }

        private void organizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarOrganizacion(datos).Show();
        }

        private void organizacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModificarOrganizacion(datos).Show();
        }

        private void activarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActivarCliente(datos).Show();
        }
    }
}
