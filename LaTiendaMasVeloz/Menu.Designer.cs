namespace LaTiendaMasVeloz
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            BtGestionarProductos = new Button();
            BtGestionarInventario = new Button();
            BtGestionarCliente = new Button();
            BtGestionarEmpleados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 0;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "GESTIÓN";
            // 
            // BtGestionarProductos
            // 
            BtGestionarProductos.Location = new Point(148, 134);
            BtGestionarProductos.Name = "BtGestionarProductos";
            BtGestionarProductos.Size = new Size(162, 60);
            BtGestionarProductos.TabIndex = 2;
            BtGestionarProductos.Text = "GESTIONAR PRODUCTOS";
            BtGestionarProductos.UseVisualStyleBackColor = true;
            BtGestionarProductos.Click += BtGestionarProductos_Click;
            // 
            // BtGestionarInventario
            // 
            BtGestionarInventario.Location = new Point(482, 134);
            BtGestionarInventario.Name = "BtGestionarInventario";
            BtGestionarInventario.Size = new Size(162, 60);
            BtGestionarInventario.TabIndex = 3;
            BtGestionarInventario.Text = "GESTIONAR INVENTARIO";
            BtGestionarInventario.UseVisualStyleBackColor = true;
            BtGestionarInventario.Click += BtGestionarInventario_Click;
            // 
            // BtGestionarCliente
            // 
            BtGestionarCliente.Location = new Point(148, 244);
            BtGestionarCliente.Name = "BtGestionarCliente";
            BtGestionarCliente.Size = new Size(162, 60);
            BtGestionarCliente.TabIndex = 4;
            BtGestionarCliente.Text = "GESTIONAR CLIENTES";
            BtGestionarCliente.UseVisualStyleBackColor = true;
            // 
            // BtGestionarEmpleados
            // 
            BtGestionarEmpleados.Location = new Point(482, 244);
            BtGestionarEmpleados.Name = "BtGestionarEmpleados";
            BtGestionarEmpleados.Size = new Size(162, 60);
            BtGestionarEmpleados.TabIndex = 5;
            BtGestionarEmpleados.Text = "GESTIONAR EMPLEADOS";
            BtGestionarEmpleados.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtGestionarEmpleados);
            Controls.Add(BtGestionarCliente);
            Controls.Add(BtGestionarInventario);
            Controls.Add(BtGestionarProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtGestionarProductos;
        private Button BtGestionarInventario;
        private Button BtGestionarCliente;
        private Button BtGestionarEmpleados;
    }
}
