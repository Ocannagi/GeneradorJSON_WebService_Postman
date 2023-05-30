
namespace GeneradorVariablesPostmanADUWS
{
    partial class FrmPersonaAtend_Gremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonaAtend_Gremio));
            this.label8 = new System.Windows.Forms.Label();
            this.lblCodList = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.lstPersona_Gremio = new System.Windows.Forms.ListBox();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblGremio = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Advertencia: se reservó el uso del signo asterisco para demarcar los espacios ent" +
    "re columnas en el ListBox";
            // 
            // lblCodList
            // 
            this.lblCodList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCodList.Location = new System.Drawing.Point(745, 208);
            this.lblCodList.Name = "lblCodList";
            this.lblCodList.Size = new System.Drawing.Size(44, 17);
            this.lblCodList.TabIndex = 33;
            this.lblCodList.Text = "Cód->";
            this.lblCodList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(559, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(192, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre y Apellido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(166, 85);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(239, 20);
            this.txtDNI.TabIndex = 30;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "DNI:";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(166, 111);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(239, 20);
            this.txtNombreApellido.TabIndex = 28;
            this.txtNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre y Apellido:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCodigo.Location = new System.Drawing.Point(39, 208);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(154, 17);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "DNI";
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
            this.toolStrip1.Location = new System.Drawing.Point(640, 171);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(148, 37);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
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
            // lstPersona_Gremio
            // 
            this.lstPersona_Gremio.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersona_Gremio.FormattingEnabled = true;
            this.lstPersona_Gremio.HorizontalExtent = 1100;
            this.lstPersona_Gremio.HorizontalScrollbar = true;
            this.lstPersona_Gremio.ItemHeight = 15;
            this.lstPersona_Gremio.Location = new System.Drawing.Point(38, 229);
            this.lstPersona_Gremio.Name = "lstPersona_Gremio";
            this.lstPersona_Gremio.ScrollAlwaysVisible = true;
            this.lstPersona_Gremio.Size = new System.Drawing.Size(750, 184);
            this.lstPersona_Gremio.TabIndex = 20;
            this.lstPersona_Gremio.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPersona_DrawItem);
            this.lstPersona_Gremio.SelectedIndexChanged += new System.EventHandler(this.lstPersona_SelectedIndexChanged);
            this.lstPersona_Gremio.DoubleClick += new System.EventHandler(this.lstPersona_DoubleClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(166, 163);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(239, 20);
            this.txtCodigo.TabIndex = 36;
            this.txtCodigo.Visible = false;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblGremio
            // 
            this.lblGremio.AutoSize = true;
            this.lblGremio.Enabled = false;
            this.lblGremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGremio.Location = new System.Drawing.Point(37, 164);
            this.lblGremio.Name = "lblGremio";
            this.lblGremio.Size = new System.Drawing.Size(102, 16);
            this.lblGremio.TabIndex = 35;
            this.lblGremio.Text = "Código Gremio:";
            this.lblGremio.Visible = false;
            // 
            // FrmPersonaAtend_Gremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblGremio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCodList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstPersona_Gremio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPersonaAtend_Gremio";
            this.Text = "FrmPersona";
            this.Load += new System.EventHandler(this.FrmPersonaAtend_Gremio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblCodList;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton tsAgregar;
        internal System.Windows.Forms.ToolStripButton tsEliminar;
        internal System.Windows.Forms.ToolStripButton tsModificar;
        internal System.Windows.Forms.ToolStripButton tsLimpiar;
        internal System.Windows.Forms.ListBox lstPersona_Gremio;
        private System.Windows.Forms.ToolTip ttip;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblGremio;
    }
}