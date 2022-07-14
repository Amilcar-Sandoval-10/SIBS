using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Frm_FiltroClientes : Form
    {
        public Frm_FiltroClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                NClientes negocioCliente = new NClientes();
                List<E_Clientes> lista = negocioCliente.ListaClientes();
                if (cbcodigo.Checked)
                {

                    lista = lista.Where(l => l.Codigo.StartsWith(txtcodigo.Text)).ToList();
                    /*Existe otro metodo
                    lista = (from l in lista
                             where l.Id_Cliente.StartsWith(txtcodigo.Text)
                             select l).ToList();*/

                }
                if (cbnombre.Checked)
                {
                    lista = lista.Where(l => l.Nombre.StartsWith(txtnombre.Text)).ToList();
                }
                if (cbapellido.Checked)
                {
                    lista = lista.Where(l => l.Apellidos.StartsWith(txtapellido.Text)).ToList();
                }
                dgvFiltroCliente.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbcodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcodigo.Checked == true)
            {
                txtcodigo.Enabled = true;
            }
            else
            {
                txtcodigo.Enabled = false;
            }

        }

        private void cbnombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnombre.Checked == true)
            {
                txtnombre.Enabled = true;
            }
            else
            {
                txtnombre.Enabled = false;
            }
        }

        private void cbapellido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbapellido.Checked == true)
            {
                txtapellido.Enabled = true;
            }
            else
            {
                txtapellido.Enabled = false;
            }
        }
        private void Cargargrid()
        {
            try
            {
                NClientes NegocioClientes = new NClientes();
                dgvFiltroCliente.DataSource = NegocioClientes.ListaClientes();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_FiltroClientes_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }
        private Frm_Venta Padre;
        public Frm_FiltroClientes(Frm_Venta parametro)
        {
            InitializeComponent();
            Padre = parametro;
        }

        private void dgvFiltroCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Padre.txtnombre.Tag = dgvFiltroCliente.CurrentRow.Cells["Id_Cliente"].Value.ToString();
                Padre.txtnombre.Text = dgvFiltroCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                Padre.txtcedula.Text = dgvFiltroCliente.CurrentRow.Cells["Cedula"].Value.ToString();
                Padre.txttelefono.Text = dgvFiltroCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

