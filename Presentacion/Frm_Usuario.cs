using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{

    public partial class Frm_Usuario : Form
    {
        private bool Modificar;
        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            Cargargrid();
            ListarTipo();
        }

        private void Cargargrid()
        {
            try
            {
                N_Usuario Usuario = new N_Usuario();
                dgvUsuario.DataSource = Usuario.ListaUsuario();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(PanelUsuario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Frm_FiltroUsuario Usuario = new Frm_FiltroUsuario();
            Usuario.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, BtnGuardar, btnModificar, btnBuscar, btnCancelar, btnLimpiar, btnNuevo.Text);
            Global.Habilitar(PanelUsuario);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtUsuario.Tag = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["Id_Usuario"].Value.ToString());
                    cmbEmpleado.Text = dgvUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                    cmbEmpleado.Tag = dgvUsuario.CurrentRow.Cells["CodEmpleado"].Value.ToString();
                    txtUsuario.Text = dgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                    cmbTipo.Text = dgvUsuario.CurrentRow.Cells["Tipo_Usuario"].Value.ToString();                   
                    Modificar = true;
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
            Global.Desabilitar(PanelUsuario);
        }
        private void ListarTipo()
        {
            NEmpleados NegocioTipo = new NEmpleados();
            cmbEmpleado.DataSource = NegocioTipo.ListaEmpleados();
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "CodEmpleado";
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.ValidaTextBoxVacios (PanelUsuario) == false)
                {
                    MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Modificar)
                {
                    E_Usuario ModificarUsuario = new E_Usuario
                    {
                        Id_Usuario = Convert.ToInt32(txtUsuario.Tag.ToString()),
                        CodEmpleado = Convert.ToInt32(cmbEmpleado.Tag.ToString()),
                        Usuario = txtUsuario.Text,
                        Contraseña = txtContraseña.Text,
                        Tipo_Usuario = cmbEmpleado.Text
                    };

                    N_Usuario nUsuario = new N_Usuario();
                    if (nUsuario.Modificar(ModificarUsuario))
                    {
                        MessageBox.Show("Se Modifico exitosamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargargrid();
                        Global.Limpiar(PanelUsuario);
                        Modificar = false;
                    }
                }
                else
                {
                    string pass = txtContraseña.Text;
                    Match matchLongitud = Regex.Match(pass, @"^\w{8,15}\b");
                    Match matchNumeros = Regex.Match(pass, @"\d");
                    Match matchEspeciales = Regex.Match(pass, @"[ñÑ\-_¿.#¡!*./]"); //Caracteres especiales 
                    Match matchMayusculas = Regex.Match(pass, @"[A-Z]");
                    Match matchMinusculas = Regex.Match(pass, @"[a-z]");
                    if (!matchLongitud.Success)
                    {
                        txtContraseña.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("La contraseña debe tener de 8 a 15 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!matchNumeros.Success)
                    {
                        txtContraseña.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("¡La contraseña debe tener al menos un número!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!matchMayusculas.Success)
                    {
                        txtContraseña.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("¡La contraseña debe tener al menos una Mayuscula!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!matchMinusculas.Success)
                    {
                        txtContraseña.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("¡La contraseña debe tener al menos una Minuscula!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (matchEspeciales.Success)
                    {
                        txtContraseña.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("¡La contraseña no debe tener caracteres especiales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtContraseña.Text != txt_ConfirmPass.Text)
                    {
                        txt_ConfirmPass.BackColor = Color.FromArgb(255, 0, 0);
                        MessageBox.Show("¡Error en confirmar contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        E_Usuario GuardarUsuario = new E_Usuario
                        {
                            Usuario = txtUsuario.Text,
                            Contraseña = txtContraseña.Text,
                            CodEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue),
                            Tipo_Usuario = cmbTipo.Text
                        };
                        N_Usuario nUsuarioG = new N_Usuario();
                        if (nUsuarioG.Guardar(GuardarUsuario))
                        {
                            MessageBox.Show("Se guardo exitosamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargargrid();
                            Global.Limpiar(PanelUsuario);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_mostrar_Click(object sender, EventArgs e)
        {

            txtContraseña.UseSystemPasswordChar = false;
            pb_mostrar.Visible = false;
            pb_ocultar.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.UseSystemPasswordChar = false;
            pb_mostrar2.Visible = false;
            pbocultar2.Visible = true;
        }

        private void pb_ocultar_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pb_mostrar.Visible = true;
            pb_ocultar.Visible = false;
        }

        private void pbocultar2_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.UseSystemPasswordChar = true;
            pb_mostrar2.Visible = true;
            pbocultar2.Visible = false;
        }
    }
}