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
    public partial class Frm_Venta : Form
    {


        //private bool Modificar;
        public Frm_Venta()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            try
            {
                N_FacturaCliente N_Venta = new N_FacturaCliente();
                dgvVenta.DataSource = N_Venta.ListaFacCliente();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null)
                return;

            dgvVenta.Rows.Remove(dgvVenta.CurrentRow);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Global.BotonesAccion(btnNuevo, btn_Vender, btnModificar, btn_añadir, btnCancelar, btnLimpiar, btnNuevo.Text);
            btnVender.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnBuscarEmpleado.Enabled = true;
            btnBuscarProd.Enabled = true;
            Global.Habilitar(paneldetalle);
            Global.Habilitar(panelventa);
            Global.Habilitar(panelv);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelventa);
        }
        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            //CargarGrid();
            dgvVenta.AllowUserToAddRows = false;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    E_FacturaCliente Venta = new E_FacturaCliente
                    {                       
                        Id_Cliente = Convert.ToInt32(txtnombre.Tag.ToString()),
                        Cod_Empleado = Convert.ToInt32(IdEmpleado.Tag.ToString()),
                        Cod_Inventario = Convert.ToInt32(txtPrecio.Tag.ToString()),
                        Cod_Productos = Convert.ToInt32(txtProducto.Tag.ToString()),
                        ID = Convert.ToInt32(txtCategoria.Tag.ToString()),
                        FormaPago = row.Cells["pago"].Value.ToString(),
                        Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                        Subtotal = Convert.ToDouble(row.Cells["subtotal"].Value),
                        IVA = Convert.ToDouble(row.Cells["iva"].Value),
                        Descuento = Convert.ToDouble(row.Cells["descuento"].Value),
                        Total = Convert.ToDouble(row.Cells["total"].Value)
                    };
                    N_FacturaCliente n_FacturaCliente = new N_FacturaCliente();
                    n_FacturaCliente.Guardar(Venta);
                }
                MessageBox.Show("Se guardo exitosamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvVenta.Rows.Clear();
                Global.Limpiar(paneldetalle);
                Global.Limpiar(panelventa);
                Global.Limpiar(panel_producto);
                Global.Limpiar(panelv);
                Global.BotonesAccion(btnNuevo, btn_Vender, btnModificar, btn_añadir, btnCancelar, btnLimpiar, "Guardar");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Frm_FiltroClientes frmCliente = new Frm_FiltroClientes(this);
            frmCliente.ShowDialog();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            Frm_FiltroEmpleado FiltroEmpleado = new Frm_FiltroEmpleado(this);
            FiltroEmpleado.ShowDialog();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            Frm_FiltroInventario frm_FiltroInventario = new Frm_FiltroInventario(this);
            frm_FiltroInventario.ShowDialog();
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            double Cantidad = Convert.ToDouble(nudCantidad.Value);
            double Precio = Convert.ToDouble(txtPrecio.Text);
            double SubtotalAntesdeIVA = Cantidad * Precio;
            txtSubtotal.Text = SubtotalAntesdeIVA.ToString();
            double Iva = (SubtotalAntesdeIVA * 0.15);
            double subtotal = Iva + SubtotalAntesdeIVA;
            TxtIVA.Text = Iva.ToString();
            double Descuento = Convert.ToDouble(txtDescuento.Text);
            double Total = (subtotal - Descuento);
            Txttotal2.Text = Total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, btn_Vender, btnModificar, btn_añadir, btnCancelar, btnLimpiar, btnCancelar.Text);

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //Reportes.Reporte_Ventas reporte_Ventas = new Reportes.Reporte_Ventas();
            //reporte_Ventas.Show();
            //Mostrar ventas
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Global.ValidaTextBoxVacios(panel_producto) == false && Global.ValidaTextBoxVacios(panelventa) == false)
            {
                MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Se usan else if para evitar mostrar más de un mensaje
            else if (Global.ValidaTextBoxVacios(panelventa) == false)
            {
                MessageBox.Show("Debes agregar los datos del cliente y vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Global.ValidaTextBoxVacios(panel_producto) == false)
            {
                MessageBox.Show("Debes agregar algún Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudCantidad.Value==0)
            {
                MessageBox.Show("La cantidad de productos no puede ser 0 ¡Por favor, verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvVenta);
                fila.Cells[0].Value = txtProducto.Tag.ToString(); //Codigo
                fila.Cells[1].Value = txtProducto.Text.ToString(); //Nombre del producto
                fila.Cells[2].Value = txtCategoria.Text.ToString(); //Categoria
                fila.Cells[3].Value = nudCantidad.Value.ToString(); //Cantidad
                fila.Cells[4].Value = txtPrecio.Text.ToString();    //Precio
                fila.Cells[5].Value = txtSubtotal.Text.ToString(); //Subtotal
                fila.Cells[6].Value = TxtIVA.Text.ToString();   //IVA
                fila.Cells[7].Value = txtDescuento.Text.ToString(); //Descuento
                fila.Cells[8].Value = Txttotal2.Text.ToString(); //Total
                if (RbtEfectivo.Checked == true)
                {
                    fila.Cells[9].Value = "Efectivo";
                }
                else
                {
                    fila.Cells[9].Value = "Credito";
                }
                dgvVenta.Rows.Add(fila);
                nudCantidad.Value = 0;
            }
        }
    }
}

