namespace DB
{
    partial class AgregarLotes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            MaskFechaV = new MaskedTextBox();
            CBProducto = new ComboBox();
            CBProveedor = new ComboBox();
            CBSucursal = new ComboBox();
            MaskFechaC = new MaskedTextBox();
            MaskCanti = new MaskedTextBox();
            MaskDesc = new MaskedTextBox();
            MaskPrecioC = new MaskedTextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(265, 22);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Lotes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "id Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(439, 85);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "id Sucursal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(231, 85);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "id Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 157);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(314, 157);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Vencimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(65, 235);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio Compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(265, 235);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 7;
            label8.Text = "Descuento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(439, 235);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 328);
            button1.Name = "button1";
            button1.Size = new Size(670, 55);
            button1.TabIndex = 19;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MaskFechaV
            // 
            MaskFechaV.Location = new Point(439, 154);
            MaskFechaV.Mask = "00/00/0000";
            MaskFechaV.Name = "MaskFechaV";
            MaskFechaV.Size = new Size(156, 23);
            MaskFechaV.TabIndex = 20;
            MaskFechaV.TextAlign = HorizontalAlignment.Center;
            MaskFechaV.ValidatingType = typeof(DateTime);
            // 
            // CBProducto
            // 
            CBProducto.FormattingEnabled = true;
            CBProducto.Location = new Point(95, 82);
            CBProducto.Name = "CBProducto";
            CBProducto.Size = new Size(121, 23);
            CBProducto.TabIndex = 21;
            // 
            // CBProveedor
            // 
            CBProveedor.FormattingEnabled = true;
            CBProveedor.Location = new Point(312, 82);
            CBProveedor.Name = "CBProveedor";
            CBProveedor.Size = new Size(121, 23);
            CBProveedor.TabIndex = 22;
            // 
            // CBSucursal
            // 
            CBSucursal.FormattingEnabled = true;
            CBSucursal.Location = new Point(512, 82);
            CBSucursal.Name = "CBSucursal";
            CBSucursal.Size = new Size(121, 23);
            CBSucursal.TabIndex = 23;
            // 
            // MaskFechaC
            // 
            MaskFechaC.Location = new Point(125, 154);
            MaskFechaC.Mask = "00/00/0000";
            MaskFechaC.Name = "MaskFechaC";
            MaskFechaC.Size = new Size(156, 23);
            MaskFechaC.TabIndex = 24;
            MaskFechaC.TextAlign = HorizontalAlignment.Center;
            MaskFechaC.ValidatingType = typeof(DateTime);
            // 
            // MaskCanti
            // 
            MaskCanti.Location = new Point(503, 232);
            MaskCanti.Mask = "99999";
            MaskCanti.Name = "MaskCanti";
            MaskCanti.Size = new Size(94, 23);
            MaskCanti.TabIndex = 25;
            MaskCanti.TextAlign = HorizontalAlignment.Center;
            MaskCanti.ValidatingType = typeof(int);
            // 
            // MaskDesc
            // 
            MaskDesc.Location = new Point(337, 232);
            MaskDesc.Mask = "999";
            MaskDesc.Name = "MaskDesc";
            MaskDesc.Size = new Size(43, 23);
            MaskDesc.TabIndex = 26;
            MaskDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // MaskPrecioC
            // 
            MaskPrecioC.Location = new Point(160, 232);
            MaskPrecioC.Mask = "9999.99";
            MaskPrecioC.Name = "MaskPrecioC";
            MaskPrecioC.Size = new Size(94, 23);
            MaskPrecioC.TabIndex = 27;
            MaskPrecioC.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(386, 235);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 28;
            label10.Text = "%";
            // 
            // AgregarLotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(670, 383);
            Controls.Add(label10);
            Controls.Add(MaskPrecioC);
            Controls.Add(MaskDesc);
            Controls.Add(MaskCanti);
            Controls.Add(MaskFechaC);
            Controls.Add(CBSucursal);
            Controls.Add(CBProveedor);
            Controls.Add(CBProducto);
            Controls.Add(MaskFechaV);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarLotes";
            Text = "Agregar Lotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private MaskedTextBox MaskFechaV;
        private ComboBox CBProducto;
        private ComboBox CBProveedor;
        private ComboBox CBSucursal;
        private MaskedTextBox MaskFechaC;
        private MaskedTextBox MaskCanti;
        private MaskedTextBox MaskDesc;
        private MaskedTextBox MaskPrecioC;
        private Label label10;
    }
}
