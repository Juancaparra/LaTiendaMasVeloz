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
            panel1 = new Panel();
            totalVenta = new Label();
            label7 = new Label();
            precioUnitario = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            precioTotal = new Label();
            cantidad = new Label();
            lbNombreProducto = new Label();
            btBuscar = new Button();
            fecha = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(494, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 43);
            panel1.TabIndex = 72;
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
            // precioUnitario
            // 
            precioUnitario.AutoSize = true;
            precioUnitario.Location = new Point(240, 256);
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
            tableLayoutPanel1.Location = new Point(40, 279);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.Size = new Size(628, 125);
            tableLayoutPanel1.TabIndex = 69;
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(497, 256);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(91, 20);
            precioTotal.TabIndex = 68;
            precioTotal.Text = "Valor Total:  ";
            // 
            // cantidad
            // 
            cantidad.AutoSize = true;
            cantidad.Location = new Point(414, 256);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(80, 20);
            cantidad.TabIndex = 67;
            cantidad.Text = "Cantidad:  ";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(40, 256);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(71, 20);
            lbNombreProducto.TabIndex = 65;
            lbNombreProducto.Text = "Nombre: ";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(415, 112);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 64;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // fecha
            // 
            fecha.Location = new Point(504, 32);
            fecha.Name = "fecha";
            fecha.Size = new Size(283, 27);
            fecha.TabIndex = 61;
            fecha.Value = new DateTime(2025, 4, 1, 0, 0, 0, 0);
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
            // textBox2
            // 
            textBox2.Location = new Point(244, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 73;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(385, 474);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(0, 20);
            lbResultado.TabIndex = 75;
            // 
            // ConsultarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 551);
            Controls.Add(lbResultado);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(totalVenta);
            Controls.Add(label7);
            Controls.Add(precioUnitario);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(precioTotal);
            Controls.Add(cantidad);
            Controls.Add(lbNombreProducto);
            Controls.Add(btBuscar);
            Controls.Add(fecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarVenta";
            Text = "ConsultarVenta";
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
        private Button btBuscar;
        private DateTimePicker fecha;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox textBox2;
        private Label lbResultado;
    }
}