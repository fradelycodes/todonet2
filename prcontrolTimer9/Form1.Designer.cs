namespace prcontrolTimer9
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbla = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.ForeColor = System.Drawing.Color.Coral;
            this.lbla.Location = new System.Drawing.Point(12, 149);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(340, 36);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "FRADELY DILONE";
            this.lbla.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(380, 118);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(122, 42);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(380, 179);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(122, 42);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(377, 73);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(52, 18);
            this.lblhora.TabIndex = 3;
            this.lblhora.Text = "label2";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblb.Location = new System.Drawing.Point(12, 149);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(340, 36);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "FRADELY DILONE";
            this.lblb.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(602, 290);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

