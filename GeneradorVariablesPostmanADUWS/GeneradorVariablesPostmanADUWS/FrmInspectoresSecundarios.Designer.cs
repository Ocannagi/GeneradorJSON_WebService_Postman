
namespace GeneradorVariablesPostmanADUWS
{
    partial class FrmInspectoresSecundarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInspectoresSecundarios));
            this.lstInspecSecun = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodInspector = new System.Windows.Forms.TextBox();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.tsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInspecSecun
            // 
            this.lstInspecSecun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstInspecSecun.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInspecSecun.FormattingEnabled = true;
            this.lstInspecSecun.ItemHeight = 15;
            this.lstInspecSecun.Location = new System.Drawing.Point(152, 188);
            this.lstInspecSecun.Name = "lstInspecSecun";
            this.lstInspecSecun.Size = new System.Drawing.Size(496, 169);
            this.lstInspecSecun.TabIndex = 0;
            this.lstInspecSecun.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstInspecSecun_DrawItem);
            this.lstInspecSecun.SelectedIndexChanged += new System.EventHandler(this.lstInspecSecun_SelectedIndexChanged);
            this.lstInspecSecun.DoubleClick += new System.EventHandler(this.lstInspecSecun_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregar,
            this.tsEliminar,
            this.tsModificar,
            this.tsLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(500, 131);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(148, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCodigo.Location = new System.Drawing.Point(152, 168);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(496, 17);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código Inspector Secundario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cód. Inspector:";
            // 
            // txtCodInspector
            // 
            this.txtCodInspector.Location = new System.Drawing.Point(255, 93);
            this.txtCodInspector.Name = "txtCodInspector";
            this.txtCodInspector.Size = new System.Drawing.Size(132, 20);
            this.txtCodInspector.TabIndex = 4;
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
            // FrmInspectoresSecundarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodInspector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstInspecSecun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInspectoresSecundarios";
            this.Text = "Carga de Inspectores Secundarios";
            this.Load += new System.EventHandler(this.FrmInspectoresSecundarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodInspector;
        internal System.Windows.Forms.ToolStripButton tsAgregar;
        internal System.Windows.Forms.ToolStripButton tsEliminar;
        internal System.Windows.Forms.ToolStripButton tsModificar;
        internal System.Windows.Forms.ToolStripButton tsLimpiar;
        internal System.Windows.Forms.ListBox lstInspecSecun;
        private System.Windows.Forms.ToolTip ttip;
    }
}