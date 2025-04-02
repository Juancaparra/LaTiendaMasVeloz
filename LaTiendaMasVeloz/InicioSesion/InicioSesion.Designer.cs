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
            button1 = new Button();
            button2 = new Button();
            BtGestionarEmpleados = new Button();
            BtGestionarCliente = new Button();
            BtGestionarProductos = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(439, 246);
            button1.Name = "button1";
            button1.Size = new Size(162, 60);
            button1.TabIndex = 14;
            button1.Text = "GESTIONAR PROVEEDORES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(310, 136);
            button2.Name = "button2";
            button2.Size = new Size(162, 60);
            button2.TabIndex = 13;
            button2.Text = "GESTIONAR VENTA";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtGestionarEmpleados
            // 
            BtGestionarEmpleados.Location = new Point(575, 136);
            BtGestionarEmpleados.Name = "BtGestionarEmpleados";
            BtGestionarEmpleados.Size = new Size(162, 60);
            BtGestionarEmpleados.TabIndex = 12;
            BtGestionarEmpleados.Text = "GESTIONAR EMPLEADOS";
            BtGestionarEmpleados.UseVisualStyleBackColor = true;
            // 
            // BtGestionarCliente
            // 
            BtGestionarCliente.Location = new Point(62, 136);
            BtGestionarCliente.Name = "BtGestionarCliente";
            BtGestionarCliente.Size = new Size(162, 60);
            BtGestionarCliente.TabIndex = 11;
            BtGestionarCliente.Text = "GESTIONAR CLIENTES";
            BtGestionarCliente.UseVisualStyleBackColor = true;
            // 
            // BtGestionarProductos
            // 
            BtGestionarProductos.Location = new Point(190, 246);
            BtGestionarProductos.Name = "BtGestionarProductos";
            BtGestionarProductos.Size = new Size(162, 60);
            BtGestionarProductos.TabIndex = 10;
            BtGestionarProductos.Text = "GESTIONAR PRODUCTOS";
            BtGestionarProductos.UseVisualStyleBackColor = true;
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
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(BtGestionarEmpleados);
            Controls.Add(BtGestionarCliente);
            Controls.Add(BtGestionarProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InicioSesion";
            Text = "InicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button BtGestionarEmpleados;
        private Button BtGestionarCliente;
        private Button BtGestionarProductos;
        private Label label2;
        private Label label1;
    }
}