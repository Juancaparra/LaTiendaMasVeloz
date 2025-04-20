namespace Principal.GestionarFacturaProveedor
{
    partial class ConsultarFactura
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
            dataGridView1 = new DataGridView();
            referencia = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            lbFechaLlegada = new Label();
            lbResultado = new Label();
            label7 = new Label();
            lbNitProveedor = new Label();
            label4 = new Label();
            tbNit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(591, 449);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 88;
            totalVenta.Text = "Total: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { referencia, nombre, precio, cantidad, subtotal });
            dataGridView1.Location = new Point(69, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 114);
            dataGridView1.TabIndex = 87;
            // 
            // referencia
            // 
            referencia.HeaderText = "Referencia";
            referencia.MinimumWidth = 6;
            referencia.Name = "referencia";
            referencia.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 190;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.Width = 125;
            // 
            // lbFechaLlegada
            // 
            lbFechaLlegada.AutoSize = true;
            lbFechaLlegada.Location = new Point(69, 232);
            lbFechaLlegada.Name = "lbFechaLlegada";
            lbFechaLlegada.Size = new Size(133, 20);
            lbFechaLlegada.TabIndex = 85;
            lbFechaLlegada.Text = "Fecha de llegada:  ";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(342, 531);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 117);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 81;
            label7.Text = "Factura Nº ";
            // 
            // lbNitProveedor
            // 
            lbNitProveedor.AutoSize = true;
            lbNitProveedor.Location = new Point(69, 180);
            lbNitProveedor.Name = "lbNitProveedor";
            lbNitProveedor.Size = new Size(109, 20);
            lbNitProveedor.TabIndex = 78;
            lbNitProveedor.Text = "Nit proveedor: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 120);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 77;
            label4.Text = "Ingrese el N° de factura";
            // 
            // tbNit
            // 
            tbNit.Location = new Point(246, 117);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(133, 27);
            tbNit.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 77);
            label3.Name = "label3";
            label3.Size = new Size(316, 25);
            label3.TabIndex = 72;
            label3.Text = "CONSULTAR FACTURA PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 77);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 70;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(457, 117);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 90;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // ConsultarFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 602);
            Controls.Add(btBuscar);
            Controls.Add(totalVenta);
            Controls.Add(dataGridView1);
            Controls.Add(lbFechaLlegada);
            Controls.Add(lbResultado);
            Controls.Add(label7);
            Controls.Add(lbNitProveedor);
            Controls.Add(label4);
            Controls.Add(tbNit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarFactura";
            Text = "ConsultarFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalVenta;
        private DataGridView dataGridView1;
        private Label lbFechaLlegada;
        private Label lbResultado;
        private Label label7;
        private Label lbNitProveedor;
        private Label label4;
        private TextBox tbNit;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btBuscar;
        private DataGridViewTextBoxColumn referencia;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
    }
}