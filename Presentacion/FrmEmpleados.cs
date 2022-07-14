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
    public partial class FrmEmpleados : Form
    {
        private bool Modificar;
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        private void Cargargrid()
        {
            try
            {
                NEmpleados NegocioClientes = new NEmpleados();
                dgvempleados.DataSource = NegocioClientes.ListaEmpleados();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.ValidaTextBoxVacios(PanelEmpleados) == false)
                {
                    MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NEmpleados nEmpleados = new NEmpleados();
                    if (Modificar)
                    {
                        E_Empleados ModificarEmpleado = new E_Empleados();
                        ModificarEmpleado.CodEmpleado = Convert.ToInt32(txtnombre.Tag.ToString());
                        ModificarEmpleado.Nombre = txtnombre.Text;
                        ModificarEmpleado.Apellidos = txtapellidos.Text;
                        ModificarEmpleado.INSS = Convert.ToInt32(txtinss.Text);
                        ModificarEmpleado.FechaNac = txtFecha.Text;
                        if (rbMasculino.Checked == true)
                        {
                            ModificarEmpleado.Genero = "M";
                        }
                        else
                        {
                            ModificarEmpleado.Genero = "F";
                        }

                        ModificarEmpleado.Direccion = txtDireccion.Text;
                        ModificarEmpleado.Telefono = Convert.ToInt32(txttelefono.Text);
                        ModificarEmpleado.Estado_Civil = txtestado.Text;
                        ModificarEmpleado.Cargo = cmbCargo.Text;
                        ModificarEmpleado.Correo = txtEmail.Text;
                        if (nEmpleados.Modificar(ModificarEmpleado))
                        {
                            MessageBox.Show("Se Modifico exitosamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(PanelEmpleados);
                            Modificar = false;
                        }
                    }
                    else
                    {
                        E_Empleados GuardarEmpleado = new E_Empleados();
                        GuardarEmpleado.Nombre = txtnombre.Text;
                        GuardarEmpleado.Apellidos = txtapellidos.Text;
                        GuardarEmpleado.INSS = Convert.ToInt32(txtinss.Text);
                        GuardarEmpleado.FechaNac = txtFecha.Text;
                        GuardarEmpleado.Cargo = cmbCargo.Text;
                        if (rbMasculino.Checked == true)
                        {
                            GuardarEmpleado.Genero = "M";
                        }
                        else
                        {
                            GuardarEmpleado.Genero = "F";
                        }

                        GuardarEmpleado.Direccion = txtDireccion.Text;
                        GuardarEmpleado.Telefono = Convert.ToInt32(txttelefono.Text);
                        GuardarEmpleado.Estado_Civil = txtestado.Text;
                        GuardarEmpleado.Correo = txtEmail.Text;
                        if (nEmpleados.Guardar(GuardarEmpleado))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(PanelEmpleados);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnCancelar.Text);
            Global.Desabilitar(PanelEmpleados);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvempleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtnombre.Tag = dgvempleados.CurrentRow.Cells["CodEmpleado"].Value.ToString();
                    txtnombre.Text = dgvempleados.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtapellidos.Text = dgvempleados.CurrentRow.Cells["Apellidos"].Value.ToString();
                    txtinss.Text = dgvempleados.CurrentRow.Cells["INSS"].Value.ToString();
                    txttelefono.Text = dgvempleados.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtFecha.Text = dgvempleados.CurrentRow.Cells["FechaNac"].Value.ToString();
                    txtDireccion.Text = dgvempleados.CurrentRow.Cells["Direccion"].Value.ToString();
                    txtestado.Text = dgvempleados.CurrentRow.Cells["EstadoCivil"].Value.ToString();
                    cmbCargo.Text = dgvempleados.CurrentRow.Cells["Cargo"].Value.ToString();
                    txtEmail.Text = dgvempleados.CurrentRow.Cells["Email"].Value.ToString();
                    if (rbMasculino.Checked == true)
                    {
                        dgvempleados.CurrentRow.Cells["Genero"].Value = "M";
                    }
                    else
                    {
                        dgvempleados.CurrentRow.Cells["Genero"].Value = "F";
                    }
                    Modificar = true;

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnNuevo.Text);
            Global.Habilitar(PanelEmpleados);
            txtnombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelEmpleados);
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            Cargargrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_FiltroEmpleado frmEmpleados = new Frm_FiltroEmpleado();
            frmEmpleados.Show();
        }

        private void txtinss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
