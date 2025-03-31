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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbResultadoActualizar = new Label();
            SuspendLayout();
            // 
            // lbTelefonoActualizar
            // 
            lbTelefonoActualizar.AutoSize = true;
            lbTelefonoActualizar.Location = new Point(192, 273);
            lbTelefonoActualizar.Name = "lbTelefonoActualizar";
            lbTelefonoActualizar.Size = new Size(133, 20);
            lbTelefonoActualizar.TabIndex = 44;
            lbTelefonoActualizar.Text = "Ingrese el telefono";
            // 
            // lbNombreActualizar
            // 
            lbNombreActualizar.AutoSize = true;
            lbNombreActualizar.Location = new Point(192, 202);
            lbNombreActualizar.Name = "lbNombreActualizar";
            lbNombreActualizar.Size = new Size(129, 20);
            lbNombreActualizar.TabIndex = 43;
            lbNombreActualizar.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 42;
            label4.Text = "Ingrese la cedula";
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(334, 343);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 41;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(324, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 46;
            // 
            // lbResultadoActualizar
            // 
            lbResultadoActualizar.AutoSize = true;
            lbResultadoActualizar.Location = new Point(363, 410);
            lbResultadoActualizar.Name = "lbResultadoActualizar";
            lbResultadoActualizar.Size = new Size(0, 20);
            lbResultadoActualizar.TabIndex = 47;
            // 
            // ActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoActualizar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lbResultadoActualizar;
    }
}