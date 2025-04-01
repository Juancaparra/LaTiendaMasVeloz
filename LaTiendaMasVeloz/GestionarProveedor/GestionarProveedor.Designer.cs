namespace Principal.GestionarProveedor
{
    partial class GestionarProveedor
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
            BtEliminarProveedor = new Button();
            BtActualizarProveedor = new Button();
            BtConsultarProveedor = new Button();
            BtRegistrarProveedor = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 76);
            label3.Name = "label3";
            label3.Size = new Size(251, 25);
            label3.TabIndex = 26;
            label3.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // BtEliminarProveedor
            // 
            BtEliminarProveedor.Location = new Point(482, 244);
            BtEliminarProveedor.Name = "BtEliminarProveedor";
            BtEliminarProveedor.Size = new Size(162, 60);
            BtEliminarProveedor.TabIndex = 25;
            BtEliminarProveedor.Text = "ELIMINAR PROVEEDOR";
            BtEliminarProveedor.UseVisualStyleBackColor = true;
            BtEliminarProveedor.Click += BtEliminarProveedor_Click;
            // 
            // BtActualizarProveedor
            // 
            BtActualizarProveedor.Location = new Point(148, 244);
            BtActualizarProveedor.Name = "BtActualizarProveedor";
            BtActualizarProveedor.Size = new Size(162, 60);
            BtActualizarProveedor.TabIndex = 24;
            BtActualizarProveedor.Text = "ACTUALIZAR PROVEEDOR";
            BtActualizarProveedor.UseVisualStyleBackColor = true;
            BtActualizarProveedor.Click += BtActualizarProveedor_Click;
            // 
            // BtConsultarProveedor
            // 
            BtConsultarProveedor.Location = new Point(482, 134);
            BtConsultarProveedor.Name = "BtConsultarProveedor";
            BtConsultarProveedor.Size = new Size(162, 60);
            BtConsultarProveedor.TabIndex = 23;
            BtConsultarProveedor.Text = "CONSULTAR PROVEEDOR";
            BtConsultarProveedor.UseVisualStyleBackColor = true;
            BtConsultarProveedor.Click += BtConsultarProveedor_Click;
            // 
            // BtRegistrarProveedor
            // 
            BtRegistrarProveedor.Location = new Point(148, 134);
            BtRegistrarProveedor.Name = "BtRegistrarProveedor";
            BtRegistrarProveedor.Size = new Size(162, 60);
            BtRegistrarProveedor.TabIndex = 22;
            BtRegistrarProveedor.Text = "REGISTRAR PROVEEDOR";
            BtRegistrarProveedor.UseVisualStyleBackColor = true;
            BtRegistrarProveedor.Click += BtRegistrarProveedor_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 20;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // GestionarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarProveedor);
            Controls.Add(BtActualizarProveedor);
            Controls.Add(BtConsultarProveedor);
            Controls.Add(BtRegistrarProveedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarProveedor";
            Text = "GestionarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarProveedor;
        private Button BtActualizarProveedor;
        private Button BtConsultarProveedor;
        private Button BtRegistrarProveedor;
        private Label label2;
        private Label label1;
    }
}