namespace Principal.GestionarVenta
{
    partial class ActualizarVenta
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
            totalVenta = new Label();
            label6 = new Label();
            tbReferencia = new TextBox();
            fechaVenta = new DateTimePicker();
            lbResultadoRegistrar = new Label();
            label5 = new Label();
            label4 = new Label();
            btActualizar = new Button();
            tbCliente = new TextBox();
            tbIdVenta = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btBuscar = new Button();
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            tbEmpleado = new TextBox();
            label7 = new Label();
            tbCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(510, 436);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 71;
            totalVenta.Text = "Total: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 206);
            label6.Name = "label6";
            label6.Size = new Size(233, 20);
            label6.TabIndex = 63;
            label6.Text = "Ingrese la referencia del producto";
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(239, 203);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 62;
            // 
            // fechaVenta
            // 
            fechaVenta.Location = new Point(503, 42);
            fechaVenta.Name = "fechaVenta";
            fechaVenta.Size = new Size(283, 27);
            fechaVenta.TabIndex = 61;
            fechaVenta.Value = new DateTime(2025, 4, 1, 0, 0, 0, 0);
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(372, 509);
            lbResultadoRegistrar.Name = "lbResultadoRegistrar";
            lbResultadoRegistrar.Size = new Size(0, 20);
            lbResultadoRegistrar.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 159);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 59;
            label5.Text = "Ingrese la cedula cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 113);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 58;
            label4.Text = "Ingrese el N° de factura";
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(336, 475);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 57;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbCliente
            // 
            tbCliente.Location = new Point(239, 156);
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(133, 27);
            tbCliente.TabIndex = 56;
            // 
            // tbIdVenta
            // 
            tbIdVenta.Location = new Point(239, 110);
            tbIdVenta.Name = "tbIdVenta";
            tbIdVenta.Size = new Size(133, 27);
            tbIdVenta.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 82);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 54;
            label3.Text = "ACTUALIZAR VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(351, 82);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 52;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(410, 203);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 64;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(15, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(771, 119);
            dataGridView1.TabIndex = 73;
            // 
            // Column5
            // 
            Column5.HeaderText = "Referencia";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 110;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 170;
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
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 190;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 159);
            label8.Name = "label8";
            label8.Size = new Size(193, 20);
            label8.TabIndex = 75;
            label8.Text = "Ingrese la cedula empleado";
            // 
            // tbEmpleado
            // 
            tbEmpleado.Location = new Point(619, 156);
            tbEmpleado.Name = "tbEmpleado";
            tbEmpleado.Size = new Size(133, 27);
            tbEmpleado.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 111);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 77;
            label7.Text = "Ingrese la cantidad";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(615, 108);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(133, 27);
            tbCantidad.TabIndex = 76;
            // 
            // ActualizarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(label7);
            Controls.Add(tbCantidad);
            Controls.Add(label8);
            Controls.Add(tbEmpleado);
            Controls.Add(dataGridView1);
            Controls.Add(totalVenta);
            Controls.Add(btBuscar);
            Controls.Add(label6);
            Controls.Add(tbReferencia);
            Controls.Add(fechaVenta);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btActualizar);
            Controls.Add(tbCliente);
            Controls.Add(tbIdVenta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarVenta";
            Text = "ActualizarVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalVenta;
        private Label label7;
        private Label label6;
        private TextBox tbReferencia;
        private DateTimePicker fechaVenta;
        private Label lbResultadoRegistrar;
        private Label label5;
        private Label label4;
        private Button btActualizar;
        private TextBox tbCliente;
        private TextBox tbIdVenta;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btBuscar;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox tbEmpleado;
        private TextBox tbCantidad;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}