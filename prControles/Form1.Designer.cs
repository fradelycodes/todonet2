﻿namespace prControles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            txtnumero2 = new TextBox();
            label2 = new Label();
            txtnumero1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtraiz = new TextBox();
            txtmultiplicacion = new TextBox();
            txtpotencia = new TextBox();
            txtresta = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            txtdivision = new TextBox();
            label6 = new Label();
            txtsuma = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(txtnumero2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtnumero1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operadores";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(300, 34);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(300, 96);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(130, 92);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(134, 23);
            txtnumero2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Numero 2:";
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(130, 34);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(134, 23);
            txtnumero1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtraiz);
            groupBox2.Controls.Add(txtmultiplicacion);
            groupBox2.Controls.Add(txtpotencia);
            groupBox2.Controls.Add(txtresta);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtdivision);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtsuma);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(25, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 208);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados";
            // 
            // txtraiz
            // 
            txtraiz.Location = new Point(357, 152);
            txtraiz.Name = "txtraiz";
            txtraiz.Size = new Size(134, 23);
            txtraiz.TabIndex = 1;
            // 
            // txtmultiplicacion
            // 
            txtmultiplicacion.Location = new Point(130, 152);
            txtmultiplicacion.Name = "txtmultiplicacion";
            txtmultiplicacion.Size = new Size(134, 23);
            txtmultiplicacion.TabIndex = 1;
            // 
            // txtpotencia
            // 
            txtpotencia.Location = new Point(357, 93);
            txtpotencia.Name = "txtpotencia";
            txtpotencia.Size = new Size(134, 23);
            txtpotencia.TabIndex = 1;
            // 
            // txtresta
            // 
            txtresta.Location = new Point(130, 93);
            txtresta.Name = "txtresta";
            txtresta.Size = new Size(134, 23);
            txtresta.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 156);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 0;
            label8.Text = "raiz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 156);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "multiplicacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 97);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 0;
            label7.Text = "potencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 97);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "resta";
            // 
            // txtdivision
            // 
            txtdivision.Location = new Point(357, 35);
            txtdivision.Name = "txtdivision";
            txtdivision.Size = new Size(134, 23);
            txtdivision.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 39);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 0;
            label6.Text = "division";
            // 
            // txtsuma
            // 
            txtsuma.Location = new Point(130, 35);
            txtsuma.Name = "txtsuma";
            txtsuma.Size = new Size(134, 23);
            txtsuma.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 39);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "suma";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Estructuras Secuenciales";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btncalcular;
        private Button btnlimpiar;
        private TextBox txtnumero2;
        private Label label2;
        private TextBox txtnumero1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtraiz;
        private TextBox txtmultiplicacion;
        private TextBox txtpotencia;
        private TextBox txtresta;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label3;
        private TextBox txtdivision;
        private Label label6;
        private TextBox txtsuma;
        private Label label4;
    }
}