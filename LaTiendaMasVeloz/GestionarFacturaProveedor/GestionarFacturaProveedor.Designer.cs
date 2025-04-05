namespace Principal.GestionarFacturaProveedor
{
    partial class GestionarFacturaProveedor
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
            BtEliminarFactura = new Button();
            BtActualizarFactura = new Button();
            BtConsultarFactura = new Button();
            BtRegistrarFactura = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 76);
            label3.Name = "label3";
            label3.Size = new Size(327, 25);
            label3.TabIndex = 33;
            label3.Text = "GESTIÓN DE FACTURAS PROVEEDOR";
            // 
            // BtEliminarFactura
            // 
            BtEliminarFactura.Location = new Point(482, 244);
            BtEliminarFactura.Name = "BtEliminarFactura";
            BtEliminarFactura.Size = new Size(162, 60);
            BtEliminarFactura.TabIndex = 32;
            BtEliminarFactura.Text = "ELIMINAR FACTURA";
            BtEliminarFactura.UseVisualStyleBackColor = true;
            BtEliminarFactura.Click += BtEliminarFactura_Click;
            // 
            // BtActualizarFactura
            // 
            BtActualizarFactura.Location = new Point(148, 244);
            BtActualizarFactura.Name = "BtActualizarFactura";
            BtActualizarFactura.Size = new Size(162, 60);
            BtActualizarFactura.TabIndex = 31;
            BtActualizarFactura.Text = "ACTUALIZAR FACTURA";
            BtActualizarFactura.UseVisualStyleBackColor = true;
            BtActualizarFactura.Click += BtActualizarFactura_Click;
            // 
            // BtConsultarFactura
            // 
            BtConsultarFactura.Location = new Point(482, 134);
            BtConsultarFactura.Name = "BtConsultarFactura";
            BtConsultarFactura.Size = new Size(162, 60);
            BtConsultarFactura.TabIndex = 30;
            BtConsultarFactura.Text = "CONSULTAR FACTURA";
            BtConsultarFactura.UseVisualStyleBackColor = true;
            BtConsultarFactura.Click += BtConsultarFactura_Click;
            // 
            // BtRegistrarFactura
            // 
            BtRegistrarFactura.Location = new Point(148, 134);
            BtRegistrarFactura.Name = "BtRegistrarFactura";
            BtRegistrarFactura.Size = new Size(162, 60);
            BtRegistrarFactura.TabIndex = 29;
            BtRegistrarFactura.Text = "REGISTRAR FACTURA";
            BtRegistrarFactura.UseVisualStyleBackColor = true;
            BtRegistrarFactura.Click += BtRegistrarFactura_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 27;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // GestionarFacturaProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarFactura);
            Controls.Add(BtActualizarFactura);
            Controls.Add(BtConsultarFactura);
            Controls.Add(BtRegistrarFactura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarFacturaProveedor";
            Text = "GestionarFacturaProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarFactura;
        private Button BtActualizarFactura;
        private Button BtConsultarFactura;
        private Button BtRegistrarFactura;
        private Label label2;
        private Label label1;
    }
}