namespace Principal
{
    partial class GestionarProductos
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
            BtEliminarProducto = new Button();
            BtActualizarProducto = new Button();
            BtConsultarProducto = new Button();
            BtAgregarProducto = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtEliminarProducto
            // 
            BtEliminarProducto.Location = new Point(482, 244);
            BtEliminarProducto.Name = "BtEliminarProducto";
            BtEliminarProducto.Size = new Size(162, 60);
            BtEliminarProducto.TabIndex = 11;
            BtEliminarProducto.Text = "ELIMINAR PRODUCTOS";
            BtEliminarProducto.UseVisualStyleBackColor = true;
            BtEliminarProducto.Click += BtEliminarProducto_Click;
            // 
            // BtActualizarProducto
            // 
            BtActualizarProducto.Location = new Point(148, 244);
            BtActualizarProducto.Name = "BtActualizarProducto";
            BtActualizarProducto.Size = new Size(162, 60);
            BtActualizarProducto.TabIndex = 10;
            BtActualizarProducto.Text = "ACTUALIZAR PRODUCTOS";
            BtActualizarProducto.UseVisualStyleBackColor = true;
            BtActualizarProducto.Click += BtActualizarProducto_Click;
            // 
            // BtConsultarProducto
            // 
            BtConsultarProducto.Location = new Point(482, 134);
            BtConsultarProducto.Name = "BtConsultarProducto";
            BtConsultarProducto.Size = new Size(162, 60);
            BtConsultarProducto.TabIndex = 9;
            BtConsultarProducto.Text = "CONSULTAR PRODUCTOS";
            BtConsultarProducto.UseVisualStyleBackColor = true;
            BtConsultarProducto.Click += BtConsultarProducto_Click;
            // 
            // BtAgregarProducto
            // 
            BtAgregarProducto.Location = new Point(148, 134);
            BtAgregarProducto.Name = "BtAgregarProducto";
            BtAgregarProducto.Size = new Size(162, 60);
            BtAgregarProducto.TabIndex = 8;
            BtAgregarProducto.Text = "AGREGAR PRODUCTOS";
            BtAgregarProducto.UseVisualStyleBackColor = true;
            BtAgregarProducto.Click += BtAgregarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 6;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 76);
            label3.Name = "label3";
            label3.Size = new Size(231, 25);
            label3.TabIndex = 12;
            label3.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // GestonarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarProducto);
            Controls.Add(BtActualizarProducto);
            Controls.Add(BtConsultarProducto);
            Controls.Add(BtAgregarProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestonarProductos";
            Text = "GestonarProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtEliminarProducto;
        private Button BtActualizarProducto;
        private Button BtConsultarProducto;
        private Button BtAgregarProducto;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}