namespace Principal.GestionarVenta
{
    partial class GestionarVentaVendedor
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
            BtRegistrarVentaVendedor = new Button();
            btConsultarVentaVendedor = new Button();
            btActualizarVentaVendedor = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 76);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 36;
            label3.Text = "GESTIÓN DE VENTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 34;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // BtRegistrarVentaVendedor
            // 
            BtRegistrarVentaVendedor.Location = new Point(89, 179);
            BtRegistrarVentaVendedor.Name = "BtRegistrarVentaVendedor";
            BtRegistrarVentaVendedor.Size = new Size(162, 60);
            BtRegistrarVentaVendedor.TabIndex = 37;
            BtRegistrarVentaVendedor.Text = "REGISTRAR VENTA";
            BtRegistrarVentaVendedor.UseVisualStyleBackColor = true;
            BtRegistrarVentaVendedor.Click += BtRegistrarVentaVendedor_Click;
            // 
            // btConsultarVentaVendedor
            // 
            btConsultarVentaVendedor.Location = new Point(319, 179);
            btConsultarVentaVendedor.Name = "btConsultarVentaVendedor";
            btConsultarVentaVendedor.Size = new Size(162, 60);
            btConsultarVentaVendedor.TabIndex = 38;
            btConsultarVentaVendedor.Text = "CONSULTAR VENTA";
            btConsultarVentaVendedor.UseVisualStyleBackColor = true;
            btConsultarVentaVendedor.Click += btConsultarVentaVendedor_Click;
            // 
            // btActualizarVentaVendedor
            // 
            btActualizarVentaVendedor.Location = new Point(546, 179);
            btActualizarVentaVendedor.Name = "btActualizarVentaVendedor";
            btActualizarVentaVendedor.Size = new Size(162, 60);
            btActualizarVentaVendedor.TabIndex = 39;
            btActualizarVentaVendedor.Text = "ACTUALIZAR VENTA";
            btActualizarVentaVendedor.UseVisualStyleBackColor = true;
            btActualizarVentaVendedor.Click += btActualizarVentaVendedor_Click;
            // 
            // GestionarVentaVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btActualizarVentaVendedor);
            Controls.Add(btConsultarVentaVendedor);
            Controls.Add(BtRegistrarVentaVendedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarVentaVendedor";
            Text = "GestionarVentaVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtRegistrarVentaVendedor;
        private Button btConsultarVentaVendedor;
        private Button btActualizarVentaVendedor;
    }
}