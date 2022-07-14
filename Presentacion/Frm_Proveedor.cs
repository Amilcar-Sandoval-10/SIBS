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
    public partial class Frm_Proveedor : Form
    {
        private bool Modificar;
        public Frm_Proveedor()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            try
            {
                
                N_Proveedores NegocioProveedor = new N_Proveedores();
                dgvproveedor.DataSource = NegocioProveedor.listaProveedores();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            CargarGrid();
            ListarCategorias();
        }
        private void ListarCategorias()
        {
            N_Categoria NegocioCat = new N_Categoria();
            cbcategoria.DataSource = NegocioCat.ListaCategoria();
            cbcategoria.DisplayMember = "NombreCat";
            cbcategoria.ValueMember = "ID";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnNuevo.Text);
            Global.Habilitar(PanelInventario);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnCancelar.Text);
            Global.Desabilitar(PanelInventario);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelInventario);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.ValidaTextBoxVacios(PanelInventario)  == false)
                {
                    MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    N_Proveedores nInventario = new N_Proveedores();
                    if (Modificar)
                    {
                        E_Proveedores Modificar_Proveedores = new E_Proveedores();
                        Modificar_Proveedores.Cod_Proveedor = Convert.ToInt32(txtNombre.Tag.ToString());
                        Modificar_Proveedores.ID = Convert.ToInt32(cbcategoria.SelectedValue);
                        Modificar_Proveedores.Nombre = txtNombre.Text;
                        Modificar_Proveedores.Direccion = txtDireccion.Text;
                        Modificar_Proveedores.Email = txtCorreo.Text;
                        Modificar_Proveedores.Telefono = Convert.ToInt32(txtTelefono.Text);
                        if (nInventario.Modificar(Modificar_Proveedores))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(PanelInventario);
                            Modificar = false;
                        }
                    }
                    else
                    {
                        E_Proveedores GuardarProveedor = new E_Proveedores();
                        GuardarProveedor.ID = (int)cbcategoria.SelectedValue;
                        GuardarProveedor.Nombre = txtNombre.Text;
                        GuardarProveedor.Direccion = txtDireccion.Text;
                        GuardarProveedor.Email = txtCorreo.Text;
                        GuardarProveedor.Telefono = Convert.ToInt32(txtTelefono.Text);
                        if (nInventario.Guardar(GuardarProveedor))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrid();
                            Global.Limpiar(PanelInventario);
                            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, BtnGuardar.Text);
                        }
                    }
                }
                   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvproveedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccionar un registro","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else 
                {
                    txtNombre.Tag = dgvproveedor.CurrentRow.Cells["ID"].Value.ToString();
                    cbcategoria.Text = dgvproveedor.CurrentRow.Cells["Nombrecat"].Value.ToString();
                    txtNombre.Text = dgvproveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtTelefono.Text = dgvproveedor.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtDireccion.Text = dgvproveedor.CurrentRow.Cells["Direccion"].Value.ToString();
                    txtCorreo.Text = dgvproveedor.CurrentRow.Cells["Email"].Value.ToString();
                    Modificar = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_FiltroProveedor proveedor = new Frm_FiltroProveedor();
            proveedor.Show();
        }
    }
}
