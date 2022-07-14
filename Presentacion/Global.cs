using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Global
    {
        public static void BotonesAccion(Button btnNuevo, Button btnGuardar, Button btnModificar, Button btnBuscar, Button btnCancelar, Button btnLimpiar, string Accion)
        {
            try
            {
                switch (Accion)
                {
                    case "Nuevo":
                        btnGuardar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnBuscar.Enabled = true;
                        btnLimpiar.Enabled = true;
                        btnNuevo.Enabled = false;                       
                        break;
                    case "Guardar":
                        btnNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnBuscar.Enabled = false;
                        btnLimpiar.Enabled = false;
                        break;
                    case "Cancelar":
                        btnNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnBuscar.Enabled = false;
                        btnLimpiar.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void Limpiar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if(item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                    else if(item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Clear();
                    }
                }
           
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void Habilitar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if(item is TextBox)
                    {
                        ((TextBox)item).Enabled = true;
                    }
                    else if(item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Enabled = true;
                    }
                    else if(item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Enabled = true;
                    }
                    else if (item is RadioButton)
                    {
                        ((RadioButton)item).Enabled = true;
                    }
                    else if(item is ComboBox)
                    {
                        ((ComboBox)item).Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Desabilitar(Panel contenedor)
        {
            try
            {
                foreach (var item in contenedor.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Enabled = false;
                    }
                    else if (item is MaskedTextBox)
                    {
                        ((MaskedTextBox)item).Enabled = false;
                    }
                    else if (item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Enabled = false;
                    }
                    else if (item is RadioButton)
                    {
                        ((RadioButton)item).Enabled = false;
                    }
                    else if (item is ComboBox)
                    {
                        ((ComboBox)item).Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool ValidaTextBoxVacios(Panel Contenedor)
        {

            foreach (Control control in Contenedor.Controls)
            {

                if (control.GetType().Equals(typeof(TextBox)))
                {

                    if (control.Text.Equals(""))
                    {                      
                        return false;
                    }
                }
                else if(control.GetType().Equals(typeof(MaskedTextBox)))
                {
                    if(control.Text.Equals(""))
                    {                      
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
