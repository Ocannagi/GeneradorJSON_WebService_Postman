using GeneradorVariablesPostmanADUWS.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmIteracion : Form
    {
        FrmMenuPrincipal menuPrincipal;
        FrmActaLocal actaIteracion;
        internal List<ExpandoObject> ListaIteraciones = new List<ExpandoObject>();
        private bool esActaLocal = false;

        public FrmIteracion(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            ActualizarContadorIteraciones();
            
        }

        internal void ActualizarContadorIteraciones()
        {
            this.txtIteraciones.Text = ListaIteraciones.Count.ToString();
        }

        private void FrmIteracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menuPrincipal.Show();
        }

        private void btnIteracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.actaIteracion = new FrmActaLocal(menuPrincipal, esActaLocal, this);
            actaIteracion.Show();
        }

        private void btnJsonIter_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var stringJSON = JsonSerializer.Serialize(ListaIteraciones, options);
            stringJSON = stringJSON.Replace("\\u003C", "<").Replace("\\u003E", ">");
            FuncionesFriend.GuardarArchivo(stringJSON, esActaLocal);
        }

        private void txtIteraciones_TextChanged(object sender, EventArgs e)
        {
            if (txtIteraciones.Text == "0")
                btnJsonIter.Enabled = false;
            else
                btnJsonIter.Enabled = true;
        }
    }
}
