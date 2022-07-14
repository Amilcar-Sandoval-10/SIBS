
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

namespace Presentacion
{
    public partial class Frm_Presentacion : Form
    {
        public Frm_Presentacion()
        {
            InitializeComponent();

        }

        //Metodo para abrir formulario dentro del panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
           "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FrmCliente>();
            SidePanel.Visible = true;
            SidePanel.Height = btnCliente.Height;
            SidePanel.Top = btnCliente.Top;
        }
        
        
        private void btnInventario_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<FrmInventario>();
            SidePanel.Visible = true;
            SidePanel.Height = btnInventario.Height;
            SidePanel.Top = btnInventario.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Compras>();
            SidePanel.Visible = true;
            SidePanel.Height = btnCompras.Height;
            SidePanel.Top = btnCompras.Top;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Venta>();
            SidePanel.Visible = true;
            SidePanel.Height = btnVentas.Height;
            SidePanel.Top = btnVentas.Top;
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            //Reporte_Ventas reporte_Ventas = new Reporte_Ventas();
            //reporte_Ventas.ShowDialog();
        }

        private void btnrptInventario_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            //Reporte_Inventario reporte = new Reporte_Inventario();
            //reporte.ShowDialog();

        }
        private void AbrirFormHijo(object formhijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Proveedor>();
            SidePanel.Visible = true;
            SidePanel.Height = btnProveedor.Height;
            SidePanel.Top = btnProveedor.Top;

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEmpleados>();
            SidePanel.Visible = true;
            SidePanel.Height = btnEmpleados.Height;
            SidePanel.Top = btnEmpleados.Top;

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Frm_Usuario usuario = new Frm_Usuario();
            usuario.ShowDialog();
            SidePanel.Visible = true;
            SidePanel.Height = btnUsuario.Height;
            SidePanel.Top = btnUsuario.Top;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            //Reporte_Compra reporte = new Reporte_Compra();
            //reporte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            Acerca acerca = new Acerca();
            acerca.ShowDialog();
        }
        
    }
}
