using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Login : Form
    {
        int contador = 3;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CrearBordeRedondeado
     (
      int nIzquierda,  //cordenada x de la esquina superior izquierda
      int nArriba,  // cordenada y de la esquina superior izquierda
      int nDerecha, // cordenada x de la esquina inferior derecha
      int nAbajo, // coordenada y de la esquina inferior derecha 
      int nAlto, // altura de la elipce 
      int nAncho // anchura de la elipce
     );
        public Login()
        {
            InitializeComponent();
            //Iniciado el programa se aplica el Borde
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CrearBordeRedondeado(0, 0, Width, Height, 100, 100));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcontraseña.Checked == true)
            {
                txtcontraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }
        private void ListarTipo()
        {
            N_Usuario NegocioTipo = new N_Usuario();
            cmbTipo.DataSource = NegocioTipo.ListaUsuario();
            cmbTipo.DisplayMember = "Tipo_Usuario";
            cmbTipo.ValueMember = "Id_Usuario";
        }
        private void BtnAcceso_Click(object sender, EventArgs e)
        {
            ingreso();
        }

        private void ingreso() //Reduce volver a escribir este mismo codigo en el evento keypress
        {
            try
            {
                if (txtusuario.Text == "")
                {
                    errorUsuario.SetError(txtusuario, "Ingrese el Usuario");
                    return;
                }
                else if (txtcontraseña.Text == "")
                {
                    errorUsuario.SetError(txtusuario, "");
                    errorContraseña.SetError(txtcontraseña, "Ingrese la Contraseña");
                    return;
                }
                else
                {
                    errorUsuario.SetError(txtusuario, "");
                    errorContraseña.SetError(txtcontraseña, "");

                    E_Usuario Acceso = new E_Usuario
                    {
                        Usuario = txtusuario.Text,
                        Contraseña = txtcontraseña.Text
                    };

                    N_Usuario n_Usuario = new N_Usuario();
                    if (contador >= 1)
                    {
                        if (n_Usuario.Acceso(Acceso))
                        {
                            if (cmbTipo.Text == "Administrador")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.btnrptventa.Enabled = true;
                                Presentacion.btnUsuario.Enabled = true;
                                Presentacion.btnCliente.Enabled = true;
                                Presentacion.btnEmpleados.Enabled = true;
                                Presentacion.btnInventario.Enabled = true;
                                Presentacion.btnVentas.Enabled = true;
                                Presentacion.btnCompras.Enabled = true;
                                Presentacion.btnProveedor.Enabled = true;
                                Presentacion.btnrptInventario.Enabled = true;
                                Presentacion.btnrptventa.Enabled = true;
                                Presentacion.btnrptcompra.Enabled = true;
                                Presentacion.button1.Enabled = true;
                                Presentacion.lbUsuario.Text = cmbTipo.Text;
                                Presentacion.Show();
                                this.Hide();
                            }
                            else if (cmbTipo.Text == "Comprador")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.btnCompras.Enabled = true;
                                Presentacion.btnrptcompra.Enabled = true;
                                Presentacion.btnProveedor.Enabled = true;
                                Presentacion.button1.Enabled = true;
                                Presentacion.lbUsuario.Text = cmbTipo.Text;
                                Presentacion.Show();
                                this.Hide();
                            }
                            else if (cmbTipo.Text == "Gerente")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.Show();
                                Presentacion.btnrptventa.Enabled = true;
                                Presentacion.btnUsuario.Enabled = true;
                                Presentacion.btnCliente.Enabled = true;
                                Presentacion.btnEmpleados.Enabled = true;
                                Presentacion.btnInventario.Enabled = true;
                                Presentacion.btnVentas.Enabled = true;
                                Presentacion.btnCompras.Enabled = true;
                                Presentacion.btnProveedor.Enabled = true;
                                Presentacion.btnrptInventario.Enabled = true;
                                Presentacion.btnrptventa.Enabled = true;
                                Presentacion.btnrptcompra.Enabled = true;
                                Presentacion.button1.Enabled = true;
                                Presentacion.lbUsuario.Text = cmbTipo.Text;
                                this.Hide();
                            }
                            else if (cmbTipo.Text == "Bodega")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.Show();
                                Presentacion.btnInventario.Enabled = true;
                                Presentacion.button1.Enabled = true;
                                Presentacion.btnrptInventario.Enabled = true;
                                Presentacion.lbUsuario.Text = cmbTipo.Text;
                                this.Hide();
                            }
                            else if (cmbTipo.Text == "Vendedor")
                            {
                                MessageBox.Show("Bienvenido", txtusuario.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_Presentacion Presentacion = new Frm_Presentacion();
                                Presentacion.Show();
                                Presentacion.btnVentas.Enabled = true;
                                Presentacion.btnCliente.Enabled = true;
                                Presentacion.button1.Enabled = true;
                                Presentacion.btnrptventa.Enabled = true;
                                Presentacion.lbUsuario.Text = cmbTipo.Text;
                                this.Hide();
                            }

                        }
                        else
                        {
                            lberror.Visible = true;
                            txtcontraseña.Text = "";
                            contador = (contador - 1);
                            lbIntentos.Visible = true;
                            lbIntentos.Text = "Intentos restantes: " + contador;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A excedido el número de intentos disponibles para ingresar al sistema", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ListarTipo();
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Al precionar enter se ejecuta el mismo codigo que al hacer click en Ingresar
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingreso();
            }
        }
        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            //Cambiar al siguiente textbox al precionar enter UwU
            if (e.KeyCode == Keys.Enter && ActiveControl != null)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
    }
}
