namespace Principal
{
    partial class AgregarProducto
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbPrecio = new TextBox();
            tbNombre = new TextBox();
            tbReferencia = new TextBox();
            label7 = new Label();
            tbMarca = new TextBox();
            lbResultado = new Label();
            label8 = new Label();
            tbUsuario = new TextBox();
            label9 = new Label();
            tbIdProveedor = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 76);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 19;
            label3.Text = "REGISTRAR PRODUCTO";
            label3.Click += label3_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 240);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 33;
            label6.Text = "Ingrese el precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 181);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 32;
            label5.Text = "Ingrese el nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 121);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 31;
            label4.Text = "Ingrese la referencia";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(378, 316);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 30;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(215, 233);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(133, 27);
            tbPrecio.TabIndex = 29;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(215, 178);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 28;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(215, 118);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 125);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 35;
            label7.Text = "Ingrese la marca";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(561, 121);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(133, 27);
            tbMarca.TabIndex = 34;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(412, 364);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 178);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 38;
            label8.Text = "Ingrese el usuario";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(561, 174);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(133, 27);
            tbUsuario.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 237);
            label9.Name = "label9";
            label9.Size = new Size(188, 20);
            label9.TabIndex = 40;
            label9.Text = "Ingrese el id del proveedor";
            // 
            // tbIdProveedor
            // 
            tbIdProveedor.Location = new Point(561, 233);
            tbIdProveedor.Name = "tbIdProveedor";
            tbIdProveedor.Size = new Size(133, 27);
            tbIdProveedor.TabIndex = 39;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(tbIdProveedor);
            Controls.Add(label8);
            Controls.Add(tbUsuario);
            Controls.Add(lbResultado);
            Controls.Add(label7);
            Controls.Add(tbMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbPrecio);
            Controls.Add(tbNombre);
            Controls.Add(tbReferencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbPrecio;
        private TextBox tbNombre;
        private TextBox tbReferencia;
        private Label label7;
        private TextBox tbMarca;
        private Label lbResultado;
        private Label label8;
        private TextBox tbUsuario;
        private Label label9;
        private TextBox tbIdProveedor;
    }
}