namespace Principal.GestionarVenta
{
    partial class RegistrarVenta
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
            lbResultadoRegistrar = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbNombre = new TextBox();
            tbCedulaEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(365, 400);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 36;
            label5.Text = "Ingrese la cedula cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 107);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 35;
            label4.Text = "Ingrese la cedula empleado";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(336, 333);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 34;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(232, 150);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 32;
            // 
            // tbCedulaEmpleado
            // 
            tbCedulaEmpleado.Location = new Point(232, 104);
            tbCedulaEmpleado.Name = "tbCedulaEmpleado";
            tbCedulaEmpleado.Size = new Size(133, 27);
            tbCedulaEmpleado.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 76);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 30;
            label3.Text = "REGISTRAR VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 28;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 542);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbNombre);
            Controls.Add(tbCedulaEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarVenta";
            Text = "RegistrarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoRegistrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbCedulaEmpleado;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}