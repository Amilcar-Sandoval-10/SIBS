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
    public partial class FrmInventario : Form
    {
        private bool Modificar;
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void ListarCategorias()
        {
            N_Categoria NegocioCat = new N_Categoria();
            cbcategoria.DataSource = NegocioCat.ListaCategoria();
            cbcategoria.DisplayMember = "NombreCat";
            cbcategoria.ValueMember = "ID";
        }
        private void ListarProductos()
        {
            N_Producto NegocioProd = new N_Producto();
            cbProductos.DataSource = NegocioProd.ListaPro();
            cbProductos.DisplayMember = "NombreProducto";
            cbProductos.ValueMember = "Cod_Productos";
        }


        private void FrmInventario_Load( object sender, EventArgs e)
        {
            CargarGrid();
            ListarCategorias();
            ListarProductos();
        }
        private void CargarGrid()
        {
            try
            {
                NInventario nInventario = new NInventario();
                dgvInventario.DataSource = nInventario.ListaInventario();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, btnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnNuevo.Text);
            Global.Habilitar(PanelInventario);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvInventario.SelectedRows.Count > 0)
                {
                    cbcategoria.Text = dgvInventario.CurrentRow.Cells["Nombrecat"].Value.ToString();
                    cbProductos.Text = dgvInventario.CurrentRow.Cells["NombreProducto"].Value.ToString();
                    txtStockActual.Tag = dgvInventario.CurrentRow.Cells["ID"].Value.ToString();
                    txtFechaEntrada.Text = dgvInventario.CurrentRow.Cells["Fecha_Entrada"].Value.ToString();
                    txtstockMax.Text = dgvInventario.CurrentRow.Cells["StockMaximo"].Value.ToString();
                    txtStockMin.Text = dgvInventario.CurrentRow.Cells["StockMinimo"].Value.ToString();
                    txtStockActual.Text = dgvInventario.CurrentRow.Cells["StockActual"].Value.ToString();
                    Modificar = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {      
            try
            {
                NInventario nInventario = new NInventario();
                if (Modificar)
                {
                    E_Inventario Modificar_Inventario = new E_Inventario();
                    Modificar_Inventario.Cod_Inventario = Convert.ToInt32(txtStockActual.Tag.ToString());
                    Modificar_Inventario.ID = Convert.ToInt32(cbcategoria.SelectedValue);
                    Modificar_Inventario.Cod_Productos = Convert.ToInt32(cbProductos.SelectedValue);
                    Modificar_Inventario.Fecha_Entrada = txtFechaEntrada.Text;
                    Modificar_Inventario.StockMaximo = Convert.ToInt32(txtstockMax.Text);
                    Modificar_Inventario.StockMinimo = Convert.ToInt32(txtStockMin.Text);
                    Modificar_Inventario.StockActual = Convert.ToInt32(txtStockActual.Text);
                    if (rbSi.Checked == true)
                    {
                        Modificar_Inventario.Garantia = "Si";
                    }
                    else
                    {
                        Modificar_Inventario.Garantia = "No";
                    }
                    if (nInventario.Modificar(Modificar_Inventario))
                    {
                        MessageBox.Show("Se Modifico exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        Global.Limpiar(PanelInventario);
                        Modificar = false;
                    }
                }              
                else
                {                                   
                    E_Inventario GuardarInventario = new E_Inventario();
                    GuardarInventario.ID = Convert.ToInt32(cbcategoria.SelectedValue);
                    GuardarInventario.Cod_Productos= Convert.ToInt32(cbProductos.SelectedValue);
                    GuardarInventario.Fecha_Entrada = txtFechaEntrada.Text;
                    GuardarInventario.StockMaximo = Convert.ToInt32(txtstockMax.Text);
                    GuardarInventario.StockMinimo = Convert.ToInt32(txtStockMin.Text);
                    GuardarInventario.StockActual = Convert.ToInt32(txtStockActual.Text);
                    if (rbSi.Checked == true)
                    {
                        GuardarInventario.Garantia = "Si";
                    }
                    else
                    {
                        GuardarInventario.Garantia = "No";
                    }
                    if (nInventario.Guardar(GuardarInventario))
                    {
                        MessageBox.Show("Se guardo exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        Global.Limpiar(PanelInventario);
                        Global.BotonesAccion(btnNuevo, btnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnGuardar.Text);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelInventario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, btnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnCancelar.Text);
            Global.Desabilitar(PanelInventario);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_FiltroInventario frm_FiltroInventario = new Frm_FiltroInventario();
            frm_FiltroInventario.Show();
        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvInventario.Columns[e.ColumnIndex].Name=="StockActual"){
                if (Convert.ToInt32(e.Value) > 10)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            
            }
        }
    }
}
