namespace Principal.InicioSesion
{
    partial class InicioSesion
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
            label2 = new Label();
            label1 = new Label();
            tbUsuario = new TextBox();
            lbUsuario = new Label();
            lbContraseña = new Label();
            tbContraseña = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 78);
            label2.Name = "label2";
            label2.Size = new Size(268, 25);
            label2.TabIndex = 9;
            label2.Text = "INICIO DE SESION EMPLEADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 8;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(309, 156);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(179, 27);
            tbUsuario.TabIndex = 10;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(311, 134);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(59, 20);
            lbUsuario.TabIndex = 11;
            lbUsuario.Text = "Usuario";
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.Location = new Point(313, 201);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(83, 20);
            lbContraseña.TabIndex = 13;
            lbContraseña.Text = "Contraseña";
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(311, 223);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(179, 27);
            tbContraseña.TabIndex = 12;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbContraseña);
            Controls.Add(tbContraseña);
            Controls.Add(lbUsuario);
            Controls.Add(tbUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioSesion";
            Text = "InicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox tbUsuario;
        private Label lbUsuario;
        private Label lbContraseña;
        private TextBox tbContraseña;
    }
}