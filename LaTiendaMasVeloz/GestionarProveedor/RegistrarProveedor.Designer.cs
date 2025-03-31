namespace Principal.GestionarProveedor
{
    partial class RegistrarProveedor
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            tbNIT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(368, 404);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 271);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 37;
            label6.Text = "Ingrese el telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 203);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 36;
            label5.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 143);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 35;
            label4.Text = "Ingrese el NIT";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(339, 337);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 34;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(323, 264);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(133, 27);
            tbTelefono.TabIndex = 33;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(323, 200);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 32;
            // 
            // tbNIT
            // 
            tbNIT.Location = new Point(323, 140);
            tbNIT.Name = "tbNIT";
            tbNIT.Size = new Size(133, 27);
            tbNIT.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 80);
            label3.Name = "label3";
            label3.Size = new Size(224, 25);
            label3.TabIndex = 30;
            label3.Text = "REGISTRAR PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 28;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // RegistrarProveedor
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
            Controls.Add(tbNIT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarProveedor";
            Text = "RegistrarProveedor";
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
        private TextBox tbNIT;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}