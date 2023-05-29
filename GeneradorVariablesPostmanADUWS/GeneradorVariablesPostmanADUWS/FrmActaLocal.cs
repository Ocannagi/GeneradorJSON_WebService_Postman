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
using System.Dynamic;

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmActaLocal : Form
    {
        private List<BaseClassActaLocal> actaLocal = new List<BaseClassActaLocal>();
        internal List<BaseClassActaLocal> InspectoresSecPropInternas = new List<BaseClassActaLocal>();
        internal List<Representante> PersonalHYSPropInternas = new List<Representante>();
        internal  List<Representante> PersonalMedPropInternas = new List<Representante>();
        internal Persona PersonaAtendioPropInternas = null;
        internal List<Gremio> GremioPropInternas = new List<Gremio>();
        internal List<Consideracion> ConsideracionPropInternas = new List<Consideracion>();

        FrmMenuPrincipal menuPrincipal;
        FrmIteracion iteracion;
        FrmInspectoresSecundarios inspectoresSecundarios;
        FrmRepresentante personalHYS;
        FrmRepresentante personalMed;
        FrmPersonaAtend_Gremio personaAtendio;
        FrmPersonaAtend_Gremio gremio;
        FrmConsideraciones consideraciones;

        bool esActaLocal;

        public FrmActaLocal(FrmMenuPrincipal menuPrincipal, bool esActaLocal, FrmIteracion iteracion = null)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.iteracion = iteracion;
            this.esActaLocal = esActaLocal;
            if (esActaLocal)
            {
                this.Text = "Acta para correr local en Postman";
                this.btnJSON.Text = "Generar JSON";
            }
            else
            {
                this.Text = "Acta para correr dentro de una Iteración en la Run Collection de Postman";
                this.BackColor = Color.MistyRose;
                this.btnJSON.Text = "Guardar Iteración";
            }

        }

        private void FrmActaLocal_Load(object sender, EventArgs e)
        {

        }

        private void FrmActaLocal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (esActaLocal)
                menuPrincipal.Show();
            else
                iteracion.Show();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            if (esActaLocal)
                GuardarActaLocal();
            else
            {
                dynamic ActaIteracion = new ExpandoObject();
                GenerarIteracion(ActaIteracion);
            }
        }

        private void GenerarIteracion(dynamic actaIteracion)
        {
            CargarListaIteracion(this.Controls, actaIteracion);
            this.iteracion.ActualizarContadorIteraciones();
            this.iteracion.Show();
            this.Close();
        }

        private void CargarListaIteracion(Control.ControlCollection controls, dynamic actaIteracion)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{(control as TextBox).Name.Substring(3)}", (control as TextBox).Text);
                }
            }

            CargarInspectoresIteracion(actaIteracion);
            CargarPersHYSIteracion(actaIteracion);


            //Agregar complejos aquí

            this.iteracion.ListaIteraciones.Add(actaIteracion);
        }

        private void CargarPersHYSIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"PersonalHYS", $"{txtPersonalHYS.Text}");

            if (txtPersonalHYS.Text != "")
            {
                foreach (var HYS in PersonalHYSPropInternas)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{HYS.CUIT.key}", $"{HYS.CUIT.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{HYS.Matricula.key}", $"{HYS.Matricula.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{HYS.Categoria.key}", $"{HYS.Categoria.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{HYS.Condicion.key}", $"{HYS.Condicion.value}");
                }
            }
        }

        private void CargarInspectoresIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"InspectoresSecundarios",$"{txtInspectoresSecundarios.Text}");
            if (txtInspectoresSecundarios.Text != "")
            {
                foreach (var inspector in InspectoresSecPropInternas)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{inspector.key}", $"{inspector.value}");
                }
            }
        }

        private void GuardarActaLocal()
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
            CargarPersonaAtendioLocal();
            CargarGremioLocal();
            CargarConsideracionesLocal();

        }

        private void CargarConsideracionesLocal()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "Consideraciones", value = $"{txtConsideraciones.Text}" });

            if (txtConsideraciones.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                foreach (var cons in ConsideracionPropInternas)
                {
                    varInterna.Add(cons.Codigo);
                    varInterna.Add(cons.Observacion);
                }
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarGremioLocal()
        {
            actaLocal.Add(new BaseClassActaLocal { key = "PersonalGremio", value = $"{txtPersonalGremio.Text}" });

            if (txtPersonalGremio.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                foreach (var gremio in GremioPropInternas)
                {
                    varInterna.Add(gremio.Codigo);
                    varInterna.Add(gremio.DNI);
                    varInterna.Add(gremio.NombreApellido);
                    varInterna.Add(gremio.Email);
                }
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarPersonaAtendioLocal()
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
            if (txtPersonalHYS.Text != "")
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
            this.personalHYS = new FrmRepresentante(this, true);
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

        private void btnPersGrem_Click(object sender, EventArgs e)
        {
            this.gremio = new FrmPersonaAtend_Gremio(this, true);
            gremio.ShowDialog();
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            this.consideraciones = new FrmConsideraciones(this);
            consideraciones.ShowDialog();
        }
    }
}
