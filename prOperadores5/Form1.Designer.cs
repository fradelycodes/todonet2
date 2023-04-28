namespace prOperadores5
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpotencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdivision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmultiplicacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtraiz = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnlimpiar);
            this.groupbox1.Controls.Add(this.btncalcular);
            this.groupbox1.Controls.Add(this.txtnumero1);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.txtnumero2);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Location = new System.Drawing.Point(12, 33);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(586, 155);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Operadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "numero 2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(115, 76);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(159, 20);
            this.txtnumero2.TabIndex = 1;
            this.txtnumero2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(115, 31);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(159, 20);
            this.txtnumero1.TabIndex = 1;
            this.txtnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdivision);
            this.groupBox2.Controls.Add(this.txtsuma);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtraiz);
            this.groupBox2.Controls.Add(this.txtpotencia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtmultiplicacion);
            this.groupBox2.Controls.Add(this.txtresta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "resultados";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(115, 31);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(159, 20);
            this.txtsuma.TabIndex = 1;
            this.txtsuma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "suma";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtresta
            // 
            this.txtresta.Location = new System.Drawing.Point(115, 76);
            this.txtresta.Name = "txtresta";
            this.txtresta.Size = new System.Drawing.Size(159, 20);
            this.txtresta.TabIndex = 1;
            this.txtresta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "resta";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "potencia";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpotencia
            // 
            this.txtpotencia.Location = new System.Drawing.Point(390, 76);
            this.txtpotencia.Name = "txtpotencia";
            this.txtpotencia.Size = new System.Drawing.Size(159, 20);
            this.txtpotencia.TabIndex = 1;
            this.txtpotencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Division";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdivision
            // 
            this.txtdivision.Location = new System.Drawing.Point(390, 31);
            this.txtdivision.Name = "txtdivision";
            this.txtdivision.Size = new System.Drawing.Size(159, 20);
            this.txtdivision.TabIndex = 1;
            this.txtdivision.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Multiplicacion";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmultiplicacion
            // 
            this.txtmultiplicacion.Location = new System.Drawing.Point(115, 126);
            this.txtmultiplicacion.Name = "txtmultiplicacion";
            this.txtmultiplicacion.Size = new System.Drawing.Size(159, 20);
            this.txtmultiplicacion.TabIndex = 1;
            this.txtmultiplicacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Raiz";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtraiz
            // 
            this.txtraiz.Location = new System.Drawing.Point(390, 126);
            this.txtraiz.Name = "txtraiz";
            this.txtraiz.Size = new System.Drawing.Size(159, 20);
            this.txtraiz.TabIndex = 1;
            this.txtraiz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(402, 29);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(402, 79);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Name = "Form1";
            this.Text = "Estructuras Secuenciales";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdivision;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtraiz;
        private System.Windows.Forms.TextBox txtpotencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmultiplicacion;
        private System.Windows.Forms.TextBox txtresta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

