
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Iteraciones:";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(383, 174);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.ReadOnly = true;
            this.txtIteraciones.Size = new System.Drawing.Size(111, 20);
            this.txtIteraciones.TabIndex = 16;
            this.txtIteraciones.TabStop = false;
            this.txtIteraciones.TextChanged += new System.EventHandler(this.txtIteraciones_TextChanged);
            // 
            // btnIteracion
            // 
            this.btnIteracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIteracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIteracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIteracion.Location = new System.Drawing.Point(203, 265);
            this.btnIteracion.Name = "btnIteracion";
            this.btnIteracion.Size = new System.Drawing.Size(140, 39);
            this.btnIteracion.TabIndex = 1;
            this.btnIteracion.Text = "Generar nueva Iteracion";
            this.btnIteracion.UseVisualStyleBackColor = false;
            this.btnIteracion.Click += new System.EventHandler(this.btnIteracion_Click);
            // 
            // btnJsonIter
            // 
            this.btnJsonIter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJsonIter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJsonIter.Location = new System.Drawing.Point(457, 265);
            this.btnJsonIter.Name = "btnJsonIter";
            this.btnJsonIter.Size = new System.Drawing.Size(140, 39);
            this.btnJsonIter.TabIndex = 2;
            this.btnJsonIter.Text = "Generar JSON";
            this.btnJsonIter.UseVisualStyleBackColor = false;
            this.btnJsonIter.Click += new System.EventHandler(this.btnJsonIter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GeneradorVariablesPostmanADUWS.Properties.Resources.Logo_SRT_Horizontal_03;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIteracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJsonIter);
            this.Controls.Add(this.btnIteracion);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIteracion";
            this.Text = "Carga de Iteraciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIteracion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIteracion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Button btnIteracion;
        private System.Windows.Forms.Button btnJsonIter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}