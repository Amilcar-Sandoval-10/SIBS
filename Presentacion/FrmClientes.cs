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
    public partial class FrmCliente : Form
    {
        private bool Modificar;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }
        private void Cargargrid()
        {
            try
            {
                NClientes NegocioClientes = new NClientes();
                dgvclientes.DataSource = NegocioClientes.ListaClientes();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelClientes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnNuevo.Text);
            Global.Habilitar(PanelClientes);
            txtnombre.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dgvclientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtnombre.Tag = Convert.ToInt32(dgvclientes.CurrentRow.Cells["Id_Cliente"].Value.ToString());
                    txtnombre.Text = dgvclientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtapellidos.Text = dgvclientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                    txtcedula.Text = dgvclientes.CurrentRow.Cells["Cedula"].Value.ToString();
                    txttelefono.Text = dgvclientes.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtFecha.Text = dgvclientes.CurrentRow.Cells["Fecha_Nac"].Value.ToString();
                    txtDireccion.Text = dgvclientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    if (rbMasculino.Checked == true)
                    {
                        dgvclientes.CurrentRow.Cells["Genero"].Value = "M";
                    }
                    else
                    {
                        dgvclientes.CurrentRow.Cells["Genero"].Value = "F";
                    }
                    Modificar = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnCancelar.Text);
            Global.Desabilitar(PanelClientes);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.ValidaTextBoxVacios(PanelClientes) == false)
                {
                    MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Modificar)
                {
                    E_Clientes ModificarCliente = new E_Clientes();
                    ModificarCliente.Id_Cliente = Convert.ToInt32(txtnombre.Tag.ToString());
                    ModificarCliente.Nombre = txtnombre.Text;
                    ModificarCliente.Apellidos = txtapellidos.Text;
                    ModificarCliente.Cedula = txtcedula.Text;
                    ModificarCliente.Fecha_Nac = txtFecha.Text;
                    if (rbMasculino.Checked == true)
                    {
                        ModificarCliente.Genero = "M";
                    }
                    else
                    {
                        ModificarCliente.Genero = "F";
                    }

                    ModificarCliente.Direccion = txtDireccion.Text;
                    ModificarCliente.Telefono = Convert.ToInt32(txttelefono.Text);
                    NClientes nClientes = new NClientes();
                    if (nClientes.Modificar(ModificarCliente))
                    {
                        MessageBox.Show("Se Modifico exitosamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargargrid();
                        Global.Limpiar(PanelClientes);
                        Modificar = false;
                    }
                }
                else
                {
                    E_Clientes GuardarCliente = new E_Clientes();
                    GuardarCliente.Nombre = txtnombre.Text;
                    GuardarCliente.Apellidos = txtapellidos.Text;
                    GuardarCliente.Cedula = txtcedula.Text;
                    GuardarCliente.Fecha_Nac = txtFecha.Text;
                    if (rbMasculino.Checked == true)
                    {
                        GuardarCliente.Genero = "M";
                    }
                    else
                    {
                        GuardarCliente.Genero = "F";
                    }
                    GuardarCliente.Direccion = txtDireccion.Text;
                    GuardarCliente.Telefono = Convert.ToInt32(txttelefono.Text);
                    NClientes nClientesG = new NClientes();
                    if (nClientesG.Guardar(GuardarCliente))
                    {
                        MessageBox.Show("Se guardo exitosamente", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargargrid();
                        Global.Limpiar(PanelClientes);
                        Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, BtnGuardar.Text);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_FiltroClientes cliente = new Frm_FiltroClientes();
            cliente.Show();
        }
        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
