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

namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmPersonaAtend_Gremio : Form
    {
        public FrmPersonaAtend_Gremio(FrmActaLocal actaLocal, bool soyGremio)
        {
            InitializeComponent();
            this.actaLocal = actaLocal;
            this.soyGremio = soyGremio;
            this.lstPersona_Gremio.DrawMode = DrawMode.OwnerDrawFixed;
            //Cartelito sobre el listbox
            this.ttip.SetToolTip(lstPersona_Gremio, "Haga doble clic sobre el registro a modificar/eliminar");
        }

        FrmActaLocal actaLocal;
        internal int espaciosDNI = 15;
        internal int espaciosNomYApellido = 60;
        internal int espaciosEmail = 60;
        internal bool soyGremio;

        private void FrmPersonaAtend_Gremio_Load(object sender, EventArgs e)
        {
            Limpiar();
            txtDNI.MaxLength = espaciosDNI;
            txtNombreApellido.MaxLength = espaciosNomYApellido;
            txtEmail.MaxLength = espaciosEmail;
            Limpiar();// en este formulario es necesario llamar dos veces a Limpiar para que se habiliten los botones correspondientes en PersonaAtendio
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tsAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }


        private void Limpiar()
        {
            FuncionesStd.LimpiarCampos(this.Controls);
            
            if (soyGremio)
            {
                FuncionesFriend.SetearHabilitacionBotonesLimpiar(this);
            }
            else
            {
                if (lstPersona_Gremio.Items.Count == 0)
                    FuncionesFriend.SetearHabilitacionBotonesLimpiar(this);
                else
                    SetearHabilitacionBotonesLimpiarPersonaAtendio();
                
                MostrarRegistrosPersonaAtendio();
                txtDNI.Focus();
            }

        }

        private void SetearHabilitacionBotonesLimpiarPersonaAtendio()
        {
            tsEliminar.Enabled = false;
            tsModificar.Enabled = false;
            tsLimpiar.Enabled = false;
            tsAgregar.Enabled = false;
            txtDNI.Enabled = false;
            txtNombreApellido.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void MostrarRegistrosPersonaAtendio()
        {
            lstPersona_Gremio.Items.Clear();
            if (FrmActaLocal.PersonaAtendioPropInternas != null)
            {

                lstPersona_Gremio.Items.Add($"{FrmActaLocal.PersonaAtendioPropInternas.DNI.value}{'*'.Repeat(espaciosDNI - FrmActaLocal.PersonaAtendioPropInternas.DNI.value.Length + 1)}{FrmActaLocal.PersonaAtendioPropInternas.NombreApellido.value}{'*'.Repeat(espaciosNomYApellido - FrmActaLocal.PersonaAtendioPropInternas.NombreApellido.value.Length + 1)}{FrmActaLocal.PersonaAtendioPropInternas.Email.value}{'*'.Repeat(espaciosEmail - FrmActaLocal.PersonaAtendioPropInternas.Email.value.Length + 1)}");
            }
        }

        private void Agregar()
        {
            lstPersona_Gremio.Items.Add($"{txtDNI.Text}{'*'.Repeat(espaciosDNI - txtDNI.Text.Length + 1)}{txtNombreApellido.Text}{'*'.Repeat(espaciosNomYApellido - txtNombreApellido.Text.Length + 1)}{txtEmail.Text}{'*'.Repeat(espaciosEmail - txtEmail.Text.Length + 1)}");

            if (soyGremio)
            {

            }
            else
            {
                SetearPersonaAtendio();
            }

            Limpiar();
        }

        private void SetearPersonaAtendio()
        {
            FrmActaLocal.PersonaAtendioPropInternas = null;
            this.actaLocal.txtPersonaAtendio.Text = "";
            if (lstPersona_Gremio.Items.Count == 1)
            {
                FrmActaLocal.PersonaAtendioPropInternas = new EntidadActaLocal.Persona
                {
                    DNI = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "DNIAtendio",
                        value = lstPersona_Gremio.Items[0].ToString().Substring(0, espaciosDNI).Replace("*", "")
                    },
                    NombreApellido = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "NombreApellidoAtendio",
                        value = lstPersona_Gremio.Items[0].ToString().Substring(espaciosDNI + 1, espaciosNomYApellido).Replace("*", "")
                    },
                    Email = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "EmailAtendio",
                        value = lstPersona_Gremio.Items[0].ToString().Substring(espaciosDNI + 1 + espaciosNomYApellido + 1, espaciosEmail).Replace("*", "")
                    }
                };

                this.actaLocal.txtPersonaAtendio.Text = "<DNI>{{DNIAtendio}}</DNI>\n<NombreApellido>{{NombreApellidoAtendio}}</NombreApellido>\n<Email>{{EmailAtendio}}</Email>";
            }

        }

        private void Eliminar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstPersona_Gremio))
            {
                return;
            }
            var Op = MessageBox.Show("¿Desea eliminar este Registo?", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Op == DialogResult.Yes)
            {
                lstPersona_Gremio.Items.Remove(lstPersona_Gremio.SelectedItem);
                SetearPersonaAtendio();
            }
            Limpiar();
        }

        private void Modificar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstPersona_Gremio))
            {
                return;
            }
            lstPersona_Gremio.Items.Remove(lstPersona_Gremio.SelectedItem);
            Agregar();
        }

        private void lstPersona_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersona_Gremio.SelectedIndex != -1)
            {
                txtDNI.Text = lstPersona_Gremio.SelectedItem.ToString().Substring(0, espaciosDNI).Replace("*", "");
                txtNombreApellido.Text = lstPersona_Gremio.SelectedItem.ToString().Substring(espaciosDNI + 1, espaciosNomYApellido).Replace("*", "");
                txtEmail.Text = lstPersona_Gremio.SelectedItem.ToString().Substring(espaciosDNI + 1 + espaciosNomYApellido + 1, espaciosEmail).Replace("*", "");

                FuncionesFriend.SetearHabilitacionBotonesDoubleClick(this);
                if(!soyGremio)
                {
                    txtDNI.Enabled = true;
                    txtNombreApellido.Enabled = true;
                    txtEmail.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningún registro", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstPersona_Gremio.Focus();
            }
        }

        private void lstPersona_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                if (e.Index != ((ListBox)sender).SelectedIndex)
                {
                    FuncionesFriend.DrawItemAmarillo(sender, e);
                }
                else
                {
                    FuncionesFriend.DrawItemAzul(sender, e);
                }
            }
        }

        private void lstPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ListBox)sender).Refresh();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }
    }
}
