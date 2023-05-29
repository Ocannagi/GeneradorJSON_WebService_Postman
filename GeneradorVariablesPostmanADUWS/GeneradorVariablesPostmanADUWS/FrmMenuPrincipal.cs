using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmActaLocal actaLocal;
        public FrmIteracion iteracion;
        
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnActaLocal_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.actaLocal = new FrmActaLocal(this, true);
            actaLocal.Show();
        }

        private void btnActaRun_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.iteracion = new FrmIteracion(this);
            iteracion.Show();

        }
    }
}
