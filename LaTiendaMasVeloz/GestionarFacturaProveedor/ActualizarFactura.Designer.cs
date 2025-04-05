namespace Principal.GestionarFacturaProveedor
{
    partial class ActualizarFactura
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
            panel1 = new Panel();
            totalVenta = new Label();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            fechaLlegada = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            tbCantidad = new TextBox();
            lbResultado = new Label();
            label7 = new Label();
            tbNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btRegistrar = new Button();
            tbPrecio = new TextBox();
            tbReferencia = new TextBox();
            tbNit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(617, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 43);
            panel1.TabIndex = 89;
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(569, 501);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 88;
            totalVenta.Text = "Total: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, cantidad, subtotal });
            dataGridView1.Location = new Point(75, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(618, 114);
            dataGridView1.TabIndex = 87;
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
            // fechaLlegada
            // 
            fechaLlegada.Location = new Point(236, 243);
            fechaLlegada.Name = "fechaLlegada";
            fechaLlegada.Size = new Size(190, 27);
            fechaLlegada.TabIndex = 86;
            fechaLlegada.Value = new DateTime(2025, 4, 2, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 247);
            label11.Name = "label11";
            label11.Size = new Size(192, 20);
            label11.TabIndex = 85;
            label11.Text = "Ingrese la fecha de llegada ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(463, 250);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 84;
            label10.Text = "Ingrese la cantidad";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(598, 243);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(133, 27);
            tbCantidad.TabIndex = 83;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(348, 580);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 126);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 81;
            label7.Text = "Ingrese el nombre producto";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(598, 122);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 187);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 79;
            label6.Text = "Ingrese el precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 182);
            label5.Name = "label5";
            label5.Size = new Size(208, 20);
            label5.TabIndex = 78;
            label5.Text = "Ingrese la referencia producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 122);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 77;
            label4.Text = "Ingrese el nit proveedor";
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(399, 532);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 76;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(598, 182);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(133, 27);
            tbPrecio.TabIndex = 75;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(252, 179);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 74;
            // 
            // tbNit
            // 
            tbNit.Location = new Point(252, 119);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(133, 27);
            tbNit.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 79);
            label3.Name = "label3";
            label3.Size = new Size(323, 25);
            label3.TabIndex = 72;
            label3.Text = "ACTUALIZAR FACTURA PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 70;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(378, 306);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(94, 29);
            btAgregar.TabIndex = 90;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            // 
            // ActualizarFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 615);
            Controls.Add(btAgregar);
            Controls.Add(panel1);
            Controls.Add(totalVenta);
            Controls.Add(dataGridView1);
            Controls.Add(fechaLlegada);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tbCantidad);
            Controls.Add(lbResultado);
            Controls.Add(label7);
            Controls.Add(tbNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btRegistrar);
            Controls.Add(tbPrecio);
            Controls.Add(tbReferencia);
            Controls.Add(tbNit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarFactura";
            Text = "ActualizarFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label totalVenta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
        private DateTimePicker fechaLlegada;
        private Label label11;
        private Label label10;
        private TextBox tbCantidad;
        private Label lbResultado;
        private Label label7;
        private TextBox tbNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbPrecio;
        private TextBox tbReferencia;
        private TextBox tbNit;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAgregar;
    }
}