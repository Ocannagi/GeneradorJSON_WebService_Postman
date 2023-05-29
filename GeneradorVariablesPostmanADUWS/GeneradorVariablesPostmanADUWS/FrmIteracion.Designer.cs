
namespace GeneradorVariablesPostmanADUWS
{
    partial class FrmIteracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIteracion));
            this.label4 = new System.Windows.Forms.Label();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.btnIteracion = new System.Windows.Forms.Button();
            this.btnJsonIter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Iteraciones:";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(106, 81);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.ReadOnly = true;
            this.txtIteraciones.Size = new System.Drawing.Size(111, 20);
            this.txtIteraciones.TabIndex = 16;
            // 
            // btnIteracion
            // 
            this.btnIteracion.Location = new System.Drawing.Point(77, 179);
            this.btnIteracion.Name = "btnIteracion";
            this.btnIteracion.Size = new System.Drawing.Size(140, 39);
            this.btnIteracion.TabIndex = 17;
            this.btnIteracion.Text = "Generar nueva Iteracion";
            this.btnIteracion.UseVisualStyleBackColor = true;
            this.btnIteracion.Click += new System.EventHandler(this.btnIteracion_Click);
            // 
            // btnJsonIter
            // 
            this.btnJsonIter.Location = new System.Drawing.Point(331, 179);
            this.btnJsonIter.Name = "btnJsonIter";
            this.btnJsonIter.Size = new System.Drawing.Size(140, 39);
            this.btnJsonIter.TabIndex = 18;
            this.btnJsonIter.Text = "Generar JSON";
            this.btnJsonIter.UseVisualStyleBackColor = true;
            this.btnJsonIter.Click += new System.EventHandler(this.btnJsonIter_Click);
            // 
            // FrmIteracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonIter);
            this.Controls.Add(this.btnIteracion);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIteracion";
            this.Text = "Carga de Iteraciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIteracion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Button btnIteracion;
        private System.Windows.Forms.Button btnJsonIter;
    }
}