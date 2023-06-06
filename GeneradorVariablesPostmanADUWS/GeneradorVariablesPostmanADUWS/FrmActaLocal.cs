using GeneradorVariablesPostmanADUWS.EntidadActaLocal;
using GeneradorVariablesPostmanADUWS.Funciones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text.Json;
using System.Windows.Forms;

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmActaLocal : Form
    {
        private List<BaseClassActaLocal> actaLocal = new List<BaseClassActaLocal>();
        internal List<BaseClassActaLocal> InspectoresSecPropInternas = new List<BaseClassActaLocal>();
        internal List<Representante> PersonalHYSPropInternas = new List<Representante>();
        internal List<Representante> PersonalMedPropInternas = new List<Representante>();
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
        bool esGuardadoIteracion;

        public FrmActaLocal(FrmMenuPrincipal menuPrincipal, bool esActaLocal, FrmIteracion iteracion = null)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.iteracion = iteracion;
            this.esActaLocal = esActaLocal;

            this.ttipCodigo.SetToolTip(lblCodigo, "El Código se encuentra deshabilitado. La Colección de Postman está seteada para completar el valor con lo que devuelve el método Alta");

            this.ttipActaVerificada.SetToolTip(txtActaVerificada, "Si completa el campo 'Acta Verificada', tenga en cuenta que deberá modificar el Body del Método Alta y quitar el 'xsi:nil=\"true\"' de la etiqueta de este campo");
            
            if (esActaLocal)
            {
                this.Text = "Acta para correr local en Postman";
                this.btnJSON.Text = "Generar JSON";
                pcbSRT.Image = Properties.Resources.Logo_SRT_Horizontal_02;
            }
            else
            {
                this.Text = "Acta para correr dentro de una Iteración en la Run Collection de Postman";
                this.BackColor = Color.MistyRose;
                this.btnJSON.Text = "Guardar Iteración";
                pcbSRT.Image = Properties.Resources.Logo_SRT_Horizontal_03;
                this.esGuardadoIteracion = false;
            }

        }

        private void FrmActaLocal_Load(object sender, EventArgs e)
        {
            this.txtNumero.Focus();
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
            this.esGuardadoIteracion = true;
            this.Close();
        }

        private void CargarListaIteracion(Control.ControlCollection controls, dynamic actaIteracion)
        {
            foreach (var control in controls)
            {
                if (control is TextBox && (control as TextBox).Enabled == true)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{(control as TextBox).Name.Substring(3)}", (control as TextBox).Text);
                }
            }
            CargarInspectoresIteracion(actaIteracion);
            CargarPersHYSIteracion(actaIteracion);
            CargarPersMedIteracion(actaIteracion);
            CargarPersonaAtendioIteracion(actaIteracion);
            CargarGremioIteracion(actaIteracion);
            CargarConsideracionesIteracion(actaIteracion);
            this.iteracion.ListaIteraciones.Add(actaIteracion);
        }

        private void CargarConsideracionesIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"Consideraciones", $"{txtConsideraciones.Text}");

            if (txtConsideraciones.Text != "")
            {
                foreach (var cons in ConsideracionPropInternas)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{cons.Codigo.key}", $"{cons.Codigo.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{cons.Observacion.key}", $"{cons.Observacion.value}");
                }
            }
        }

        private void CargarGremioIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"PersonalGremio", $"{txtPersonalGremio.Text}");

            if (txtPersonalGremio.Text != "")
            {
                foreach (var gremio in GremioPropInternas)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{gremio.Codigo.key}", $"{gremio.Codigo.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{gremio.DNI.key}", $"{gremio.DNI.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{gremio.NombreApellido.key}", $"{gremio.NombreApellido.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{gremio.Email.key}", $"{gremio.Email.value}");
                }
            }
        }

        private void CargarPersonaAtendioIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"PersonaAtendio", $"{txtPersonaAtendio.Text}");

            if (txtPersonaAtendio.Text != "")
            {
                ((IDictionary<String, Object>)actaIteracion).Add($"{PersonaAtendioPropInternas.DNI.key}", $"{PersonaAtendioPropInternas.DNI.value}");
                ((IDictionary<String, Object>)actaIteracion).Add($"{PersonaAtendioPropInternas.NombreApellido.key}", $"{PersonaAtendioPropInternas.NombreApellido.value}");
                ((IDictionary<String, Object>)actaIteracion).Add($"{PersonaAtendioPropInternas.Email.key}", $"{PersonaAtendioPropInternas.Email.value}");
            }
        }

        private void CargarPersMedIteracion(dynamic actaIteracion)
        {
            ((IDictionary<String, Object>)actaIteracion).Add($"PersonalMedicina", $"{txtPersonalMedicina.Text}");

            if (txtPersonalMedicina.Text != "")
            {
                foreach (var Med in PersonalMedPropInternas)
                {
                    ((IDictionary<String, Object>)actaIteracion).Add($"{Med.CUIT.key}", $"{Med.CUIT.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{Med.Matricula.key}", $"{Med.Matricula.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{Med.Categoria.key}", $"{Med.Categoria.value}");
                    ((IDictionary<String, Object>)actaIteracion).Add($"{Med.Condicion.key}", $"{Med.Condicion.value}");
                }
            }
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
            ((IDictionary<String, Object>)actaIteracion).Add($"InspectoresSecundarios", $"{txtInspectoresSecundarios.Text}");
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
            FuncionesFriend.GuardarArchivo(stringJSON, esActaLocal);
        }

        private void CargarListaActaLocal(Control.ControlCollection controls, bool esModificacion = false)
        {
            string marca;// Esta marca es un principio para poder hacer las variables de Modificación. En sí, queda a medio hacer hasta que exista la posibilidad de continuar con este desarrollo. La idea es crear un formulario que tenga los mismos parámetros que ya fueron cargados para el alta y que se pueda modificar. En caso de que no se opte por esta opción, entregar una tanda de variables "M"(para el método módificar) con valores idénticos a los del alta
            if (esModificacion)
                marca = "_M";
            else
                marca = "";

            foreach (var control in controls)
            {
                if (control is TextBox && (control as TextBox).Enabled == true)
                {
                    actaLocal.Add(new BaseClassActaLocal { key = $"{(control as TextBox).Name.Substring(3)}{marca}", value = (control as TextBox).Text });
                }
            }

            CargarInspectoresLocal(marca);
            CargarPersHYSLocal(marca);
            CargarPersMedLocal(marca);
            CargarPersonaAtendioLocal(marca);
            CargarGremioLocal(marca);
            CargarConsideracionesLocal(marca);

        }


        private void CargarConsideracionesLocal(string marca)
        {
            actaLocal.Add(new BaseClassActaLocal { key = $"Consideraciones{marca}", value = $"{txtConsideraciones.Text}" });

            if (txtConsideraciones.Text != "")
            {
                List<BaseClassActaLocal> varInterna = new List<BaseClassActaLocal>();
                foreach (var cons in ConsideracionPropInternas)
                {
                    varInterna.Add(new BaseClassActaLocal { key = cons.Codigo.key + marca, value = cons.Codigo.value, type = cons.Codigo.type });
                    varInterna.Add(cons.Observacion);
                }
                actaLocal.AddRange(varInterna);
            }
        }

        private void CargarGremioLocal(string marca)
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

        private void CargarPersonaAtendioLocal(string marca)
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

        private void CargarPersMedLocal(string marca)
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

        private void CargarPersHYSLocal(string marca)
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

        private void CargarInspectoresLocal(string marca)
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

        private void FrmActaLocal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Op;
            if (esActaLocal)
            {
                Op = MessageBox.Show("¿Está seguro de que quiere cerrar el Acta? La información de la presente Acta Local se perderá", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Op == DialogResult.No)
                    e.Cancel = true;
            }
            else if (!this.esGuardadoIteracion)
            {
                Op = MessageBox.Show("¿Está seguro de que quiere cerrar el Acta? La información de la presente iteración se perderá", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Op == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void txtActaVerificada_Enter(object sender, EventArgs e)
        {
            ttipActaVerificada.Show("Si completa el campo 'Acta Verificada', tenga en cuenta que deberá modificar el Body del Método Alta y quitar el 'xsi:nil=\"true\"' de la etiqueta de este campo",txtActaVerificada);
            
        }

        private void txtActaVerificada_Leave(object sender, EventArgs e)
        {
            ttipActaVerificada.Hide(txtActaVerificada);
        }
    }
}
