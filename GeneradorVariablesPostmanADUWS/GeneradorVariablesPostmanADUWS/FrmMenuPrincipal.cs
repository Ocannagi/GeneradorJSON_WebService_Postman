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
        internal bool esActaLocal = false;

        public FrmActaLocal actaLocal;
        
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnActaLocal_Click(object sender, EventArgs e)
        {
            esActaLocal = true;
            this.Hide();
            this.actaLocal = new FrmActaLocal(this);
            actaLocal.Show();
        }
    }
}
