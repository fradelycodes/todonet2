namespace estructurasAlternativas13
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
            btnnuevo = new Button();
            txtnumero = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbodiv = new ComboBox();
            cbomult = new ComboBox();
            cboresta = new ComboBox();
            cbosuma = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(btnnuevo);
            groupBox1.Controls.Add(txtnumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tabla Aritmetica";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(486, 98);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(138, 44);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(486, 37);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(138, 44);
            btnnuevo.TabIndex = 2;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(127, 37);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(237, 23);
            txtnumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbodiv);
            groupBox2.Controls.Add(cbomult);
            groupBox2.Controls.Add(cboresta);
            groupBox2.Controls.Add(cbosuma);
            groupBox2.Location = new Point(33, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(710, 166);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 51);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 1;
            label5.Text = "division";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 51);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 1;
            label4.Text = "multiplicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 51);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "resta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 51);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "suma";
            // 
            // cbodiv
            // 
            cbodiv.FormattingEnabled = true;
            cbodiv.Location = new Point(512, 79);
            cbodiv.Name = "cbodiv";
            cbodiv.Size = new Size(121, 23);
            cbodiv.TabIndex = 0;
            // 
            // cbomult
            // 
            cbomult.FormattingEnabled = true;
            cbomult.Location = new Point(357, 79);
            cbomult.Name = "cbomult";
            cbomult.Size = new Size(121, 23);
            cbomult.TabIndex = 0;
            // 
            // cboresta
            // 
            cboresta.FormattingEnabled = true;
            cboresta.Location = new Point(194, 79);
            cboresta.Name = "cboresta";
            cboresta.Size = new Size(121, 23);
            cboresta.TabIndex = 0;
            // 
            // cbosuma
            // 
            cbosuma.FormattingEnabled = true;
            cbosuma.Location = new Point(48, 79);
            cbosuma.Name = "cbosuma";
            cbosuma.Size = new Size(121, 23);
            cbosuma.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btncalcular;
        private Button btnnuevo;
        private TextBox txtnumero;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbodiv;
        private ComboBox cbomult;
        private ComboBox cboresta;
        private ComboBox cbosuma;
    }
}