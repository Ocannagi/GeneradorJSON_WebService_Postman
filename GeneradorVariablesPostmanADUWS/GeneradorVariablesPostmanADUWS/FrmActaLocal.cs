using GeneradorVariablesPostmanADUWS.EntidadActaLocal;
using GeneradorVariablesPostmanADUWS.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmActaLocal : Form
    {
        private static List<BaseClassActaLocal> actaLocal = new List<BaseClassActaLocal>();
        internal static List<BaseClassActaLocal> InspectoresSecPropInternas = new List<BaseClassActaLocal>();
        internal static List<Representante> PersonalHYSPropInternas = new List<Representante>();
        internal static List<Representante> PersonalMedPropInternas = new List<Representante>();
        internal static Persona PersonaAtendioPropInternas = null; 

        private bool esActaLocal;
        FrmMenuPrincipal menuPrincipal;
        FrmInspectoresSecundarios inspectoresSecundarios;
        FrmRepresentante personalHYS;
        FrmRepresentante personalMed;
        FrmPersonaAtend_Gremio personaAtendio;

        public FrmActaLocal(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.esActaLocal = menuPrincipal.esActaLocal;
            this.menuPrincipal = menuPrincipal;
        }

        private void FrmActaLocal_Load(object sender, EventArgs e)
        {

        }

        private void FrmActaLocal_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            CargarListaActaLocal(this.Controls);


            var options = new JsonSerializerOptions { WriteIndented = true };
            var stringJSON = JsonSerializer.Serialize(actaLocal, options);
            stringJSON = stringJSON.Replace("\\u003C", "<").Replace("\\u003E", ">");
            FuncionesFriend.GuardarArchivo(stringJSON);
        }

        private void CargarListaActaLocal(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    actaLocal.Add(new BaseClassActaLocal { key = $"{(control as TextBox).Name.Substring(3)}", value = (control as TextBox).Text });
                }
            }

            CargarInspectoresLocal();
            CargarPersHYSLocal();
            CargarPersMedLocal();
            CargarPersonaAtendio();

        }

        private void CargarPersonaAtendio()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "PersonaAtendio", value = $"{txtPersonaAtendio.Text}" });

            if (txtPersonaAtendio.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                varInterna.Add(PersonaAtendioPropInternas.DNI);
                varInterna.Add(PersonaAtendioPropInternas.NombreApellido);
                varInterna.Add(PersonaAtendioPropInternas.Email);
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarPersMedLocal()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "PersonalMedicina", value = $"{txtPersonalMedicina.Text}" });

            if (txtPersonalMedicina.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                foreach (var Med in PersonalMedPropInternas)
                {
                    varInterna.Add(Med.CUIT);
                    varInterna.Add(Med.Matricula);
                    varInterna.Add(Med.Categoria);
                    varInterna.Add(Med.Condicion);
                }
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarPersHYSLocal()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "PersonalHYS", value = $"{txtPersonalHYS.Text}" });
            if(txtPersonalHYS.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                foreach (var HYS in PersonalHYSPropInternas)
                {
                    varInterna.Add(HYS.CUIT);
                    varInterna.Add(HYS.Matricula);
                    varInterna.Add(HYS.Categoria);
                    varInterna.Add(HYS.Condicion);
                }
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarInspectoresLocal()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "InspectoresSecundarios", value = $"{txtInspectoresSecundarios.Text}" });
            if (txtInspectoresSecundarios.Text != "")
                actaLocal.AddRange(InspectoresSecPropInternas);
        }

        private void btnInspSec_Click(object sender, EventArgs e)
        {
            this.inspectoresSecundarios = new FrmInspectoresSecundarios(this);
            inspectoresSecundarios.ShowDialog();
        }

        private void btnPersHYS_Click(object sender, EventArgs e)
        {
            this.personalHYS = new FrmRepresentante(this,true);
            personalHYS.ShowDialog();
        }

        private void btnPersMed_Click(object sender, EventArgs e)
        {
            this.personalMed = new FrmRepresentante(this, false);
            personalMed.ShowDialog();
        }

        private void btnPersAtend_Click(object sender, EventArgs e)
        {
            this.personaAtendio = new FrmPersonaAtend_Gremio(this, false);
            personaAtendio.ShowDialog();
        }
    }
}
