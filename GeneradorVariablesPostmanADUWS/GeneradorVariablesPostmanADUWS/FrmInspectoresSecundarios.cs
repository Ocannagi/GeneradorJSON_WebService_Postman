using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorVariablesPostmanADUWS.Funciones;


namespace GeneradorVariablesPostmanADUWS
{
    public partial class FrmInspectoresSecundarios : Form
    {
        public FrmInspectoresSecundarios(FrmActaLocal actaLocal)
        {
            InitializeComponent();
            this.actaLocal = actaLocal;
            this.lstInspecSecun.DrawMode = DrawMode.OwnerDrawFixed;// Para pesonalizar el ListBox(como el QA puede necesitar declarar una variable como vacío, necesitaba que un color resaltara el item vacío)
            //Cartelito sobre el listbox
            this.ttip.SetToolTip(lstInspecSecun, "Haga doble clic sobre el registro a modificar/eliminar");
        }

        FrmActaLocal actaLocal;


        private void FrmInspectoresSecundarios_Load(object sender, EventArgs e)
        {
            Limpiar();
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
            FuncionesFriend.SetearHabilitacionBotonesLimpiar(this);
            MostrarRegistros();
            txtCodInspector.Focus();
        }

        private void MostrarRegistros()
        {
            lstInspecSecun.Items.Clear();
            if (this.actaLocal.InspectoresSecPropInternas.Count > 0)
            {
                foreach (var inspector in this.actaLocal.InspectoresSecPropInternas)
                {
                    lstInspecSecun.Items.Add($"{inspector.value}");
                }
            }
        }

        private void Agregar()
        {
            lstInspecSecun.Items.Add(txtCodInspector.Text);
            SetearInspectoresSecPropInternas();
            Limpiar();
        }



        private void SetearInspectoresSecPropInternas()
        {

            this.actaLocal.InspectoresSecPropInternas.Clear();
            this.actaLocal.txtInspectoresSecundarios.Text = "";
            if (lstInspecSecun.Items.Count == 1)
            {
                this.actaLocal.InspectoresSecPropInternas.Add(new EntidadActaLocal.BaseClassActaLocal { key = "intInspector_", value = lstInspecSecun.Items[0].ToString() });

                this.actaLocal.txtInspectoresSecundarios.Text = "<int>{{intInspector_}}</int>";
            }
            else if (lstInspecSecun.Items.Count > 1)
            {
                int contador = 0;
                string hijos = "";
                foreach (var inspector in lstInspecSecun.Items)
                {
                    this.actaLocal.InspectoresSecPropInternas.Add(new EntidadActaLocal.BaseClassActaLocal { key = $"intInspector_{contador}", value = inspector.ToString() });
                    hijos += "<int>{{intInspector_" + contador + "}}</int>\n";
                    contador++;
                }
                this.actaLocal.txtInspectoresSecundarios.Text = hijos;
            }
        }



        private void Eliminar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstInspecSecun))
            {
                return;
            }
            var Op = MessageBox.Show("¿Desea eliminar este Registo?", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Op == DialogResult.Yes)
            {
                lstInspecSecun.Items.Remove(lstInspecSecun.SelectedItem);
                SetearInspectoresSecPropInternas();
            }
            Limpiar();
        }

        private void Modificar() 
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstInspecSecun))
            {
                return;
            }
            lstInspecSecun.Items.Remove(lstInspecSecun.SelectedItem);
            Agregar();

        }

        private void lstInspecSecun_DoubleClick(object sender, EventArgs e)
        {
            if (lstInspecSecun.SelectedIndex != -1)
            {
                txtCodInspector.Text = lstInspecSecun.SelectedItem.ToString();
                FuncionesFriend.SetearHabilitacionBotonesDoubleClick(this);
            }
            else
            {
                MessageBox.Show("No selecciono ningún registro", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstInspecSecun.Focus();
            }

        }

        private void lstInspecSecun_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1)
            {
                if(e.Index != ((ListBox)sender).SelectedIndex)
                {
                    FuncionesFriend.DrawItemAmarillito(sender, e);
                }
                else
                {
                    FuncionesFriend.DrawItemAzul(sender, e);
                }
            }
        }

        private void lstInspecSecun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ListBox)sender).Refresh();
        }
    }
}
