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
    public partial class FrmRepresentante : Form
    {
        public FrmRepresentante(FrmActaLocal actaLocal, bool soyHYS)
        {
            InitializeComponent();
            this.actaLocal = actaLocal;
            this.soyHYS = soyHYS;
            if (soyHYS)
                this.Text = "Carga de Personal HYS";
            else
                this.Text = "Carga de Personal Medicina";

            this.lstRepresentante.DrawMode = DrawMode.OwnerDrawFixed;

            //Cartelito sobre el listbox
            this.ttip.SetToolTip(lstRepresentante, "Haga doble clic sobre el registro a modificar/eliminar");
        }

        FrmActaLocal actaLocal;
        internal bool soyHYS;
        internal int espaciosCuit = 20;
        internal int espaciosMatricula = 30;
        internal int espaciosCondCat = 6;


        private void FrmPersonalHYS_Load(object sender, EventArgs e)
        {
            Limpiar();
            txtCUIT.MaxLength = espaciosCuit;
            txtMatricula.MaxLength = espaciosMatricula;
            txtCategoria.MaxLength = espaciosCondCat;
            txtCondicion.MaxLength = espaciosCondCat;
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
            if (soyHYS)
                MostrarRegistrosHYS();
            else
                MostrarRegistrosMed();
            txtCUIT.Focus();
        }

        private void MostrarRegistrosMed()
        {
            lstRepresentante.Items.Clear();
            if (this.actaLocal.PersonalMedPropInternas.Count > 0)
            {
                foreach (var Med in this.actaLocal.PersonalMedPropInternas)
                {
                    lstRepresentante.Items.Add($"{Med.CUIT.value}{'*'.Repeat(espaciosCuit - Med.CUIT.value.Length + 1)}{Med.Matricula.value}{'*'.Repeat(espaciosMatricula - Med.Matricula.value.Length + 1)}{Med.Categoria.value}{'*'.Repeat(espaciosCondCat - Med.Categoria.value.Length + 1)}{Med.Condicion.value}{'*'.Repeat(espaciosCondCat - txtCondicion.Text.Length + 1)}");
                }
            }
        }

        private void MostrarRegistrosHYS()
        {
            lstRepresentante.Items.Clear();
            if (this.actaLocal.PersonalHYSPropInternas.Count > 0)
            {
                foreach (var personaHYS in this.actaLocal.PersonalHYSPropInternas)
                {
                    lstRepresentante.Items.Add($"{personaHYS.CUIT.value}{'*'.Repeat(espaciosCuit - personaHYS.CUIT.value.Length + 1)}{personaHYS.Matricula.value}{'*'.Repeat(espaciosMatricula - personaHYS.Matricula.value.Length + 1)}{personaHYS.Categoria.value}{'*'.Repeat(espaciosCondCat - personaHYS.Categoria.value.Length + 1)}{personaHYS.Condicion.value}{'*'.Repeat(espaciosCondCat - txtCondicion.Text.Length + 1)}");
                }
            }
        }

        private void Agregar()
        {
            lstRepresentante.Items.Add($"{txtCUIT.Text}{'*'.Repeat(espaciosCuit - txtCUIT.Text.Length + 1)}{txtMatricula.Text}{'*'.Repeat(espaciosMatricula - txtMatricula.Text.Length + 1)}{txtCategoria.Text}{'*'.Repeat(espaciosCondCat - txtCategoria.Text.Length + 1)}{txtCondicion.Text}{'*'.Repeat(espaciosCondCat - txtCondicion.Text.Length + 1)}");

            if (soyHYS)
                SetearPersonalHYSPropInternas();
            else
                SetearPersonalMedPropInternas();

            Limpiar();
        }

        private void SetearPersonalMedPropInternas()
        {
            this.actaLocal.PersonalMedPropInternas.Clear();
            this.actaLocal.txtPersonalMedicina.Text = "";
            if (lstRepresentante.Items.Count == 1)
            {
                this.actaLocal.PersonalMedPropInternas.Add(new EntidadActaLocal.Representante
                {
                    CUIT = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CUITMed_",
                        value = lstRepresentante.Items[0].ToString().Substring(0, espaciosCuit).Replace("*", "")
                    },
                    Matricula = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "MatriculaMed_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1, espaciosMatricula).Replace("*", "")
                    },
                    Categoria = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CategoriaMed_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1, espaciosCondCat).Replace("*", "")
                    },
                    Condicion = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CondicionMed_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1 + espaciosCondCat + 1).Replace("*", "")
                    }
                });

                this.actaLocal.txtPersonalMedicina.Text = "<Representante>\n<CUIT>{{CUITMed_}}</CUIT>\n<Matricula>{{MatriculaMed_}}</Matricula>\n<Categoria>{{CategoriaMed_}}</Categoria>\n<Condicion>{{CondicionMed_}}</Condicion>\n</Representante>";
            }
            else if (lstRepresentante.Items.Count > 1)
            {
                int contador = 0;
                string hijos = "";
                foreach (var Med in lstRepresentante.Items)
                {
                    this.actaLocal.PersonalMedPropInternas.Add(new EntidadActaLocal.Representante
                    {
                        CUIT = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CUITMed_{contador}",
                            value = Med.ToString().Substring(0, espaciosCuit).Replace("*", "")
                        },
                        Matricula = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"MatriculaMed_{contador}",
                            value = Med.ToString().Substring(espaciosCuit + 1, espaciosMatricula).Replace("*", "")
                        },
                        Categoria = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CategoriaMed_{contador}",
                            value = Med.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1, espaciosCondCat).Replace("*", "")
                        },
                        Condicion = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CondicionMed_{contador}",
                            value = Med.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1 + espaciosCondCat + 1).Replace("*", "")
                        }

                    });

                    hijos += "<Representante>\n<CUIT>{{CUITMed_" + contador + "}}</CUIT>\n<Matricula>{{MatriculaMed_" + contador + "}}</Matricula>\n<Categoria>{{CategoriaMed_" + contador + "}}</Categoria>\n<Condicion>{{CondicionMed_" + contador + "}}</Condicion>\n</Representante>";
                    contador++;
                }
                this.actaLocal.txtPersonalMedicina.Text = hijos;
            }
        }

        private void SetearPersonalHYSPropInternas()
        {
            this.actaLocal.PersonalHYSPropInternas.Clear();
            this.actaLocal.txtPersonalHYS.Text = "";
            if (lstRepresentante.Items.Count == 1)
            {
                this.actaLocal.PersonalHYSPropInternas.Add(new EntidadActaLocal.Representante
                {
                    CUIT = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CUITHYS_",
                        value = lstRepresentante.Items[0].ToString().Substring(0, espaciosCuit).Replace("*", "")
                    },
                    Matricula = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "MatriculaHYS_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1, espaciosMatricula).Replace("*", "")
                    },
                    Categoria = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CategoriaHYS_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1, espaciosCondCat).Replace("*", "")
                    },
                    Condicion = new EntidadActaLocal.BaseClassActaLocal
                    {
                        key = "CondicionHYS_",
                        value = lstRepresentante.Items[0].ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1 + espaciosCondCat + 1).Replace("*", "")
                    }
                });

                this.actaLocal.txtPersonalHYS.Text = "<Representante>\n<CUIT>{{CUITHYS_}}</CUIT>\n<Matricula>{{MatriculaHYS_}}</Matricula>\n<Categoria>{{CategoriaHYS_}}</Categoria>\n<Condicion>{{CondicionHYS_}}</Condicion>\n</Representante>";
            }
            else if (lstRepresentante.Items.Count > 1)
            {
                int contador = 0;
                string hijos = "";
                foreach (var HYS in lstRepresentante.Items)
                {
                    this.actaLocal.PersonalHYSPropInternas.Add(new EntidadActaLocal.Representante
                    {
                        CUIT = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CUITHYS_{contador}",
                            value = HYS.ToString().Substring(0, espaciosCuit).Replace("*", "")
                        },
                        Matricula = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"MatriculaHYS_{contador}",
                            value = HYS.ToString().Substring(espaciosCuit + 1, espaciosMatricula).Replace("*", "")
                        },
                        Categoria = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CategoriaHYS_{contador}",
                            value = HYS.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1, espaciosCondCat).Replace("*", "")
                        },
                        Condicion = new EntidadActaLocal.BaseClassActaLocal
                        {
                            key = $"CondicionHYS_{contador}",
                            value = HYS.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1 + espaciosCondCat + 1).Replace("*", "")
                        }

                    });

                    hijos += "<Representante>\n<CUIT>{{CUITHYS_" + contador + "}}</CUIT>\n<Matricula>{{MatriculaHYS_" + contador + "}}</Matricula>\n<Categoria>{{CategoriaHYS_" + contador + "}}</Categoria>\n<Condicion>{{CondicionHYS_" + contador + "}}</Condicion>\n</Representante>";
                    contador++;
                }
                this.actaLocal.txtPersonalHYS.Text = hijos;
            }
        }

        private void Eliminar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstRepresentante))
            {
                return;
            }
            var Op = MessageBox.Show("¿Desea eliminar este Registo?", "Verifique", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Op == DialogResult.Yes)
            {
                lstRepresentante.Items.Remove(lstRepresentante.SelectedItem);
                if (soyHYS)
                    SetearPersonalHYSPropInternas();
                else
                    SetearPersonalMedPropInternas();
            }
            Limpiar();
        }

        private void Modificar()
        {
            if (!FuncionesFriend._HayItemSeleccionado(this.lstRepresentante))
            {
                return;
            }
            lstRepresentante.Items.Remove(lstRepresentante.SelectedItem);
            Agregar();

        }

        private void lstRepresentante_DoubleClick(object sender, EventArgs e)
        {
            if (lstRepresentante.SelectedIndex != -1)
            {
                txtCUIT.Text = lstRepresentante.SelectedItem.ToString().Substring(0, espaciosCuit).Replace("*", "");
                txtMatricula.Text = lstRepresentante.SelectedItem.ToString().Substring(espaciosCuit + 1, espaciosMatricula).Replace("*", "");
                txtCategoria.Text = lstRepresentante.SelectedItem.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1, espaciosCondCat).Replace("*", "");
                txtCondicion.Text = lstRepresentante.SelectedItem.ToString().Substring(espaciosCuit + 1 + espaciosMatricula + 1 + espaciosCondCat + 1).Replace("*", "");

                FuncionesFriend.SetearHabilitacionBotonesDoubleClick(this);
            }
            else
            {
                MessageBox.Show("No selecciono ningún registro", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstRepresentante.Focus();
            }
        }

        private void lstRepresentante_DrawItem(object sender, DrawItemEventArgs e)
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

        private void lstRepresentante_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ListBox)sender).Refresh();
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }

        private void txtCondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FuncionesStd.EsAsterisco(e))
                e.Handled = true;
        }
    }
}
