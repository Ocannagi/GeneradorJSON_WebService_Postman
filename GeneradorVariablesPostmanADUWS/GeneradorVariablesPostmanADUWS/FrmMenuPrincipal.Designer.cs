
namespace GeneradorVariablesPostmanADUWS
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnActaLocal = new System.Windows.Forms.Button();
            this.btnActaRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActaLocal
            // 
            this.btnActaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActaLocal.Location = new System.Drawing.Point(107, 127);
            this.btnActaLocal.Name = "btnActaLocal";
            this.btnActaLocal.Size = new System.Drawing.Size(289, 45);
            this.btnActaLocal.TabIndex = 0;
            this.btnActaLocal.Text = "Generar Acta para correr local en Postman";
            this.btnActaLocal.UseVisualStyleBackColor = false;
            this.btnActaLocal.Click += new System.EventHandler(this.btnActaLocal_Click);
            // 
            // btnActaRun
            // 
            this.btnActaRun.BackColor = System.Drawing.Color.MistyRose;
            this.btnActaRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActaRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActaRun.Location = new System.Drawing.Point(107, 225);
            this.btnActaRun.Name = "btnActaRun";
            this.btnActaRun.Size = new System.Drawing.Size(289, 45);
            this.btnActaRun.TabIndex = 1;
            this.btnActaRun.Text = "Generar una o más Actas para correr en el Run collection de Postman o en Newman";
            this.btnActaRun.UseVisualStyleBackColor = false;
            this.btnActaRun.Click += new System.EventHandler(this.btnActaRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido al Generador de Variables de Acta para Postman";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GeneradorVariablesPostmanADUWS.Properties.Resources.Logo_SRT_Horizontal_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActaRun);
            this.Controls.Add(this.btnActaLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Variables Postman ADU WS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActaLocal;
        private System.Windows.Forms.Button btnActaRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

