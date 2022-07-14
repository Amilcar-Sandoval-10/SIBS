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
    public partial class Frm_FiltroProveedor : Form
    {
        public Frm_FiltroProveedor()
        {
            InitializeComponent();
        }
        private void ListarCategoria()
        {
            N_Categoria NegocioClientes = new N_Categoria();
            cmbcategoria.DataSource = NegocioClientes.ListaCategoria();
            cmbcategoria.DisplayMember = "NombreCat";
            cmbcategoria.ValueMember = "ID";
        }
        private void CargarGrid()
        {
            try
            {

                N_Proveedores NegocioProveedor = new N_Proveedores();
                dgvFiltroInventario.DataSource = NegocioProveedor.listaProveedores();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                N_Proveedores negocioProveedor = new N_Proveedores();
                List<E_Proveedores> lista = negocioProveedor.ListaProveedorBuscar();
                if (cbcodigo.Checked)
                {

                    lista = lista.Where(l => l.Codigo.StartsWith(txtcodigo.Text)).ToList();

                }
                if (cbcategoria.Checked)
                {
                    int Id = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    lista = lista.Where(l => l.ID == Id).ToList();
                }
                if (cbNombre.Checked)
                {
                    lista = lista.Where(l => l.Nombre.StartsWith(txtNombre.Text)).ToList();
                }
                dgvFiltroInventario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbcodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcodigo.Checked==true)
            {
                txtcodigo.Enabled = true;
            }
            else
            {
                txtcodigo.Enabled = false;
            }

        }

        private void cbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNombre.Checked == true)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void cbcategoria_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcategoria.Checked==true)
            {
                cmbcategoria.Enabled = true;
            }
            else
            {
                cmbcategoria.Enabled = false;
            }
        }

        private void Frm_FiltroProveedor_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            CargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Frm_Compras Padre;
        public Frm_FiltroProveedor(Frm_Compras parametro)
        {
            InitializeComponent();
            Padre = parametro;
        }

        private void dgvFiltroInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Padre.txtnombre.Tag = dgvFiltroInventario.CurrentRow.Cells["ID"].Value.ToString();
            Padre.txtnombre.Text= dgvFiltroInventario.CurrentRow.Cells["Nombre"].Value.ToString();
            Padre.txtdireccion.Text = dgvFiltroInventario.CurrentRow.Cells["Direccion"].Value.ToString();
            Padre.txttelefono.Text = dgvFiltroInventario.CurrentRow.Cells["Telefono"].Value.ToString();
            Close();
        }
    }
}
