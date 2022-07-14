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
    public partial class Frm_FiltroInventario : Form
    {
        public Frm_FiltroInventario()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ListarCategorias()
        {
            N_Categoria NegocioCat = new N_Categoria();
            cmbcategoria.DataSource = NegocioCat.ListaCategoria();
            cmbcategoria.DisplayMember = "NombreCat";
            cmbcategoria.ValueMember = "ID";
        }

        private void ListarProductos()
        {
            N_Producto NegocioProd = new N_Producto();
            cmbProducto.DataSource = NegocioProd.ListaPro();
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "Cod_Productos";
        }
        private void CargarGrid()
        {
            try
            {
                NInventario nInventario = new NInventario();
                dgvFiltroInventario.DataSource = nInventario.ListaInventario();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbcodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcodigo.Checked)
            {
                txtcodigo.Enabled = true;
            }
            else
            {
                txtcodigo.Enabled = false;
            }
        }

        private void cbkcategoria_CheckedChanged(object sender, EventArgs e)
        {
            if(cbcategoria.Checked)
            {
                cmbcategoria.Enabled = true;
            }
            else
            {
                cmbcategoria.Enabled = false;
            }
        }

        private void cbProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProducto.Checked)
            {
                cmbProducto.Enabled = true;
            }
            else
            {
                cmbProducto.Enabled = false;
            }
        }

        private void Frm_FiltroInventario_Load(object sender, EventArgs e)
        {

            CargarGrid();
            ListarCategorias();
            ListarProductos();
        }

        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                NInventario negocioInvenario = new NInventario();
                List<E_Inventario> lista = negocioInvenario.ListaInventarioBuscar();
                if (cbcodigo.Checked)
                {

                    lista = lista.Where(l => l.Codigo.StartsWith(txtcodigo.Text)).ToList();

                }
                if (cbcategoria.Checked)
                {
                    int Id = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());
                    lista = lista.Where(l => l.ID==Id).ToList();
                }
                if (cbProducto.Checked)
                {
                    int Idp = Convert.ToInt32(cmbProducto.SelectedValue.ToString());
                    lista = lista.Where(l => l.Cod_Productos==Idp).ToList();
                }
                dgvFiltroInventario.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private Frm_Venta Padre;
        public Frm_FiltroInventario(Frm_Venta parametro)
        {
            InitializeComponent();
            Padre = parametro;

        }

        private void dgvFiltroInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Padre.txtCategoria.Text = dgvFiltroInventario.CurrentRow.Cells["Nombrecat"].Value.ToString();
            Padre.txtCategoria.Tag = dgvFiltroInventario.CurrentRow.Cells["IdCat"].Value.ToString();
            Padre.txtProducto.Text = dgvFiltroInventario.CurrentRow.Cells["NombreProducto"].Value.ToString();
            Padre.txtProducto.Tag = dgvFiltroInventario.CurrentRow.Cells["Cod_Productos"].Value.ToString();
            Padre.txtPrecio.Tag = dgvFiltroInventario.CurrentRow.Cells["ID"].Value.ToString();
            Padre.txtPrecio.Text = dgvFiltroInventario.CurrentRow.Cells["Precio"].Value.ToString();
            Padre.txtDescuento.Text = dgvFiltroInventario.CurrentRow.Cells["Descuento"].Value.ToString();
            Close();           
        }
    }
}
