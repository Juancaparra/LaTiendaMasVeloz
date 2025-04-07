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
            BtGestionarCliente = new Button();
            BtGestionarEmpleados = new Button();
            btGestionarProveedores = new Button();
            btGestionarVenta = new Button();
            btGestionarFacturaProveedores = new Button();
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
            BtGestionarProductos.Location = new Point(64, 253);
            BtGestionarProductos.Name = "BtGestionarProductos";
            BtGestionarProductos.Size = new Size(162, 60);
            BtGestionarProductos.TabIndex = 2;
            BtGestionarProductos.Text = "GESTIONAR PRODUCTOS";
            BtGestionarProductos.UseVisualStyleBackColor = true;
            BtGestionarProductos.Click += BtGestionarProductos_Click;
            // 
            // BtGestionarCliente
            // 
            BtGestionarCliente.Location = new Point(64, 134);
            BtGestionarCliente.Name = "BtGestionarCliente";
            BtGestionarCliente.Size = new Size(162, 60);
            BtGestionarCliente.TabIndex = 4;
            BtGestionarCliente.Text = "GESTIONAR CLIENTES";
            BtGestionarCliente.UseVisualStyleBackColor = true;
            BtGestionarCliente.Click += BtGestionarCliente_Click;
            // 
            // BtGestionarEmpleados
            // 
            BtGestionarEmpleados.Location = new Point(577, 134);
            BtGestionarEmpleados.Name = "BtGestionarEmpleados";
            BtGestionarEmpleados.Size = new Size(162, 60);
            BtGestionarEmpleados.TabIndex = 5;
            BtGestionarEmpleados.Text = "GESTIONAR EMPLEADOS";
            BtGestionarEmpleados.UseVisualStyleBackColor = true;
            BtGestionarEmpleados.Click += BtGestionarEmpleados_Click;
            // 
            // btGestionarProveedores
            // 
            btGestionarProveedores.Location = new Point(312, 253);
            btGestionarProveedores.Name = "btGestionarProveedores";
            btGestionarProveedores.Size = new Size(162, 60);
            btGestionarProveedores.TabIndex = 7;
            btGestionarProveedores.Text = "GESTIONAR PROVEEDORES";
            btGestionarProveedores.UseVisualStyleBackColor = true;
            btGestionarProveedores.Click += button1_Click;
            // 
            // btGestionarVenta
            // 
            btGestionarVenta.Location = new Point(312, 134);
            btGestionarVenta.Name = "btGestionarVenta";
            btGestionarVenta.Size = new Size(162, 60);
            btGestionarVenta.TabIndex = 6;
            btGestionarVenta.Text = "GESTIONAR VENTA";
            btGestionarVenta.UseVisualStyleBackColor = true;
            btGestionarVenta.Click += button2_Click;
            // 
            // btGestionarFacturaProveedores
            // 
            btGestionarFacturaProveedores.Location = new Point(577, 253);
            btGestionarFacturaProveedores.Name = "btGestionarFacturaProveedores";
            btGestionarFacturaProveedores.Size = new Size(162, 60);
            btGestionarFacturaProveedores.TabIndex = 8;
            btGestionarFacturaProveedores.Text = "FACTURAS PROVEEDORES";
            btGestionarFacturaProveedores.UseVisualStyleBackColor = true;
            btGestionarFacturaProveedores.Click += btGestionarFacturaProveedores_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btGestionarFacturaProveedores);
            Controls.Add(btGestionarProveedores);
            Controls.Add(btGestionarVenta);
            Controls.Add(BtGestionarEmpleados);
            Controls.Add(BtGestionarCliente);
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
        private Button BtGestionarCliente;
        private Button BtGestionarEmpleados;
        private Button btGestionarProveedores;
        private Button btGestionarVenta;
        private Button btGestionarFacturaProveedores;
    }
}
