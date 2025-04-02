namespace Principal.GestionarClientes
{
    partial class ActualizarCliente
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
            lbTelefonoActualizar = new Label();
            lbNombreActualizar = new Label();
            label4 = new Label();
            btActualizar = new Button();
            tbCedula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            lbResultadoActualizar = new Label();
            label5 = new Label();
            tbNuevaCedula = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // lbTelefonoActualizar
            // 
            lbTelefonoActualizar.AutoSize = true;
            lbTelefonoActualizar.Location = new Point(192, 286);
            lbTelefonoActualizar.Name = "lbTelefonoActualizar";
            lbTelefonoActualizar.Size = new Size(133, 20);
            lbTelefonoActualizar.TabIndex = 44;
            lbTelefonoActualizar.Text = "Ingrese el telefono";
            // 
            // lbNombreActualizar
            // 
            lbNombreActualizar.AutoSize = true;
            lbNombreActualizar.Location = new Point(192, 233);
            lbNombreActualizar.Name = "lbNombreActualizar";
            lbNombreActualizar.Size = new Size(129, 20);
            lbNombreActualizar.TabIndex = 43;
            lbNombreActualizar.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 139);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 42;
            label4.Text = "Ingrese la cedula del cliente";
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(334, 350);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 41;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbCedula
            // 
            tbCedula.Location = new Point(324, 136);
            tbCedula.Name = "tbCedula";
            tbCedula.Size = new Size(133, 27);
            tbCedula.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 76);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 39;
            label3.Text = "ACTUALIZAR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 37;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(324, 233);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 45;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(324, 279);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(133, 27);
            tbTelefono.TabIndex = 46;
            // 
            // lbResultadoActualizar
            // 
            lbResultadoActualizar.AutoSize = true;
            lbResultadoActualizar.Location = new Point(363, 417);
            lbResultadoActualizar.Name = "lbResultadoActualizar";
            lbResultadoActualizar.Size = new Size(0, 20);
            lbResultadoActualizar.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 186);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 49;
            label5.Text = "Ingrese la cedula nueva";
            // 
            // tbNuevaCedula
            // 
            tbNuevaCedula.Location = new Point(324, 183);
            tbNuevaCedula.Name = "tbNuevaCedula";
            tbNuevaCedula.Size = new Size(133, 27);
            tbNuevaCedula.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(463, 183);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 61;
            label6.Text = "opcional";
            // 
            // ActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbNuevaCedula);
            Controls.Add(lbResultadoActualizar);
            Controls.Add(tbTelefono);
            Controls.Add(tbNombre);
            Controls.Add(lbTelefonoActualizar);
            Controls.Add(lbNombreActualizar);
            Controls.Add(label4);
            Controls.Add(btActualizar);
            Controls.Add(tbCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarCliente";
            Text = "ActualizarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTelefonoActualizar;
        private Label lbNombreActualizar;
        private Label label4;
        private Button btActualizar;
        private TextBox tbCedula;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbNombre;
        private TextBox tbTelefono;
        private Label lbResultadoActualizar;
        private Label label5;
        private TextBox tbNuevaCedula;
        private Label label6;
    }
}