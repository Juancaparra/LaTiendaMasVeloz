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
            panel1 = new Panel();
            totalVenta = new Label();
            precioUnitario = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            precioTotal = new Label();
            cantidad = new Label();
            lbNombreProducto = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            fecha = new DateTimePicker();
            lbResultadoRegistrar = new Label();
            label5 = new Label();
            label4 = new Label();
            btActualizar = new Button();
            tbNombre = new TextBox();
            tbCedulaEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btBuscar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(490, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 43);
            panel1.TabIndex = 72;
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(442, 436);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 71;
            totalVenta.Text = "Total: ";
            // 
            // precioUnitario
            // 
            precioUnitario.AutoSize = true;
            precioUnitario.Location = new Point(236, 276);
            precioUnitario.Name = "precioUnitario";
            precioUnitario.Size = new Size(85, 20);
            precioUnitario.TabIndex = 66;
            precioUnitario.Text = "Valor Unit:  ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.3875351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6124649F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel1.Location = new Point(36, 299);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.Size = new Size(628, 125);
            tableLayoutPanel1.TabIndex = 69;
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(493, 276);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(91, 20);
            precioTotal.TabIndex = 68;
            precioTotal.Text = "Valor Total:  ";
            // 
            // cantidad
            // 
            cantidad.AutoSize = true;
            cantidad.Location = new Point(410, 276);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(80, 20);
            cantidad.TabIndex = 67;
            cantidad.Text = "Cantidad:  ";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(36, 276);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(71, 20);
            lbNombreProducto.TabIndex = 65;
            lbNombreProducto.Text = "Nombre: ";
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
            // textBox1
            // 
            textBox1.Location = new Point(239, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 62;
            // 
            // fecha
            // 
            fecha.Location = new Point(503, 42);
            fecha.Name = "fecha";
            fecha.Size = new Size(283, 27);
            fecha.TabIndex = 61;
            fecha.Value = new DateTime(2025, 4, 1, 0, 0, 0, 0);
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
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(239, 156);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 56;
            // 
            // tbCedulaEmpleado
            // 
            tbCedulaEmpleado.Location = new Point(239, 110);
            tbCedulaEmpleado.Name = "tbCedulaEmpleado";
            tbCedulaEmpleado.Size = new Size(133, 27);
            tbCedulaEmpleado.TabIndex = 55;
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
            // 
            // ActualizarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(panel1);
            Controls.Add(totalVenta);
            Controls.Add(precioUnitario);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(precioTotal);
            Controls.Add(cantidad);
            Controls.Add(lbNombreProducto);
            Controls.Add(btBuscar);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(fecha);
            Controls.Add(lbResultadoRegistrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btActualizar);
            Controls.Add(tbNombre);
            Controls.Add(tbCedulaEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActualizarVenta";
            Text = "ActualizarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label totalVenta;
        private Label label7;
        private Label precioUnitario;
        private TableLayoutPanel tableLayoutPanel1;
        private Label precioTotal;
        private Label cantidad;
        private Label lbNombreProducto;
        private Label label6;
        private TextBox textBox1;
        private DateTimePicker fecha;
        private Label lbResultadoRegistrar;
        private Label label5;
        private Label label4;
        private Button btActualizar;
        private TextBox tbNombre;
        private TextBox tbCedulaEmpleado;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btBuscar;
    }
}