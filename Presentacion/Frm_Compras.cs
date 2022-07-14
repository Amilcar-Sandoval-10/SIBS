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
    public partial class Frm_Compras : Form
    {
        public Frm_Compras()
        {
            InitializeComponent();
        }
      
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Frm_FiltroProveedor filtroProveedor = new Frm_FiltroProveedor(this);
            filtroProveedor.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, btnAñadir, btnModificar, btn_Comprar, btnCancelar, btnLimpiar, btnNuevo.Text);
            btnVender.Enabled = true;
            btnBuscarProd.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btn_agregar.Enabled = true;
            Global.Habilitar(paneldetalle);
            Global.Habilitar(panelcompra);
            Global.Habilitar(panelc);
        }
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            FiltroInventarioB frm_FiltroInventario = new FiltroInventarioB(this);
            frm_FiltroInventario.ShowDialog();
        }
        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            //CargarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Global.BotonesAccion(btnNuevo, btnAñadir, btnModificar, btn_Comprar, btnCancelar, btnLimpiar, btnCancelar.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Global.Limpiar(paneldetalle);
            Global.Limpiar(panelcompra);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (Global.ValidaTextBoxVacios(panel_producto) == false && Global.ValidaTextBoxVacios(panelcompra) == false)
            {
                MessageBox.Show("Debes llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Se usan else if para evitar mostrar más de un mensaje
            else if (Global.ValidaTextBoxVacios(panelcompra) == false)
            {
                MessageBox.Show("Debes agregar los datos del proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Global.ValidaTextBoxVacios(panel_producto) == false)
            {
                MessageBox.Show("Debes agregar algún Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nudCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad de productos no puede ser 0 ¡Por favor, verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvCompra);
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
                dgvCompra.Rows.Add(fila);
                nudCantidad.Value = 0;
                txtPrecio.Text = "0.00";
                txtDescuento.Text = "0.00";
                Txttotal2.Text = "0.00";
                Global.Limpiar(panel_producto);

            }

        }
        private void btnBuscarProd_Click_1(object sender, EventArgs e)
        {
            FiltroInventarioB filtro = new FiltroInventarioB(this);
            filtro.ShowDialog();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.CurrentRow == null)
                return;

            dgvCompra.Rows.Remove(dgvCompra.CurrentRow);
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            //Reportes.Reporte_Compra compra = new Reportes.Reporte_Compra();
            //compra.Show();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            try
            {   //Un solo for permite el recorrido por filas
                for (int fila = 0; fila < dgvCompra.Rows.Count - 1; fila++)
                {                       //Se evita que recorra demás con el -1
                        E_FacturaCompra Compra = new E_FacturaCompra
                        {
                            Cod_Proveedor = Convert.ToInt32(txtnombre.Tag.ToString()),
                            Cod_Productos = Convert.ToInt32(txtProducto.Tag.ToString()),
                            ID = Convert.ToInt32(txtCategoria.Tag.ToString()),
                            Cod_Inventario = Convert.ToInt32(txtPrecio.Tag.ToString()),
                            FormaPago = dgvCompra.Rows[fila].Cells["pago"].Value.ToString(),
                            Cantidad = Convert.ToInt32(dgvCompra.Rows[fila].Cells["cantidad"].Value.ToString()),
                            Subtotal = Convert.ToDouble(dgvCompra.Rows[fila].Cells["subtotal"].Value.ToString()),
                            IVA = Convert.ToDouble(dgvCompra.Rows[fila].Cells["iva"].Value.ToString()),
                            Descuento = Convert.ToDouble(dgvCompra.Rows[fila].Cells["descuento"].Value.ToString()),
                            Total = Convert.ToDouble(dgvCompra.Rows[fila].Cells["total"].Value.ToString())
                        };
                        N_FacturaCompracs n_FacturaCompra = new N_FacturaCompracs();
                        n_FacturaCompra.Guardar(Compra);                   
                }              
                MessageBox.Show("Compra Realizada Correctamente", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCompra.Rows.Clear();
                Global.Limpiar(paneldetalle);
                Global.Limpiar(panelcompra);
                Global.Limpiar(panel_producto);
                Global.Limpiar(panelc);
                Global.BotonesAccion(btnNuevo, btnAñadir, btnModificar, btn_Comprar, btnCancelar, btnLimpiar, "Guardar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
