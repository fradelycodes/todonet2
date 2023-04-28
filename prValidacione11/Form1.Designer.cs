namespace prValidacione11
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnenviar = new Button();
            btnnuevo = new Button();
            linkLabel1 = new LinkLabel();
            txtdescripcion = new TextBox();
            label4 = new Label();
            txtsalario = new TextBox();
            label3 = new Label();
            txtedad = new TextBox();
            label2 = new Label();
            txtnombres = new TextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            erroricono = new ErrorProvider(components);
            ttmensaje = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erroricono).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnenviar);
            groupBox1.Controls.Add(btnnuevo);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(txtdescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtsalario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtedad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtnombres);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos";
            // 
            // btnenviar
            // 
            btnenviar.Location = new Point(406, 250);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(131, 44);
            btnenviar.TabIndex = 3;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(406, 173);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(131, 44);
            btnnuevo.TabIndex = 3;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(409, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(29, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Salir";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(105, 217);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.ScrollBars = ScrollBars.Vertical;
            txtdescripcion.Size = new Size(214, 114);
            txtdescripcion.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 221);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 0;
            label4.Text = "Descripcion";
            // 
            // txtsalario
            // 
            txtsalario.Location = new Point(105, 136);
            txtsalario.Name = "txtsalario";
            txtsalario.Size = new Size(166, 23);
            txtsalario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Salario";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(105, 89);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(166, 23);
            txtedad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 93);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Edad";
            // 
            // txtnombres
            // 
            txtnombres.Location = new Point(105, 46);
            txtnombres.Name = "txtnombres";
            txtnombres.Size = new Size(214, 23);
            txtnombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // erroricono
            // 
            erroricono.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Validaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erroricono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnenviar;
        private Button btnnuevo;
        private LinkLabel linkLabel1;
        private TextBox txtdescripcion;
        private Label label4;
        private TextBox txtsalario;
        private Label label3;
        private TextBox txtedad;
        private Label label2;
        private TextBox txtnombres;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ErrorProvider erroricono;
        private ToolTip ttmensaje;
    }
}