namespace Principal.GestionarVenta
{
    partial class GestionarVenta
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
            BtEliminarVenta = new Button();
            BtActualizarVenta = new Button();
            BtConsultarVenta = new Button();
            BtRegistrarVenta = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 76);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 33;
            label3.Text = "GESTIÓN DE VENTAS";
            // 
            // BtEliminarVenta
            // 
            BtEliminarVenta.Location = new Point(482, 244);
            BtEliminarVenta.Name = "BtEliminarVenta";
            BtEliminarVenta.Size = new Size(162, 60);
            BtEliminarVenta.TabIndex = 32;
            BtEliminarVenta.Text = "ELIMINAR VENTA";
            BtEliminarVenta.UseVisualStyleBackColor = true;
            BtEliminarVenta.Click += BtEliminarVenta_Click;
            // 
            // BtActualizarVenta
            // 
            BtActualizarVenta.Location = new Point(148, 244);
            BtActualizarVenta.Name = "BtActualizarVenta";
            BtActualizarVenta.Size = new Size(162, 60);
            BtActualizarVenta.TabIndex = 31;
            BtActualizarVenta.Text = "ACTUALIZAR VENTA";
            BtActualizarVenta.UseVisualStyleBackColor = true;
            BtActualizarVenta.Click += BtActualizarVenta_Click;
            // 
            // BtConsultarVenta
            // 
            BtConsultarVenta.Location = new Point(482, 134);
            BtConsultarVenta.Name = "BtConsultarVenta";
            BtConsultarVenta.Size = new Size(162, 60);
            BtConsultarVenta.TabIndex = 30;
            BtConsultarVenta.Text = "CONSULTAR VENTA";
            BtConsultarVenta.UseVisualStyleBackColor = true;
            BtConsultarVenta.Click += BtConsultarVenta_Click;
            // 
            // BtRegistrarVenta
            // 
            BtRegistrarVenta.Location = new Point(148, 134);
            BtRegistrarVenta.Name = "BtRegistrarVenta";
            BtRegistrarVenta.Size = new Size(162, 60);
            BtRegistrarVenta.TabIndex = 29;
            BtRegistrarVenta.Text = "REGISTRAR VENTA";
            BtRegistrarVenta.UseVisualStyleBackColor = true;
            BtRegistrarVenta.Click += BtRegistrarVenta_Click;
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
            // GestionarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarVenta);
            Controls.Add(BtActualizarVenta);
            Controls.Add(BtConsultarVenta);
            Controls.Add(BtRegistrarVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarVenta";
            Text = "GestionarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarVenta;
        private Button BtActualizarVenta;
        private Button BtConsultarVenta;
        private Button BtRegistrarVenta;
        private Label label2;
        private Label label1;
    }
}