using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace Presentacion
{
    public partial class Frm_FiltroUsuario : Form
    {
        public Frm_FiltroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ListarTipo()
        {
            N_Usuario NegocioTipo = new N_Usuario();
            cmbTipo.DataSource = NegocioTipo.ListaUsuario();
            cmbTipo.DisplayMember = "Tipo_Usuario";
            cmbTipo.ValueMember = "Id_Usuario";
        }
        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                N_Usuario negocioUsuario = new N_Usuario();
                List<E_Usuario> lista = negocioUsuario.ListaUsuarioB();
                if (cbUsuario.Checked)
                {

                    lista = lista.Where(l => l.Usuario.StartsWith(txtcodigo.Text)).ToList();

                }
                if (cbTipo.Checked)
                {
                    lista = lista.Where(l => l.Tipo_Usuario.StartsWith(cmbTipo.Text)).ToList();
                }
               
                dgvFiltroUsuario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Frm_FiltroUsuario_Load(object sender, EventArgs e)
        {
            ListarTipo();
            Cargargrid();
        }
        private void Cargargrid()
        {
            try
            {
                N_Usuario Usuario = new N_Usuario();
                dgvFiltroUsuario.DataSource = Usuario.ListaUsuario();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUsuario.Checked==true)
            {
                txtcodigo.Enabled = true;
            }
            else
            {
                txtcodigo.Enabled = false;
            }
        }

        private void cbTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTipo.Checked == true)
            {
                cmbTipo.Enabled = true;
            }
            else
            {
                cmbTipo.Enabled = false;
            }
        }
    }
}
