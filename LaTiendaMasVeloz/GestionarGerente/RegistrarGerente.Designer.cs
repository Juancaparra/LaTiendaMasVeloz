namespace Principal.GestionarGerente
{
    partial class RegistrarGerente
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
            lbContraseña = new Label();
            tbContraseña = new TextBox();
            lbResultadoRegistrar = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbUsuario = new TextBox();
            tbNombre = new TextBox();
            tbCedula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.Location = new Point(160, 307);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(149, 20);
            lbContraseña.TabIndex = 53;
            lbContraseña.Text = "Ingrese la contraseña";
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(324, 300);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(133, 27);
            tbContraseña.TabIndex = 52;
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(369, 400);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 249);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 50;
            label6.Text = "Ingrese el usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 191);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 49;
            label5.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 48;
            label4.Text = "Ingrese la cedula";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(348, 343);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 47;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(324, 242);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(133, 27);
            tbUsuario.TabIndex = 46;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(324, 188);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 45;
            // 
            // tbCedula
            // 
            tbCedula.Location = new Point(324, 136);
            tbCedula.Name = "tbCedula";
            tbCedula.Size = new Size(133, 27);
            tbCedula.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 77);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 43;
            label3.Text = "REGISTRAR GERENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 41;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // RegistrarGerente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbContraseña);
            Controls.Add(tbContraseña);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbUsuario);
            Controls.Add(tbNombre);
            Controls.Add(tbCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarGerente";
            Text = "RegistrarGerente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbContraseña;
        private TextBox tbContraseña;
        private Label lbResultadoRegistrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbUsuario;
        private TextBox tbNombre;
        private TextBox tbCedula;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}