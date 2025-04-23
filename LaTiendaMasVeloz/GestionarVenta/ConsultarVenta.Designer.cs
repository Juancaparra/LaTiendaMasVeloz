namespace Principal.GestionarVenta
{
    partial class ConsultarVenta
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
            label7 = new Label();
            btBuscar = new Button();
            fecha = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            tbIdFactura = new TextBox();
            lbResultado = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(446, 416);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 71;
            totalVenta.Text = "Total: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 121);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 70;
            label7.Text = "Factura N°:  ";
            label7.Click += label7_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(415, 112);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 64;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // fecha
            // 
            fecha.Location = new Point(504, 32);
            fecha.Name = "fecha";
            fecha.Size = new Size(283, 27);
            fecha.TabIndex = 61;
            fecha.Value = new DateTime(2025, 4, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 194);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 59;
            label5.Text = "cedula cliente: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 157);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 58;
            label4.Text = "cedula empleado: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 84);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 54;
            label3.Text = "CONSULTAR VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 84);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 52;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 115);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 74;
            label8.Text = "Ingrese el N° de factura";
            // 
            // tbIdFactura
            // 
            tbIdFactura.Location = new Point(244, 112);
            tbIdFactura.Name = "tbIdFactura";
            tbIdFactura.Size = new Size(133, 27);
            tbIdFactura.TabIndex = 73;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(385, 474);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 75;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(27, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 119);
            dataGridView1.TabIndex = 76;
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
            // ConsultarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 551);
            Controls.Add(dataGridView1);
            Controls.Add(lbResultado);
            Controls.Add(label8);
            Controls.Add(tbIdFactura);
            Controls.Add(totalVenta);
            Controls.Add(label7);
            Controls.Add(btBuscar);
            Controls.Add(fecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarVenta";
            Text = "ConsultarVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalVenta;
        private Label label7;
        private Button btBuscar;
        private DateTimePicker fecha;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox tbIdFactura;
        private Label lbResultado;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}