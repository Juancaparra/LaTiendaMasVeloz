namespace Principal.Menus
{
    partial class MenuVendedor
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
            btGestionarVenta = new Button();
            BtGestionarCliente = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btGestionarVenta
            // 
            btGestionarVenta.Location = new Point(434, 162);
            btGestionarVenta.Name = "btGestionarVenta";
            btGestionarVenta.Size = new Size(162, 60);
            btGestionarVenta.TabIndex = 13;
            btGestionarVenta.Text = "GESTIONAR VENTA";
            btGestionarVenta.UseVisualStyleBackColor = true;
            btGestionarVenta.Click += btGestionarVenta_Click;
            // 
            // BtGestionarCliente
            // 
            BtGestionarCliente.Location = new Point(186, 162);
            BtGestionarCliente.Name = "BtGestionarCliente";
            BtGestionarCliente.Size = new Size(162, 60);
            BtGestionarCliente.TabIndex = 11;
            BtGestionarCliente.Text = "GESTIONAR CLIENTES";
            BtGestionarCliente.UseVisualStyleBackColor = true;
            BtGestionarCliente.Click += BtGestionarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 79);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 9;
            label2.Text = "GESTIÓN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 8;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btGestionarVenta);
            Controls.Add(BtGestionarCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGestionarVenta;
        private Button BtGestionarCliente;
        private Label label2;
        private Label label1;
    }
}