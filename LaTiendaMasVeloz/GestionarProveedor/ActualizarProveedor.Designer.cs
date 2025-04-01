namespace Principal.GestionarProveedor
{
    partial class ActualizarProveedor
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbTelefonoActualizar = new Label();
            lbNombreActualizar = new Label();
            label4 = new Label();
            btActualizar = new Button();
            tbNIT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbResultado = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 55;
            // 
            // lbTelefonoActualizar
            // 
            lbTelefonoActualizar.AutoSize = true;
            lbTelefonoActualizar.Location = new Point(193, 294);
            lbTelefonoActualizar.Name = "lbTelefonoActualizar";
            lbTelefonoActualizar.Size = new Size(133, 20);
            lbTelefonoActualizar.TabIndex = 54;
            lbTelefonoActualizar.Text = "Ingrese el telefono";
            // 
            // lbNombreActualizar
            // 
            lbNombreActualizar.AutoSize = true;
            lbNombreActualizar.Location = new Point(193, 242);
            lbNombreActualizar.Name = "lbNombreActualizar";
            lbNombreActualizar.Size = new Size(129, 20);
            lbNombreActualizar.TabIndex = 53;
            lbNombreActualizar.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 144);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 52;
            label4.Text = "Ingrese el NIT del proveedor";
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(343, 345);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 51;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbNIT
            // 
            tbNIT.Location = new Point(325, 141);
            tbNIT.Name = "tbNIT";
            tbNIT.Size = new Size(133, 27);
            tbNIT.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(272, 78);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 49;
            label3.Text = "ACTUALIZAR PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 47;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(384, 401);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 57;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(325, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 190);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 58;
            label5.Text = "NIT (nuevo)  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(464, 190);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 60;
            label6.Text = "opcional";
            // 
            // ActualizarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(lbResultado);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbTelefonoActualizar);
            Controls.Add(lbNombreActualizar);
            Controls.Add(label4);
            Controls.Add(btActualizar);
            Controls.Add(tbNIT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarProveedor";
            Text = "ActualizarProveedor";
            Load += ActualizarProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbTelefonoActualizar;
        private Label lbNombreActualizar;
        private Label label4;
        private Button btActualizar;
        private TextBox tbNIT;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbResultado;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
    }
}