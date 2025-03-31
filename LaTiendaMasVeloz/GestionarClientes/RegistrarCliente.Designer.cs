namespace Principal.GestionarClientes
{
    partial class RegistrarCliente
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbCedula = new TextBox();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            btRegistrar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbResultadoRegistrar = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 76);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 19;
            label3.Text = "REGISTRAR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 13;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // tbCedula
            // 
            tbCedula.Location = new Point(324, 136);
            tbCedula.Name = "tbCedula";
            tbCedula.Size = new Size(133, 27);
            tbCedula.TabIndex = 20;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(324, 196);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 21;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(324, 260);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(133, 27);
            tbTelefono.TabIndex = 22;
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(340, 333);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 23;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 24;
            label4.Text = "Ingrese la cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 199);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 25;
            label5.Text = "Ingrese el nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 267);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 26;
            label6.Text = "Ingrese el telefono";
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(369, 400);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 27;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbTelefono);
            Controls.Add(tbNombre);
            Controls.Add(tbCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarCliente";
            Text = "RegistrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbCedula;
        private TextBox tbNombre;
        private TextBox tbTelefono;
        private Button btRegistrar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbResultadoRegistrar;
    }
}