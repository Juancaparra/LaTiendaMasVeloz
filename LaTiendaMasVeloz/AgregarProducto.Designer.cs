﻿namespace Principal
{
    partial class AgregarProducto
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
            BtEliminarProducto = new Button();
            BtActualizarProducto = new Button();
            BtConsultarProducto = new Button();
            BtAgregarProducto = new Button();
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
            label3.Size = new Size(201, 25);
            label3.TabIndex = 19;
            label3.Text = "AGREGAR PRODUCTO";
            label3.Click += label3_Click;
            // 
            // BtEliminarProducto
            // 
            BtEliminarProducto.Location = new Point(482, 244);
            BtEliminarProducto.Name = "BtEliminarProducto";
            BtEliminarProducto.Size = new Size(162, 60);
            BtEliminarProducto.TabIndex = 18;
            BtEliminarProducto.Text = "ELIMINAR PRODUCTOS";
            BtEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // BtActualizarProducto
            // 
            BtActualizarProducto.Location = new Point(148, 244);
            BtActualizarProducto.Name = "BtActualizarProducto";
            BtActualizarProducto.Size = new Size(162, 60);
            BtActualizarProducto.TabIndex = 17;
            BtActualizarProducto.Text = "ACTUALIZAR PRODUCTOS";
            BtActualizarProducto.UseVisualStyleBackColor = true;
            // 
            // BtConsultarProducto
            // 
            BtConsultarProducto.Location = new Point(482, 134);
            BtConsultarProducto.Name = "BtConsultarProducto";
            BtConsultarProducto.Size = new Size(162, 60);
            BtConsultarProducto.TabIndex = 16;
            BtConsultarProducto.Text = "CONSULTAR PRODUCTOS";
            BtConsultarProducto.UseVisualStyleBackColor = true;
            // 
            // BtAgregarProducto
            // 
            BtAgregarProducto.Location = new Point(148, 134);
            BtAgregarProducto.Name = "BtAgregarProducto";
            BtAgregarProducto.Size = new Size(162, 60);
            BtAgregarProducto.TabIndex = 15;
            BtAgregarProducto.Text = "AGREGAR PRODUCTOS";
            BtAgregarProducto.UseVisualStyleBackColor = true;
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
            // AgregarProducto
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
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarProducto;
        private Button BtActualizarProducto;
        private Button BtConsultarProducto;
        private Button BtAgregarProducto;
        private Label label2;
        private Label label1;
    }
}