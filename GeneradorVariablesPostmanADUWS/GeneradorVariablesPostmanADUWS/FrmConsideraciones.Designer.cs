
namespace GeneradorVariablesPostmanADUWS
{
    partial class FrmConsideraciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsideraciones));
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lstConsideraciones = new System.Windows.Forms.ListBox();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.tsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Advertencia: se reservó el uso del signo asterisco para demarcar los espacios ent" +
    "re columnas en el ListBox";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(180, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(596, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Observación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 20);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Codigo:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(129, 101);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacion.Size = new System.Drawing.Size(468, 81);
            this.txtObservacion.TabIndex = 28;
            this.txtObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Observacion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCodigo.Location = new System.Drawing.Point(27, 209);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(154, 17);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregar,
            this.tsEliminar,
            this.tsModificar,
            this.tsLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(628, 172);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(148, 37);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lstConsideraciones
            // 
            this.lstConsideraciones.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsideraciones.FormattingEnabled = true;
            this.lstConsideraciones.ItemHeight = 15;
            this.lstConsideraciones.Location = new System.Drawing.Point(26, 230);
            this.lstConsideraciones.Name = "lstConsideraciones";
            this.lstConsideraciones.Size = new System.Drawing.Size(750, 184);
            this.lstConsideraciones.TabIndex = 20;
            this.lstConsideraciones.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstConsideraciones_DrawItem);
            this.lstConsideraciones.SelectedIndexChanged += new System.EventHandler(this.lstConsideraciones_SelectedIndexChanged);
            this.lstConsideraciones.DoubleClick += new System.EventHandler(this.lstConsideraciones_DoubleClick);
            // 
            // tsAgregar
            // 
            this.tsAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAgregar.Image = global::GeneradorVariablesPostmanADUWS.Properties.Resources.agregar;
            this.tsAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAgregar.Name = "tsAgregar";
            this.tsAgregar.Size = new System.Drawing.Size(34, 34);
            this.tsAgregar.Text = "Agregar";
            this.tsAgregar.ToolTipText = "Agregar";
            this.tsAgregar.Click += new System.EventHandler(this.tsAgregar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = global::GeneradorVariablesPostmanADUWS.Properties.Resources.eliminar;
            this.tsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(34, 34);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.ToolTipText = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // tsModificar
            // 
            this.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar.Image = global::GeneradorVariablesPostmanADUWS.Properties.Resources.modificar;
            this.tsModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(34, 34);
            this.tsModificar.Text = "Modificar";
            this.tsModificar.ToolTipText = "Modificar";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsLimpiar
            // 
            this.tsLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLimpiar.Image = global::GeneradorVariablesPostmanADUWS.Properties.Resources.limpiar;
            this.tsLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiar.Name = "tsLimpiar";
            this.tsLimpiar.Size = new System.Drawing.Size(34, 34);
            this.tsLimpiar.Text = "Limpiar";
            this.tsLimpiar.Click += new System.EventHandler(this.tsLimpiar_Click);
            // 
            // FrmConsideraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstConsideraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsideraciones";
            this.Text = "Carga de Consideraciones";
            this.Load += new System.EventHandler(this.FrmConsideraciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton tsAgregar;
        internal System.Windows.Forms.ToolStripButton tsEliminar;
        internal System.Windows.Forms.ToolStripButton tsModificar;
        internal System.Windows.Forms.ToolStripButton tsLimpiar;
        internal System.Windows.Forms.ListBox lstConsideraciones;
        private System.Windows.Forms.ToolTip ttip;
    }
}