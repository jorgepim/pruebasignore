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
            label1 = new Label();
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
            Column1 = new DataGridViewTextBoxColumn();
            cCantidad = new DataGridViewTextBoxColumn();
            CProducto = new DataGridViewTextBoxColumn();
            cPU = new DataGridViewTextBoxColumn();
            CSub = new DataGridViewTextBoxColumn();
            label8 = new Label();
            CBProductos = new ComboBox();
            BtnEliminar = new Button();
            BtnEjecutar = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            labelDescuento = new Label();
            LabelIva = new Label();
            labelTotal = new Label();
            label12 = new Label();
            txtTotal = new TextBox();
            label13 = new Label();
            labelCambio = new Label();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SPCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.login;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(10, 158);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 3;
            label4.Text = "Presentación:";
            // 
            // CBMarca
            // 
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
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(475, 49);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 7;
            label5.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(581, 49);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(239, 23);
            txtBuscar.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(890, 47);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(108, 34);
            BtnBuscar.TabIndex = 9;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
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
            SPCantidad.Location = new Point(131, 242);
            SPCantidad.Margin = new Padding(3, 2, 3, 2);
            SPCantidad.Name = "SPCantidad";
            SPCantidad.Size = new Size(66, 23);
            SPCantidad.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
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
            // 
            // tablaProductos
            // 
            tablaProductos.BackgroundColor = SystemColors.ButtonHighlight;
            tablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, cCantidad, CProducto, cPU, CSub });
            tablaProductos.Location = new Point(490, 215);
            tablaProductos.Margin = new Padding(3, 2, 3, 2);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.RowHeadersWidth = 51;
            tablaProductos.RowTemplate.Height = 29;
            tablaProductos.Size = new Size(592, 173);
            tablaProductos.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // cCantidad
            // 
            cCantidad.HeaderText = "Cantidad";
            cCantidad.MinimumWidth = 6;
            cCantidad.Name = "cCantidad";
            cCantidad.Width = 125;
            // 
            // CProducto
            // 
            CProducto.HeaderText = "Producto";
            CProducto.MinimumWidth = 6;
            CProducto.Name = "CProducto";
            CProducto.Width = 125;
            // 
            // cPU
            // 
            cPU.HeaderText = "P/U";
            cPU.MinimumWidth = 6;
            cPU.Name = "cPU";
            cPU.Width = 125;
            // 
            // CSub
            // 
            CSub.HeaderText = "Subtotal";
            CSub.MinimumWidth = 6;
            CSub.Name = "CSub";
            CSub.Width = 125;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(490, 151);
            label8.Name = "label8";
            label8.Size = new Size(113, 32);
            label8.TabIndex = 17;
            label8.Text = "Productos:";
            // 
            // CBProductos
            // 
            CBProductos.FormattingEnabled = true;
            CBProductos.Location = new Point(623, 155);
            CBProductos.Margin = new Padding(3, 2, 3, 2);
            CBProductos.Name = "CBProductos";
            CBProductos.Size = new Size(459, 23);
            CBProductos.TabIndex = 18;
            CBProductos.Text = "Seleccionar";
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
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(880, 431);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 21;
            label9.Text = "Descuento:";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(880, 464);
            label10.Name = "label10";
            label10.Size = new Size(117, 32);
            label10.TabIndex = 22;
            label10.Text = "IVA:";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(880, 496);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 23;
            label11.Text = "Total:";
            // 
            // labelDescuento
            // 
            labelDescuento.Location = new Point(1046, 440);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(63, 19);
            labelDescuento.TabIndex = 24;
            labelDescuento.Text = "label12";
            // 
            // LabelIva
            // 
            LabelIva.Location = new Point(1046, 470);
            LabelIva.Name = "LabelIva";
            LabelIva.Size = new Size(51, 15);
            LabelIva.TabIndex = 25;
            LabelIva.Text = "label12";
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(1046, 502);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(51, 15);
            labelTotal.TabIndex = 26;
            labelTotal.Text = "label12";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(238, 485);
            label12.Name = "label12";
            label12.Size = new Size(160, 32);
            label12.TabIndex = 27;
            label12.Text = "total ingresado:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(405, 490);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 28;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(570, 478);
            label13.Name = "label13";
            label13.Size = new Size(92, 32);
            label13.TabIndex = 29;
            label13.Text = "Cambio:";
            // 
            // labelCambio
            // 
            labelCambio.Location = new Point(683, 485);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(51, 15);
            labelCambio.TabIndex = 30;
            labelCambio.Text = "label12";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(116, 279);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 31;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1185, 562);
            Controls.Add(txtPrecio);
            Controls.Add(labelCambio);
            Controls.Add(label13);
            Controls.Add(txtTotal);
            Controls.Add(label12);
            Controls.Add(labelTotal);
            Controls.Add(LabelIva);
            Controls.Add(labelDescuento);
            Controls.Add(label11);
            Controls.Add(label10);
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
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Factura";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SPCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Label label10;
        private Label label11;
        private Label labelDescuento;
        private Label LabelIva;
        private Label labelTotal;
        private Label label12;
        private TextBox txtTotal;
        private Label label13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cCantidad;
        private DataGridViewTextBoxColumn CProducto;
        private DataGridViewTextBoxColumn cPU;
        private DataGridViewTextBoxColumn CSub;
        private Label labelCambio;
        private TextBox txtPrecio;
    }
}