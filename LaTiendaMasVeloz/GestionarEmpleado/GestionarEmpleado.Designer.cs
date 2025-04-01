namespace Principal.GestionarEmpleado
{
    partial class GestionarEmpleado
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
            BtEliminarEmpleado = new Button();
            BtActualizarEmpleado = new Button();
            BtConsultarEmpleado = new Button();
            BtRegistrarEmpleado = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 80);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 26;
            label3.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // BtEliminarEmpleado
            // 
            BtEliminarEmpleado.Location = new Point(480, 248);
            BtEliminarEmpleado.Name = "BtEliminarEmpleado";
            BtEliminarEmpleado.Size = new Size(162, 60);
            BtEliminarEmpleado.TabIndex = 25;
            BtEliminarEmpleado.Text = "ELIMINAR EMPLEADO";
            BtEliminarEmpleado.UseVisualStyleBackColor = true;
            BtEliminarEmpleado.Click += BtEliminarEmpleado_Click;
            // 
            // BtActualizarEmpleado
            // 
            BtActualizarEmpleado.Location = new Point(146, 248);
            BtActualizarEmpleado.Name = "BtActualizarEmpleado";
            BtActualizarEmpleado.Size = new Size(162, 60);
            BtActualizarEmpleado.TabIndex = 24;
            BtActualizarEmpleado.Text = "ACTUALIZAR EMPLEADO";
            BtActualizarEmpleado.UseVisualStyleBackColor = true;
            BtActualizarEmpleado.Click += BtActualizarEmpleado_Click;
            // 
            // BtConsultarEmpleado
            // 
            BtConsultarEmpleado.Location = new Point(480, 138);
            BtConsultarEmpleado.Name = "BtConsultarEmpleado";
            BtConsultarEmpleado.Size = new Size(162, 60);
            BtConsultarEmpleado.TabIndex = 23;
            BtConsultarEmpleado.Text = "CONSULTAR EMPLEADO";
            BtConsultarEmpleado.UseVisualStyleBackColor = true;
            BtConsultarEmpleado.Click += BtConsultarEmpleado_Click;
            // 
            // BtRegistrarEmpleado
            // 
            BtRegistrarEmpleado.Location = new Point(146, 138);
            BtRegistrarEmpleado.Name = "BtRegistrarEmpleado";
            BtRegistrarEmpleado.Size = new Size(162, 60);
            BtRegistrarEmpleado.TabIndex = 22;
            BtRegistrarEmpleado.Text = "REGISTRAR EMPLEADO";
            BtRegistrarEmpleado.UseVisualStyleBackColor = true;
            BtRegistrarEmpleado.Click += BtRegistrarEmpleado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(346, 80);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 20;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // GestionarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtEliminarEmpleado);
            Controls.Add(BtActualizarEmpleado);
            Controls.Add(BtConsultarEmpleado);
            Controls.Add(BtRegistrarEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarEmpleado";
            Text = "GestionarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button BtEliminarEmpleado;
        private Button BtActualizarEmpleado;
        private Button BtConsultarEmpleado;
        private Button BtRegistrarEmpleado;
        private Label label2;
        private Label label1;
    }
}