namespace farmacia
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CBMarca = new ComboBox();
            CBPresentacion = new ComboBox();
            CBCategoria = new ComboBox();
            label5 = new Label();
            txtBuscar = new TextBox();
            BtnBuscar = new Button();
            label6 = new Label();
            splitter1 = new Splitter();
            SPCantidad = new NumericUpDown();
            label7 = new Label();
            BtnAgregar = new Button();
            tablaProductos = new DataGridView();
            label8 = new Label();
            CBProductos = new ComboBox();
            BtnEliminar = new Button();
            BtnEjecutar = new Button();
            label9 = new Label();
            label11 = new Label();
            labelDescuento = new Label();
            LabelIva = new Label();
            label12 = new Label();
            label13 = new Label();
            labelCambio = new Label();
            txtPrecio = new TextBox();
            LBCambio = new Label();
            LBDescuento = new Label();
            LBTotal = new Label();
            labtipopago = new Label();
            CBTipoPago = new ComboBox();
            SPTotalIngresado = new NumericUpDown();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)SPCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SPTotalIngresado).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 158);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 3;
            label4.Text = "Presentación:";
            // 
            // CBMarca
            // 
            CBMarca.BackColor = Color.FromArgb(79, 80, 95);
            CBMarca.ForeColor = Color.White;
            CBMarca.FormattingEnabled = true;
            CBMarca.Location = new Point(175, 88);
            CBMarca.Margin = new Padding(3, 2, 3, 2);
            CBMarca.Name = "CBMarca";
            CBMarca.Size = new Size(181, 23);
            CBMarca.TabIndex = 4;
            CBMarca.SelectedIndexChanged += MarcaCambio;
            // 
            // CBPresentacion
            // 
            CBPresentacion.BackColor = Color.FromArgb(79, 80, 95);
            CBPresentacion.ForeColor = Color.White;
            CBPresentacion.FormattingEnabled = true;
            CBPresentacion.Location = new Point(175, 162);
            CBPresentacion.Margin = new Padding(3, 2, 3, 2);
            CBPresentacion.Name = "CBPresentacion";
            CBPresentacion.Size = new Size(181, 23);
            CBPresentacion.TabIndex = 5;
            CBPresentacion.SelectedIndexChanged += PresentacionCambio;
            // 
            // CBCategoria
            // 
            CBCategoria.BackColor = Color.FromArgb(79, 80, 95);
            CBCategoria.ForeColor = Color.White;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(175, 125);
            CBCategoria.Margin = new Padding(3, 2, 3, 2);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(181, 23);
            CBCategoria.TabIndex = 6;
            CBCategoria.SelectedIndexChanged += CategoriaCambio;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(475, 49);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 7;
            label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(79, 80, 95);
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(581, 49);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(239, 23);
            txtBuscar.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.Location = new Point(890, 47);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 34);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 242);
            label6.Name = "label6";
            label6.Size = new Size(117, 32);
            label6.TabIndex = 10;
            label6.Text = "Cantidad:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 2, 3, 2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 562);
            splitter1.TabIndex = 11;
            splitter1.TabStop = false;
            // 
            // SPCantidad
            // 
            SPCantidad.BackColor = Color.FromArgb(79, 80, 95);
            SPCantidad.ForeColor = Color.White;
            SPCantidad.Location = new Point(131, 242);
            SPCantidad.Margin = new Padding(3, 2, 3, 2);
            SPCantidad.Name = "SPCantidad";
            SPCantidad.Size = new Size(66, 23);
            SPCantidad.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 274);
            label7.Name = "label7";
            label7.Size = new Size(117, 32);
            label7.TabIndex = 13;
            label7.Text = "Precio:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(29, 333);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(116, 33);
            BtnAgregar.TabIndex = 15;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // tablaProductos
            // 
            tablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaProductos.BackgroundColor = SystemColors.ButtonHighlight;
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new Point(406, 158);
            tablaProductos.Margin = new Padding(3, 2, 3, 2);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.RowHeadersWidth = 51;
            tablaProductos.RowTemplate.Height = 29;
            tablaProductos.Size = new Size(592, 173);
            tablaProductos.TabIndex = 16;
            tablaProductos.Click += SeleccionTabla;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(406, 108);
            label8.Name = "label8";
            label8.Size = new Size(113, 32);
            label8.TabIndex = 17;
            label8.Text = "Productos:";
            // 
            // CBProductos
            // 
            CBProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBProductos.BackColor = Color.FromArgb(79, 80, 95);
            CBProductos.ForeColor = Color.White;
            CBProductos.FormattingEnabled = true;
            CBProductos.Location = new Point(539, 112);
            CBProductos.Margin = new Padding(3, 2, 3, 2);
            CBProductos.Name = "CBProductos";
            CBProductos.Size = new Size(459, 23);
            CBProductos.TabIndex = 18;
            CBProductos.Text = "Seleccionar";
            CBProductos.SelectedIndexChanged += CambioProducto;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(29, 393);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(116, 33);
            BtnEliminar.TabIndex = 19;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEjecutar
            // 
            BtnEjecutar.Location = new Point(29, 452);
            BtnEjecutar.Margin = new Padding(3, 2, 3, 2);
            BtnEjecutar.Name = "BtnEjecutar";
            BtnEjecutar.Size = new Size(116, 33);
            BtnEjecutar.TabIndex = 20;
            BtnEjecutar.Text = "Ejecutar";
            BtnEjecutar.UseVisualStyleBackColor = true;
            BtnEjecutar.Click += BtnEjecutar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(778, 357);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 21;
            label9.Text = "Descuento:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(778, 416);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 23;
            label11.Text = "Total:";
            // 
            // labelDescuento
            // 
            labelDescuento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelDescuento.Location = new Point(1046, 440);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(63, 19);
            labelDescuento.TabIndex = 24;
            // 
            // LabelIva
            // 
            LabelIva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelIva.Location = new Point(1046, 470);
            LabelIva.Name = "LabelIva";
            LabelIva.Size = new Size(51, 15);
            LabelIva.TabIndex = 25;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(249, 376);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 27;
            label12.Text = "total ingresado:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(560, 381);
            label13.Name = "label13";
            label13.Size = new Size(92, 32);
            label13.TabIndex = 29;
            label13.Text = "Cambio:";
            // 
            // labelCambio
            // 
            labelCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelCambio.Location = new Point(683, 485);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(51, 15);
            labelCambio.TabIndex = 30;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(79, 80, 95);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(116, 279);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 31;
            // 
            // LBCambio
            // 
            LBCambio.ForeColor = Color.White;
            LBCambio.Location = new Point(645, 384);
            LBCambio.Name = "LBCambio";
            LBCambio.Size = new Size(89, 23);
            LBCambio.TabIndex = 32;
            LBCambio.Text = "label14";
            // 
            // LBDescuento
            // 
            LBDescuento.ForeColor = Color.White;
            LBDescuento.Location = new Point(898, 357);
            LBDescuento.Name = "LBDescuento";
            LBDescuento.Size = new Size(100, 23);
            LBDescuento.TabIndex = 33;
            LBDescuento.Text = "label15";
            // 
            // LBTotal
            // 
            LBTotal.ForeColor = Color.White;
            LBTotal.Location = new Point(898, 425);
            LBTotal.Name = "LBTotal";
            LBTotal.Size = new Size(100, 23);
            LBTotal.TabIndex = 35;
            LBTotal.Text = "label17";
            // 
            // labtipopago
            // 
            labtipopago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labtipopago.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labtipopago.ForeColor = Color.White;
            labtipopago.Location = new Point(525, 468);
            labtipopago.Name = "labtipopago";
            labtipopago.Size = new Size(152, 32);
            labtipopago.TabIndex = 36;
            labtipopago.Text = "Tipo de pago:";
            // 
            // CBTipoPago
            // 
            CBTipoPago.BackColor = Color.FromArgb(79, 80, 95);
            CBTipoPago.ForeColor = Color.White;
            CBTipoPago.FormattingEnabled = true;
            CBTipoPago.Location = new Point(666, 470);
            CBTipoPago.Margin = new Padding(3, 2, 3, 2);
            CBTipoPago.Name = "CBTipoPago";
            CBTipoPago.Size = new Size(181, 23);
            CBTipoPago.TabIndex = 37;
            // 
            // SPTotalIngresado
            // 
            SPTotalIngresado.BackColor = Color.FromArgb(79, 80, 95);
            SPTotalIngresado.DecimalPlaces = 2;
            SPTotalIngresado.ForeColor = Color.White;
            SPTotalIngresado.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            SPTotalIngresado.Location = new Point(415, 381);
            SPTotalIngresado.Margin = new Padding(3, 2, 3, 2);
            SPTotalIngresado.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            SPTotalIngresado.Name = "SPTotalIngresado";
            SPTotalIngresado.Size = new Size(66, 23);
            SPTotalIngresado.TabIndex = 38;
            SPTotalIngresado.ValueChanged += AgregarACambio;
            // 
            // BtnVolver
            // 
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Image = (Image)resources.GetObject("BtnVolver.Image");
            BtnVolver.Location = new Point(29, 21);
            BtnVolver.Margin = new Padding(3, 2, 3, 2);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(49, 48);
            BtnVolver.TabIndex = 39;
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1185, 562);
            Controls.Add(BtnVolver);
            Controls.Add(SPTotalIngresado);
            Controls.Add(CBTipoPago);
            Controls.Add(labtipopago);
            Controls.Add(LBTotal);
            Controls.Add(LBDescuento);
            Controls.Add(LBCambio);
            Controls.Add(txtPrecio);
            Controls.Add(labelCambio);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(LabelIva);
            Controls.Add(labelDescuento);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(BtnEjecutar);
            Controls.Add(BtnEliminar);
            Controls.Add(CBProductos);
            Controls.Add(label8);
            Controls.Add(tablaProductos);
            Controls.Add(BtnAgregar);
            Controls.Add(label7);
            Controls.Add(SPCantidad);
            Controls.Add(splitter1);
            Controls.Add(label6);
            Controls.Add(BtnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(CBCategoria);
            Controls.Add(CBPresentacion);
            Controls.Add(CBMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)SPCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)SPTotalIngresado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CBMarca;
        private ComboBox CBPresentacion;
        private ComboBox CBCategoria;
        private Label label5;
        private TextBox txtBuscar;
        private Button BtnBuscar;
        private Label label6;
        private Splitter splitter1;
        private NumericUpDown SPCantidad;
        private Label label7;
        private Button BtnAgregar;
        private DataGridView tablaProductos;
        private Label label8;
        private ComboBox CBProductos;
        private Button BtnEliminar;
        private Button BtnEjecutar;
        private Label label9;
        private Label label11;
        private Label labelDescuento;
        private Label LabelIva;
        private Label label12;
        private Label label13;
        private Label labelCambio;
        private TextBox txtPrecio;
        private Label LBCambio;
        private Label LBDescuento;
        private Label LBTotal;
        private Label labtipopago;
        private ComboBox CBTipoPago;
        private NumericUpDown SPTotalIngresado;
        private Button BtnVolver;
    }
}