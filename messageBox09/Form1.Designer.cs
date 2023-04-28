namespace messageBox09
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
            btningresar = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // btningresar
            // 
            btningresar.Location = new Point(62, 54);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(154, 45);
            btningresar.TabIndex = 0;
            btningresar.Text = "Ingresar Datos";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(258, 54);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(154, 45);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 153);
            Controls.Add(btnsalir);
            Controls.Add(btningresar);
            Name = "Form1";
            Text = "Cuadro de Mensajes";
            ResumeLayout(false);
        }

        #endregion

        private Button btningresar;
        private Button btnsalir;
    }
}