using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorVariablesPostmanADUWS.Funciones
{
    public static class FuncionesStd
    {

        public static void LimpiarCampos(Control.ControlCollection contenedor)
        {
            foreach (Control control in contenedor)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();
                else if (control is NumericUpDown)
                    ((NumericUpDown)control).Value = 0;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control.HasChildren)
                    LimpiarCampos(control.Controls);
            }
        }

        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }

        public static bool EsAsterisco(KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[*]");
            return regex.IsMatch(e.KeyChar.ToString());
        }

    }
}
