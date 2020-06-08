using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pruebaInterfaz
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void asociarPartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarProveedor().Show();
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
            new SuspenderCliente().Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarCliente().Show();
        }

        private void organizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarOrganizacion().Show();
        }

        private void insertarParteNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarParte().Show();
        }

        private void borrarUnaParteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BorrarParte().Show();
        }

        private void asociarPartesConTipoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarAuto().Show();
        }

        private void actualizarPreciosDeUnaParteOfrecidaPorUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarPrecios().Show();
        }

        private void listarPartesPorTiposDeAutomóvilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarPartesAuto().Show();
        }

        private void insertarUnaNuevaOrdenParaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertarOrden().Show();
        }

        private void asociarAUnaOrdenLaCompraDeUnaCantidadDePartesDeUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AsociarOrden().Show();
        }

        private void listarPartesPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LocalizarProveedor().Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModificarCliente().Show();
        }

        private void organizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarOrganizacion().Show();
        }

        private void organizacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ModificarOrganizacion().Show();
        }

        private void activarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActivarCliente().Show();
        }
    }
}
