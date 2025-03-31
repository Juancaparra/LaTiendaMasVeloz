namespace Principal.GestionarProveedor
{
    partial class ConsultarProveedor
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
            lbResultadoConsultar = new Label();
            lbTelefonoConsultar = new Label();
            lbNombreConsultar = new Label();
            label4 = new Label();
            btConsultar = new Button();
            tbNIT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultadoConsultar
            // 
            lbResultadoConsultar.AutoSize = true;
            lbResultadoConsultar.Location = new Point(363, 368);
            lbResultadoConsultar.Name = "lbResultadoConsultar";
            lbResultadoConsultar.Size = new Size(0, 20);
            lbResultadoConsultar.TabIndex = 46;
            // 
            // lbTelefonoConsultar
            // 
            lbTelefonoConsultar.AutoSize = true;
            lbTelefonoConsultar.Location = new Point(192, 296);
            lbTelefonoConsultar.Name = "lbTelefonoConsultar";
            lbTelefonoConsultar.Size = new Size(78, 20);
            lbTelefonoConsultar.TabIndex = 45;
            lbTelefonoConsultar.Text = "Telefono:  ";
            // 
            // lbNombreConsultar
            // 
            lbNombreConsultar.AutoSize = true;
            lbNombreConsultar.Location = new Point(192, 240);
            lbNombreConsultar.Name = "lbNombreConsultar";
            lbNombreConsultar.Size = new Size(71, 20);
            lbNombreConsultar.TabIndex = 44;
            lbNombreConsultar.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 43;
            label4.Text = "Ingrese el NIT";
            // 
            // btConsultar
            // 
            btConsultar.Location = new Point(348, 186);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(94, 29);
            btConsultar.TabIndex = 42;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbNIT
            // 
            tbNIT.Location = new Point(324, 136);
            tbNIT.Name = "tbNIT";
            tbNIT.Size = new Size(133, 27);
            tbNIT.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 76);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 40;
            label3.Text = "CONSULTAR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 38;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // ConsultarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoConsultar);
            Controls.Add(lbTelefonoConsultar);
            Controls.Add(lbNombreConsultar);
            Controls.Add(label4);
            Controls.Add(btConsultar);
            Controls.Add(tbNIT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarProveedor";
            Text = "ConsultarProveedor";
            Load += ConsultarProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoConsultar;
        private Label lbTelefonoConsultar;
        private Label lbNombreConsultar;
        private Label label4;
        private Button btConsultar;
        private TextBox tbNIT;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}