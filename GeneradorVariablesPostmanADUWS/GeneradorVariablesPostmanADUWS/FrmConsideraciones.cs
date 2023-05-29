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
    public partial class FrmConsideraciones : Form
    {
        public FrmConsideraciones(FrmActaLocal actaLocal)
        {
            InitializeComponent();
            this.actaLocal = actaLocal;
            this.lstConsideraciones.DrawMode = DrawMode.OwnerDrawFixed;

            //Cartelito sobre el listbox
            this.ttip.SetToolTip(lstConsideraciones, "Haga doble clic sobre el registro a modificar/eliminar");
        }

        FrmActaLocal actaLocal;
        internal int espaciosCodigo = 6;
        internal int espaciosObservacion = 100;

        private void FrmConsideraciones_Load(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.MaxLength = espaciosCodigo;
            txtObservacion.MaxLength = espaciosObservacion;
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
            txtCodigo.Focus();
        }

        private void MostrarRegistros()
        {
            lstConsideraciones.Items.Clear();
            if (this.actaLocal.ConsideracionPropInternas.Count > 0)
            {
                foreach (var Cons in this.actaLocal.ConsideracionPropInternas)
                {
                    lstConsideraciones.Items.Add($"{Cons.Codigo.value}{'*'.Repeat(espaciosCodigo - Cons.Codigo.value.Length + 1)}{Cons.Observacion.value}{'*'.Repeat(espaciosObservacion - Cons.Observacion.value.Length + 1)}");
                }
            }
        }

        private void Agregar()
        {
            lstConsideraciones.Items.Add($"{txtCodigo.Text}{'*'.Repeat(espaciosCodigo - txtCodigo.Text.Length + 1)}{txtObservacion.Text}{'*'.Repeat(espaciosObservacion - txtObservacion.Text.Length + 1)}");

            SetearPropInternas();
            Limpiar();
        }

        private void SetearPropInternas()
        {
            this.actaLocal.ConsideracionPropInternas.Clear();
            this.actaLocal.txtConsideraciones.Text = "";
            if (lstConsideraciones.Items.Count == 1)
            {
                this.actaLocal.ConsideracionPropInternas.Add(new EntidadActaLocal.Consideracion
                {
                    Codigo = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CodigoConsi_",
                        value = lstConsideraciones.Items[0].ToString().Substring(0, espaciosCodigo).Replace("*", "")
                    },
                    Observacion = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "ObservacionConsi_",
                        value = lstConsideraciones.Items[0].ToString().Substring(espaciosCodigo + 1, espaciosObservacion).Replace("*", "")
                    }
                });

                this.actaLocal.txtConsideraciones.Text = "<Consideracion>\n<Codigo>{{CodigoConsi_}}</Codigo>\n<Observacion>{{ObservacionConsi_}}</Observacion>\n</Consideracion>";
            }
            else if (lstConsideraciones.Items.Count > 1)
            {
                int contador = 0;
                string hijos = "";
                foreach (var Cons in lstConsideraciones.Items)
                {
                    this.actaLocal.ConsideracionPropInternas.Add(new EntidadActaLocal.Consideracion
                    {
                        Codigo = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CodigoConsi_{contador}",
                            value = Cons.ToString().Substring(0, espaciosCodigo).Replace("*", "")
                        },
                        Observacion = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"ObservacionConsi_{contador}",
                            value = Cons.ToString().Substring(espaciosCodigo + 1, espaciosObservacion).Replace("*", "")
                        }
                    });

                    hijos += "<Consideracion>\n<Codigo>{{CodigoConsi_" + contador + "}}</Codigo>\n<Observacion>{{ObservacionConsi_" + contador + "}}</Observacion>\n</Consideracion>";
                    contador++;
                }
                this.actaLocal.txtConsideraciones.Text = hijos;
            }
        }

        private void Eliminar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstConsideraciones))
            {
                return;
            }
            var Op = MessageBox.Show("¿Desea eliminar este Registo?", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Op == DialogResult.Yes)
            {
                lstConsideraciones.Items.Remove(lstConsideraciones.SelectedItem);
                SetearPropInternas();
            }
            Limpiar();
        }

        private void Modificar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstConsideraciones))
            {
                return;
            }
            lstConsideraciones.Items.Remove(lstConsideraciones.SelectedItem);
            Agregar();
        }

        private void lstConsideraciones_DoubleClick(object sender, EventArgs e)
        {
            if (lstConsideraciones.SelectedIndex != -1)
            {
                txtCodigo.Text = lstConsideraciones.SelectedItem.ToString().Substring(0, espaciosCodigo).Replace("*", "");
                txtObservacion.Text = lstConsideraciones.SelectedItem.ToString().Substring(espaciosCodigo + 1, espaciosObservacion).Replace("*", "");

                FuncionesFriend.SetearHabilitacionBotonesDoubleClick(this);
            }
            else
            {
                MessageBox.Show("No selecciono ningún registro", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstConsideraciones.Focus();
            }
        }

        private void lstConsideraciones_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                if (e.Index != ((ListBox)sender).SelectedIndex)
                {
                    FuncionesFriend.DrawItemAmarillito(sender, e);
                }
                else
                {
                    FuncionesFriend.DrawItemAzul(sender, e);
                }
            }
        }

        private void lstConsideraciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ListBox)sender).Refresh();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }
    }
}
