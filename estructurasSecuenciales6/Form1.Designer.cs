namespace estructurasSecuenciales6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtladoa = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtladob = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pxcuadrado = new System.Windows.Forms.RichTextBox();
            this.pxrectangulo = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txtladob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtladoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese sus datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "lado a";
            // 
            // txtladoa
            // 
            this.txtladoa.Location = new System.Drawing.Point(103, 36);
            this.txtladoa.Name = "txtladoa";
            this.txtladoa.Size = new System.Drawing.Size(138, 20);
            this.txtladoa.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(305, 36);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(305, 65);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(305, 94);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "lado b";
            // 
            // txtladob
            // 
            this.txtladob.Location = new System.Drawing.Point(103, 94);
            this.txtladob.Name = "txtladob";
            this.txtladob.Size = new System.Drawing.Size(138, 20);
            this.txtladob.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtperimetro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtarea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(314, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 156);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(103, 94);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(138, 20);
            this.txtperimetro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "perimetro";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(103, 36);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(138, 20);
            this.txtarea.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "area";
            // 
            // pxcuadrado
            // 
            this.pxcuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pxcuadrado.Location = new System.Drawing.Point(76, 248);
            this.pxcuadrado.Name = "pxcuadrado";
            this.pxcuadrado.Size = new System.Drawing.Size(153, 133);
            this.pxcuadrado.TabIndex = 1;
            this.pxcuadrado.Text = "";
            // 
            // pxrectangulo
            // 
            this.pxrectangulo.BackColor = System.Drawing.Color.Green;
            this.pxrectangulo.Location = new System.Drawing.Point(43, 289);
            this.pxrectangulo.Name = "pxrectangulo";
            this.pxrectangulo.Size = new System.Drawing.Size(231, 50);
            this.pxrectangulo.TabIndex = 1;
            this.pxrectangulo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.pxrectangulo);
            this.Controls.Add(this.pxcuadrado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "figuras geometricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtladob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtladoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox pxcuadrado;
        private System.Windows.Forms.RichTextBox pxrectangulo;
    }
}

