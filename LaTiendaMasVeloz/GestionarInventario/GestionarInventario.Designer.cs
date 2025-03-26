namespace Principal.GestionarInventario
{
    partial class GestionarInventario
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
            BtEliminarInventario = new Button();
            BtConsultarInventario = new Button();
            BtAgregarInventario = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 76);
            label3.Name = "label3";
            label3.Size = new Size(234, 25);
            label3.TabIndex = 19;
            label3.Text = "GESTIÓN DE INVENTARIO";
            // 
            // BtEliminarInventario
            // 
            BtEliminarInventario.Location = new Point(560, 193);
            BtEliminarInventario.Name = "BtEliminarInventario";
            BtEliminarInventario.Size = new Size(162, 60);
            BtEliminarInventario.TabIndex = 18;
            BtEliminarInventario.Text = "ELIMINAR PRODUCTOS";
            BtEliminarInventario.UseVisualStyleBackColor = true;
            BtEliminarInventario.Click += BtEliminarInventario_Click;
            // 
            // BtConsultarInventario
            // 
            BtConsultarInventario.Location = new Point(318, 193);
            BtConsultarInventario.Name = "BtConsultarInventario";
            BtConsultarInventario.Size = new Size(162, 60);
            BtConsultarInventario.TabIndex = 16;
            BtConsultarInventario.Text = "CONSULTAR PRODUCTOS";
            BtConsultarInventario.UseVisualStyleBackColor = true;
            BtConsultarInventario.Click += BtConsultarInventario_Click;
            // 
            // BtAgregarInventario
            // 
            BtAgregarInventario.Location = new Point(76, 193);
            BtAgregarInventario.Name = "BtAgregarInventario";
            BtAgregarInventario.Size = new Size(162, 60);
            BtAgregarInventario.TabIndex = 15;
            BtAgregarInventario.Text = "AGREGAR PRODUCTOS";
            BtAgregarInventario.UseVisualStyleBackColor = true;
            BtAgregarInventario.Click += BtAgregarInventario_Click;
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
            // GestionarInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarInventario);
            Controls.Add(BtConsultarInventario);
            Controls.Add(BtAgregarInventario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarInventario";
            Text = "GestionarInventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarInventario;
        private Button BtConsultarInventario;
        private Button BtAgregarInventario;
        private Label label2;
        private Label label1;
    }
}