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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBPresentacion = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SPCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.LabelIva = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.LBCambio = new System.Windows.Forms.Label();
            this.LBDescuento = new System.Windows.Forms.Label();
            this.LBTotal = new System.Windows.Forms.Label();
            this.labtipopago = new System.Windows.Forms.Label();
            this.CBTipoPago = new System.Windows.Forms.ComboBox();
            this.SPTotalIngresado = new System.Windows.Forms.NumericUpDown();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPTotalIngresado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Presentación:";
            // 
            // CBMarca
            // 
            this.CBMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.CBMarca.ForeColor = System.Drawing.Color.White;
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(200, 117);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(206, 28);
            this.CBMarca.TabIndex = 4;
            // 
            // CBPresentacion
            // 
            this.CBPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.CBPresentacion.ForeColor = System.Drawing.Color.White;
            this.CBPresentacion.FormattingEnabled = true;
            this.CBPresentacion.Location = new System.Drawing.Point(200, 216);
            this.CBPresentacion.Name = "CBPresentacion";
            this.CBPresentacion.Size = new System.Drawing.Size(206, 28);
            this.CBPresentacion.TabIndex = 5;
            // 
            // CBCategoria
            // 
            this.CBCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.CBCategoria.ForeColor = System.Drawing.Color.White;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(200, 167);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(206, 28);
            this.CBCategoria.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(543, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 43);
            this.label5.TabIndex = 7;
            this.label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(664, 65);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(273, 27);
            this.txtBuscar.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Location = new System.Drawing.Point(1017, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(123, 45);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 43);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 749);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // SPCantidad
            // 
            this.SPCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.SPCantidad.ForeColor = System.Drawing.Color.White;
            this.SPCantidad.Location = new System.Drawing.Point(150, 323);
            this.SPCantidad.Name = "SPCantidad";
            this.SPCantidad.Size = new System.Drawing.Size(75, 27);
            this.SPCantidad.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 43);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(33, 444);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(133, 44);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // tablaProductos
            // 
            this.tablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(464, 211);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 29;
            this.tablaProductos.Size = new System.Drawing.Size(677, 231);
            this.tablaProductos.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(464, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 43);
            this.label8.TabIndex = 17;
            this.label8.Text = "Productos:";
            // 
            // CBProductos
            // 
            this.CBProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.CBProductos.ForeColor = System.Drawing.Color.White;
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(616, 149);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(524, 28);
            this.CBProductos.TabIndex = 18;
            this.CBProductos.Text = "Seleccionar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(33, 524);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(133, 44);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(33, 603);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(133, 44);
            this.BtnEjecutar.TabIndex = 20;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(889, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 43);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descuento:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(889, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 43);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total:";
            // 
            // labelDescuento
            // 
            this.labelDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescuento.Location = new System.Drawing.Point(1195, 587);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(72, 25);
            this.labelDescuento.TabIndex = 24;
            // 
            // LabelIva
            // 
            this.LabelIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIva.Location = new System.Drawing.Point(1195, 627);
            this.LabelIva.Name = "LabelIva";
            this.LabelIva.Size = new System.Drawing.Size(58, 20);
            this.LabelIva.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(285, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 43);
            this.label12.TabIndex = 27;
            this.label12.Text = "total ingresado:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(640, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 43);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cambio:";
            // 
            // labelCambio
            // 
            this.labelCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCambio.Location = new System.Drawing.Point(781, 647);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(58, 20);
            this.labelCambio.TabIndex = 30;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(133, 372);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 27);
            this.txtPrecio.TabIndex = 31;
            // 
            // LBCambio
            // 
            this.LBCambio.ForeColor = System.Drawing.Color.White;
            this.LBCambio.Location = new System.Drawing.Point(737, 512);
            this.LBCambio.Name = "LBCambio";
            this.LBCambio.Size = new System.Drawing.Size(102, 31);
            this.LBCambio.TabIndex = 32;
            this.LBCambio.Text = "label14";
            // 
            // LBDescuento
            // 
            this.LBDescuento.ForeColor = System.Drawing.Color.White;
            this.LBDescuento.Location = new System.Drawing.Point(1026, 476);
            this.LBDescuento.Name = "LBDescuento";
            this.LBDescuento.Size = new System.Drawing.Size(114, 31);
            this.LBDescuento.TabIndex = 33;
            this.LBDescuento.Text = "label15";
            // 
            // LBTotal
            // 
            this.LBTotal.ForeColor = System.Drawing.Color.White;
            this.LBTotal.Location = new System.Drawing.Point(1026, 567);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(114, 31);
            this.LBTotal.TabIndex = 35;
            this.LBTotal.Text = "label17";
            // 
            // labtipopago
            // 
            this.labtipopago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labtipopago.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labtipopago.ForeColor = System.Drawing.Color.White;
            this.labtipopago.Location = new System.Drawing.Point(600, 624);
            this.labtipopago.Name = "labtipopago";
            this.labtipopago.Size = new System.Drawing.Size(174, 43);
            this.labtipopago.TabIndex = 36;
            this.labtipopago.Text = "Tipo de pago:";
            // 
            // CBTipoPago
            // 
            this.CBTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.CBTipoPago.ForeColor = System.Drawing.Color.White;
            this.CBTipoPago.FormattingEnabled = true;
            this.CBTipoPago.Location = new System.Drawing.Point(761, 627);
            this.CBTipoPago.Name = "CBTipoPago";
            this.CBTipoPago.Size = new System.Drawing.Size(206, 28);
            this.CBTipoPago.TabIndex = 37;
            // 
            // SPTotalIngresado
            // 
            this.SPTotalIngresado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.SPTotalIngresado.DecimalPlaces = 2;
            this.SPTotalIngresado.ForeColor = System.Drawing.Color.White;
            this.SPTotalIngresado.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SPTotalIngresado.Location = new System.Drawing.Point(474, 508);
            this.SPTotalIngresado.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SPTotalIngresado.Name = "SPTotalIngresado";
            this.SPTotalIngresado.Size = new System.Drawing.Size(75, 27);
            this.SPTotalIngresado.TabIndex = 38;
            // 
            // BtnVolver
            // 
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.Location = new System.Drawing.Point(33, 28);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(56, 64);
            this.BtnVolver.TabIndex = 39;
            this.BtnVolver.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.SPTotalIngresado);
            this.Controls.Add(this.CBTipoPago);
            this.Controls.Add(this.labtipopago);
            this.Controls.Add(this.LBTotal);
            this.Controls.Add(this.LBDescuento);
            this.Controls.Add(this.LBCambio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabelIva);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SPCantidad);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBPresentacion);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.SPCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPTotalIngresado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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