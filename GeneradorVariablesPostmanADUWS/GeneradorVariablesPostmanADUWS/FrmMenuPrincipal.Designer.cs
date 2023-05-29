
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
            this.btnActaLocal = new System.Windows.Forms.Button();
            this.btnActaRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActaLocal
            // 
            this.btnActaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActaLocal.Location = new System.Drawing.Point(107, 127);
            this.btnActaLocal.Name = "btnActaLocal";
            this.btnActaLocal.Size = new System.Drawing.Size(289, 45);
            this.btnActaLocal.TabIndex = 0;
            this.btnActaLocal.Text = "Generar Acta para correr local en Postman";
            this.btnActaLocal.UseVisualStyleBackColor = true;
            this.btnActaLocal.Click += new System.EventHandler(this.btnActaLocal_Click);
            // 
            // btnActaRun
            // 
            this.btnActaRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActaRun.Location = new System.Drawing.Point(107, 225);
            this.btnActaRun.Name = "btnActaRun";
            this.btnActaRun.Size = new System.Drawing.Size(289, 45);
            this.btnActaRun.TabIndex = 1;
            this.btnActaRun.Text = "Generar una o más Actas para correr en el Run collection de Postman o en Newman";
            this.btnActaRun.UseVisualStyleBackColor = true;
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
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActaRun);
            this.Controls.Add(this.btnActaLocal);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Variables Postman ADU WS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActaLocal;
        private System.Windows.Forms.Button btnActaRun;
        private System.Windows.Forms.Label label1;
    }
}

