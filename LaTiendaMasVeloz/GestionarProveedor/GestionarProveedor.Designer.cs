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
            BtEliminarCliente = new Button();
            BtActualizarCliente = new Button();
            BtConsultarCliente = new Button();
            BtRegistrarCliente = new Button();
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
            // BtEliminarCliente
            // 
            BtEliminarCliente.Location = new Point(482, 244);
            BtEliminarCliente.Name = "BtEliminarCliente";
            BtEliminarCliente.Size = new Size(162, 60);
            BtEliminarCliente.TabIndex = 25;
            BtEliminarCliente.Text = "ELIMINAR PROVEEDOR";
            BtEliminarCliente.UseVisualStyleBackColor = true;
            BtEliminarCliente.Click += BtEliminarCliente_Click;
            // 
            // BtActualizarCliente
            // 
            BtActualizarCliente.Location = new Point(148, 244);
            BtActualizarCliente.Name = "BtActualizarCliente";
            BtActualizarCliente.Size = new Size(162, 60);
            BtActualizarCliente.TabIndex = 24;
            BtActualizarCliente.Text = "ACTUALIZAR PROVEEDOR";
            BtActualizarCliente.UseVisualStyleBackColor = true;
            BtActualizarCliente.Click += BtActualizarCliente_Click;
            // 
            // BtConsultarCliente
            // 
            BtConsultarCliente.Location = new Point(482, 134);
            BtConsultarCliente.Name = "BtConsultarCliente";
            BtConsultarCliente.Size = new Size(162, 60);
            BtConsultarCliente.TabIndex = 23;
            BtConsultarCliente.Text = "CONSULTAR PROVEEDOR";
            BtConsultarCliente.UseVisualStyleBackColor = true;
            BtConsultarCliente.Click += BtConsultarCliente_Click;
            // 
            // BtRegistrarCliente
            // 
            BtRegistrarCliente.Location = new Point(148, 134);
            BtRegistrarCliente.Name = "BtRegistrarCliente";
            BtRegistrarCliente.Size = new Size(162, 60);
            BtRegistrarCliente.TabIndex = 22;
            BtRegistrarCliente.Text = "REGISTRAR PROVEEDOR";
            BtRegistrarCliente.UseVisualStyleBackColor = true;
            BtRegistrarCliente.Click += BtRegistrarCliente_Click;
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
            Controls.Add(BtEliminarCliente);
            Controls.Add(BtActualizarCliente);
            Controls.Add(BtConsultarCliente);
            Controls.Add(BtRegistrarCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarProveedor";
            Text = "GestionarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarCliente;
        private Button BtActualizarCliente;
        private Button BtConsultarCliente;
        private Button BtRegistrarCliente;
        private Label label2;
        private Label label1;
    }
}