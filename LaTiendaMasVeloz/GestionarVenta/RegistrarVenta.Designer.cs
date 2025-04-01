namespace Principal.GestionarVenta
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
            tbNombre = new TextBox();
            tbCedulaEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fecha = new DateTimePicker();
            label6 = new Label();
            textBox1 = new TextBox();
            btBuscar = new Button();
            lbNombreProducto = new Label();
            precioUnitario = new Label();
            cantidad = new Label();
            precioTotal = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            totalVenta = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lbResultadoRegistrar
            // 
            lbResultadoRegistrar.AutoSize = true;
            lbResultadoRegistrar.Location = new Point(365, 503);
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
            btRegistrar.Location = new Point(329, 469);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(94, 29);
            btRegistrar.TabIndex = 34;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(232, 150);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(133, 27);
            tbNombre.TabIndex = 32;
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
            // fecha
            // 
            fecha.Location = new Point(496, 36);
            fecha.Name = "fecha";
            fecha.Size = new Size(283, 27);
            fecha.TabIndex = 39;
            fecha.Value = new DateTime(2025, 4, 1, 0, 0, 0, 0);
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
            // textBox1
            // 
            textBox1.Location = new Point(232, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 40;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(403, 197);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 42;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(29, 270);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(71, 20);
            lbNombreProducto.TabIndex = 43;
            lbNombreProducto.Text = "Nombre: ";
            // 
            // precioUnitario
            // 
            precioUnitario.AutoSize = true;
            precioUnitario.Location = new Point(229, 270);
            precioUnitario.Name = "precioUnitario";
            precioUnitario.Size = new Size(85, 20);
            precioUnitario.TabIndex = 44;
            precioUnitario.Text = "Valor Unit:  ";
            precioUnitario.Click += precioUnitario_Click;
            // 
            // cantidad
            // 
            cantidad.AutoSize = true;
            cantidad.Location = new Point(403, 270);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(80, 20);
            cantidad.TabIndex = 45;
            cantidad.Text = "Cantidad:  ";
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(486, 270);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(91, 20);
            precioTotal.TabIndex = 46;
            precioTotal.Text = "Valor Total:  ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.3875351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6124649F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel1.Location = new Point(29, 293);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.Size = new Size(628, 125);
            tableLayoutPanel1.TabIndex = 48;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 104);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 49;
            label7.Text = "Factura N°:  ";
            // 
            // totalVenta
            // 
            totalVenta.AutoSize = true;
            totalVenta.Location = new Point(435, 430);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(49, 20);
            totalVenta.TabIndex = 50;
            totalVenta.Text = "Total: ";
            // 
            // panel1
            // 
            panel1.Location = new Point(483, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 43);
            panel1.TabIndex = 51;
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 542);
            Controls.Add(panel1);
            Controls.Add(totalVenta);
            Controls.Add(label7);
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
            Controls.Add(btRegistrar);
            Controls.Add(tbNombre);
            Controls.Add(tbCedulaEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarVenta";
            Text = "RegistrarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResultadoRegistrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btRegistrar;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbCedulaEmpleado;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker fecha;
        private TextBox textBox1;
        private Button btBuscar;
        private Label lbNombreProducto;
        private Label precioUnitario;
        private Label cantidad;
        private Label precioTotal;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label totalVenta;
        private Panel panel1;
    }
}