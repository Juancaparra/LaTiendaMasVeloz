namespace Principal
{
    partial class EliminarProducto
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
            lbResultadoEliminar = new Label();
            label4 = new Label();
            btEliminar = new Button();
            tbReferencia = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 76);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 19;
            label3.Text = "ELIMINAR PRODUCTOS";
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
            // lbResultadoEliminar
            // 
            lbResultadoEliminar.AutoSize = true;
            lbResultadoEliminar.Location = new Point(404, 274);
            lbResultadoEliminar.Name = "lbResultadoEliminar";
            lbResultadoEliminar.Size = new Size(0, 20);
            lbResultadoEliminar.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 151);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 46;
            label4.Text = "Ingrese la referencia";
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(385, 198);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 45;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(361, 148);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 44;
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultadoEliminar);
            Controls.Add(label4);
            Controls.Add(btEliminar);
            Controls.Add(tbReferencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbResultadoEliminar;
        private Label label4;
        private Button btEliminar;
        private TextBox tbReferencia;
    }
}