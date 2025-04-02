namespace Principal
{
    partial class ConsultarProducto
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
            lbResultadoConsultar = new Label();
            lbPrecioConsultar = new Label();
            lbNombreConsultar = new Label();
            label4 = new Label();
            btConsultar = new Button();
            tbReferencia = new TextBox();
            lbMarcaConsultar = new Label();
            lbNombreGerente = new Label();
            lbNombreProveedor = new Label();
            lbStock = new Label();
            lbFechaLlegada = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(278, 78);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 19;
            label3.Text = "CONSULTAR PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(375, 54);
            label1.TabIndex = 13;
            label1.Text = "La Tienda Mas Veloz";
            // 
            // lbResultadoConsultar
            // 
            lbResultadoConsultar.AutoSize = true;
            lbResultadoConsultar.Location = new Point(369, 403);
            lbResultadoConsultar.Name = "lbResultadoConsultar";
            lbResultadoConsultar.Size = new Size(0, 20);
            lbResultadoConsultar.TabIndex = 43;
            // 
            // lbPrecioConsultar
            // 
            lbPrecioConsultar.AutoSize = true;
            lbPrecioConsultar.Location = new Point(217, 289);
            lbPrecioConsultar.Name = "lbPrecioConsultar";
            lbPrecioConsultar.Size = new Size(61, 20);
            lbPrecioConsultar.TabIndex = 42;
            lbPrecioConsultar.Text = "Precio:  ";
            // 
            // lbNombreConsultar
            // 
            lbNombreConsultar.AutoSize = true;
            lbNombreConsultar.Location = new Point(217, 243);
            lbNombreConsultar.Name = "lbNombreConsultar";
            lbNombreConsultar.Size = new Size(71, 20);
            lbNombreConsultar.TabIndex = 41;
            lbNombreConsultar.Text = "Nombre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 142);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 40;
            label4.Text = "Ingrese la referencia";
            // 
            // btConsultar
            // 
            btConsultar.Location = new Point(373, 189);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(94, 29);
            btConsultar.TabIndex = 39;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbReferencia
            // 
            tbReferencia.Location = new Point(349, 139);
            tbReferencia.Name = "tbReferencia";
            tbReferencia.Size = new Size(133, 27);
            tbReferencia.TabIndex = 38;
            // 
            // lbMarcaConsultar
            // 
            lbMarcaConsultar.AutoSize = true;
            lbMarcaConsultar.Location = new Point(217, 334);
            lbMarcaConsultar.Name = "lbMarcaConsultar";
            lbMarcaConsultar.Size = new Size(61, 20);
            lbMarcaConsultar.TabIndex = 44;
            lbMarcaConsultar.Text = "Marca:  ";
            // 
            // lbNombreGerente
            // 
            lbNombreGerente.AutoSize = true;
            lbNombreGerente.Location = new Point(482, 245);
            lbNombreGerente.Name = "lbNombreGerente";
            lbNombreGerente.Size = new Size(150, 20);
            lbNombreGerente.TabIndex = 45;
            lbNombreGerente.Text = "Nombre Encargado:  ";
            // 
            // lbNombreProveedor
            // 
            lbNombreProveedor.AutoSize = true;
            lbNombreProveedor.Location = new Point(482, 289);
            lbNombreProveedor.Name = "lbNombreProveedor";
            lbNombreProveedor.Size = new Size(147, 20);
            lbNombreProveedor.TabIndex = 46;
            lbNombreProveedor.Text = "Nombre Proveedor:  ";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(217, 376);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(56, 20);
            lbStock.TabIndex = 47;
            lbStock.Text = "Stock:  ";
            lbStock.Click += lbStock_Click;
            // 
            // lbFechaLlegada
            // 
            lbFechaLlegada.AutoSize = true;
            lbFechaLlegada.Location = new Point(482, 334);
            lbFechaLlegada.Name = "lbFechaLlegada";
            lbFechaLlegada.Size = new Size(119, 20);
            lbFechaLlegada.TabIndex = 48;
            lbFechaLlegada.Text = "Fecha Llegada:   ";
            // 
            // ConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbFechaLlegada);
            Controls.Add(lbStock);
            Controls.Add(lbNombreProveedor);
            Controls.Add(lbNombreGerente);
            Controls.Add(lbMarcaConsultar);
            Controls.Add(lbResultadoConsultar);
            Controls.Add(lbPrecioConsultar);
            Controls.Add(lbNombreConsultar);
            Controls.Add(label4);
            Controls.Add(btConsultar);
            Controls.Add(tbReferencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarProducto";
            Text = "ConsultarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbResultadoConsultar;
        private Label lbPrecioConsultar;
        private Label lbNombreConsultar;
        private Label label4;
        private Button btConsultar;
        private TextBox tbReferencia;
        private Label lbMarcaConsultar;
        private Label lbNombreGerente;
        private Label lbNombreProveedor;
        private Label lbStock;
        private Label lbFechaLlegada;
    }
}