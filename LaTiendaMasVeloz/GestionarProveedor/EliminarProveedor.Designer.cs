﻿namespace Principal.GestionarProveedor
{
    partial class EliminarProveedor
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
            lbResultadoEliminar = new Label();
            label4 = new Label();
            btEliminar = new Button();
            tbNIT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultadoEliminar
            // 
            lbResultadoEliminar.AutoSize = true;
            lbResultadoEliminar.Location = new Point(367, 262);
            lbResultadoEliminar.Name = "lbResultadoEliminar";
            lbResultadoEliminar.Size = new Size(0, 20);
            lbResultadoEliminar.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 139);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 49;
            label4.Text = "Ingrese el NIT";
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(348, 186);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 48;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // tbNIT
            // 
            tbNIT.Location = new Point(324, 136);
            tbNIT.Name = "tbNIT";
            tbNIT.Size = new Size(133, 27);
            tbNIT.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 76);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 46;
            label3.Text = "ELIMINAR PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 44;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // EliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoEliminar);
            Controls.Add(label4);
            Controls.Add(btEliminar);
            Controls.Add(tbNIT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EliminarProveedor";
            Text = "EliminarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoEliminar;
        private Label label4;
        private Button btEliminar;
        private TextBox tbNIT;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}