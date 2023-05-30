using System;
using GeneradorVariablesPostmanADUWS.EntidadActaLocal;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GeneradorVariablesPostmanADUWS.Funciones
{
    internal class FuncionesFriend
    {
        public static void GuardarArchivo(string stringJson, bool soyLocal)
        {
            try
            {
                using (SaveFileDialog saveFD = new SaveFileDialog())
                {
                    saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    if (soyLocal)
                        saveFD.Filter = "Archivo ActaLocal | *.json";
                    else
                        saveFD.Filter = "Archivo ActaIteracion | *.json";

                    saveFD.DefaultExt = "json";
                    if (saveFD.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFD.FileName))
                        {
                            writer.WriteLine(stringJson);
                            writer.Close();
                            MessageBox.Show("Archivo guardado correctamente");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new CustomExceptionActaLocal("AL00", $"Se produjo un error al inentar guardar el archivo\n {ex.Message}");
            }
        }

        public static void SetearHabilitacionBotonesLimpiar(FrmInspectoresSecundarios formulario)
        {
            formulario.tsEliminar.Enabled = false;
            formulario.tsModificar.Enabled = false;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = true;
        }

        public static void SetearHabilitacionBotonesLimpiar(FrmRepresentante formulario)
        {
            formulario.tsEliminar.Enabled = false;
            formulario.tsModificar.Enabled = false;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = true;
        }

        public static void SetearHabilitacionBotonesLimpiar(FrmPersonaAtend_Gremio formulario)
        {
            formulario.tsEliminar.Enabled = false;
            formulario.tsModificar.Enabled = false;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = true;
        }

        public static void SetearHabilitacionBotonesLimpiar(FrmConsideraciones formulario)
        {
            formulario.tsEliminar.Enabled = false;
            formulario.tsModificar.Enabled = false;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = true;
        }

        public static void SetearHabilitacionBotonesDoubleClick(FrmInspectoresSecundarios formulario)
        {
            formulario.tsEliminar.Enabled = true;
            formulario.tsModificar.Enabled = true;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = false;
        }

        public static void SetearHabilitacionBotonesDoubleClick(FrmRepresentante formulario)
        {
            formulario.tsEliminar.Enabled = true;
            formulario.tsModificar.Enabled = true;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = false;
        }

        public static void SetearHabilitacionBotonesDoubleClick(FrmPersonaAtend_Gremio formulario)
        {
            formulario.tsEliminar.Enabled = true;
            formulario.tsModificar.Enabled = true;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = false;
        }

        public static void SetearHabilitacionBotonesDoubleClick(FrmConsideraciones formulario)
        {
            formulario.tsEliminar.Enabled = true;
            formulario.tsModificar.Enabled = true;
            formulario.tsLimpiar.Enabled = true;
            formulario.tsAgregar.Enabled = false;
        }

        public static bool _HayItemSeleccionado(ListBox listBox)
        {
            bool respuesta = true;
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox.Focus();
                respuesta = false;
            }
            return respuesta;
        }

        public static void DrawItemAmarillito(object sender, DrawItemEventArgs e)
        {


            e.DrawBackground();
            Brush amarillito = new SolidBrush(Color.LemonChiffon);
            Brush negro = Brushes.Black;
            e.Graphics.FillRectangle(amarillito, e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, negro, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();


        }

        public static void DrawItemAzul(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush azul = new SolidBrush(Color.Blue);
            Brush blanco = Brushes.White;
            e.Graphics.FillRectangle(azul, e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, blanco, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

        }


    }


}

