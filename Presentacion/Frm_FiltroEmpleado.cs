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
    public partial class Frm_FiltroEmpleado : Form
    {
        public Frm_FiltroEmpleado()
        {
            InitializeComponent();
        }

        private void btnFiltroEmpledos_Click(object sender, EventArgs e)
        {
            try
            {
                NEmpleados negocioEmpleado = new NEmpleados();
                List<E_Empleados> lista = negocioEmpleado.ListaEmpleadoBuscar();
                if (cbcodigo.Checked)
                {
                    lista = lista.Where(l => l.Codigo.StartsWith(txtcodigo.Text)).ToList();

                }
                if (cbnombre.Checked)
                {
                    lista = lista.Where(l => l.Nombre.StartsWith(txtnombre.Text)).ToList();
                }
                if (cbapellido.Checked)
                {
                    lista = lista.Where(l => l.Apellidos.StartsWith(txtapellido.Text)).ToList();
                }
                dgvFiltroEmpleado.DataSource = lista;
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
                NEmpleados NegocioClientes = new NEmpleados();
                dgvFiltroEmpleado.DataSource = NegocioClientes.ListaEmpleados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Frm_Venta Padre;
        public Frm_FiltroEmpleado(Frm_Venta parametro)
        {
            InitializeComponent();
            Padre = parametro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_FiltroEmpleado_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }

        private void dgvFiltroEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.IdEmpleado.Tag = dgvFiltroEmpleado.CurrentRow.Cells["CodEmpleado"].Value.ToString();
            Padre.IdEmpleado.Text = dgvFiltroEmpleado.CurrentRow.Cells["Codigo"].Value.ToString();
            this.Close();
        }
    }
}
