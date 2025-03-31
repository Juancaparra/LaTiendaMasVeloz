namespace Principal.GestionarEmpleado
{
    partial class ActualizarEmpleado
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
            lbResultadoActualizar = new Label();
            tbUsuario = new TextBox();
            textBox1 = new TextBox();
            lbUsuarioActualizar = new Label();
            lbNombreActualizar = new Label();
            label4 = new Label();
            btActualizar = new Button();
            tbCedula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultadoActualizar
            // 
            lbResultadoActualizar.AutoSize = true;
            lbResultadoActualizar.Location = new Point(365, 414);
            lbResultadoActualizar.Name = "lbResultadoActualizar";
            lbResultadoActualizar.Size = new Size(0, 20);
            lbResultadoActualizar.TabIndex = 58;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(338, 270);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(133, 27);
            tbUsuario.TabIndex = 57;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 56;
            // 
            // lbUsuarioActualizar
            // 
            lbUsuarioActualizar.AutoSize = true;
            lbUsuarioActualizar.Location = new Point(206, 274);
            lbUsuarioActualizar.Name = "lbUsuarioActualizar";
            lbUsuarioActualizar.Size = new Size(125, 20);
            lbUsuarioActualizar.TabIndex = 55;
            lbUsuarioActualizar.Text = "Ingrese el usuario";
            lbUsuarioActualizar.Click += lbUsuarioActualizar_Click;
            // 
            // lbNombreActualizar
            // 
            lbNombreActualizar.AutoSize = true;
            lbNombreActualizar.Location = new Point(206, 206);
            lbNombreActualizar.Name = "lbNombreActualizar";
            lbNombreActualizar.Size = new Size(129, 20);
            lbNombreActualizar.TabIndex = 54;
            lbNombreActualizar.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 143);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 53;
            label4.Text = "Ingrese la cedula";
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(349, 338);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 52;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // tbCedula
            // 
            tbCedula.Location = new Point(338, 140);
            tbCedula.Name = "tbCedula";
            tbCedula.Size = new Size(133, 27);
            tbCedula.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 80);
            label3.Name = "label3";
            label3.Size = new Size(226, 25);
            label3.TabIndex = 50;
            label3.Text = "ACTUALIZAR EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 48;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // ActualizarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoActualizar);
            Controls.Add(tbUsuario);
            Controls.Add(textBox1);
            Controls.Add(lbUsuarioActualizar);
            Controls.Add(lbNombreActualizar);
            Controls.Add(label4);
            Controls.Add(btActualizar);
            Controls.Add(tbCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarEmpleado";
            Text = "ActualizarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoActualizar;
        private TextBox tbUsuario;
        private TextBox textBox1;
        private Label lbUsuarioActualizar;
        private Label lbNombreActualizar;
        private Label label4;
        private Button btActualizar;
        private TextBox tbCedula;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}