﻿namespace Principal.GestionarVenta
{
    partial class RegistrarVenta
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
            lbResultadoRegistrar = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbCliente = new TextBox();
            tbCedulaEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btBuscar = new Button();
            totalVenta = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            tbReferencia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(365, 482);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 36;
            label5.Text = "Ingrese la cedula cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 107);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 35;
            label4.Text = "Ingrese la cedula empleado";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(329, 448);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 34;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbCliente
            // 
            tbCliente.Location = new Point(232, 150);
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(133, 27);
            tbCliente.TabIndex = 32;
            // 
            // tbCedulaEmpleado
            // 
            tbCedulaEmpleado.Location = new Point(232, 104);
            tbCedulaEmpleado.Name = "tbCedulaEmpleado";
            tbCedulaEmpleado.Size = new Size(133, 27);
            tbCedulaEmpleado.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 76);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 30;
            label3.Text = "REGISTRAR VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 28;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(403, 197);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 42;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(536, 429);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 50;
            totalVenta.Text = "Total: ";
            // 
            // panel1
            // 
            panel1.Location = new Point(584, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 43);
            panel1.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(29, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 119);
            dataGridView1.TabIndex = 52;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Valor Unit";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 190;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(498, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 27);
            dateTimePicker1.TabIndex = 53;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(232, 197);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 200);
            label6.Name = "label6";
            label6.Size = new Size(233, 20);
            label6.TabIndex = 41;
            label6.Text = "Ingrese la referencia del producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 153);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 55;
            label7.Text = "Ingrese la cantidad";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(546, 150);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(133, 27);
            tbCantidad.TabIndex = 54;
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 542);
            Controls.Add(label7);
            Controls.Add(tbCantidad);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(totalVenta);
            Controls.Add(btBuscar);
            Controls.Add(label6);
            Controls.Add(tbReferencia);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbCliente);
            Controls.Add(tbCedulaEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarVenta";
            Text = "RegistrarVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoRegistrar;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbTelefono;
        private TextBox tbCliente;
        private TextBox tbCedulaEmpleado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btBuscar;
        private Label totalVenta;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DateTimePicker dateTimePicker1;
        private TextBox tbReferencia;
        private Label label6;
        private Label label7;
        private TextBox tbCantidad;
    }
}