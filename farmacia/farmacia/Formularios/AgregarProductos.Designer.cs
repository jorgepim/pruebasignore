namespace farmacia.Formularios
{
    partial class AgregarProductos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CbMarca = new ComboBox();
            CbCategoria = new ComboBox();
            CbPresent = new ComboBox();
            checkBox1 = new CheckBox();
            TxtDescrip = new TextBox();
            TxtNombre = new TextBox();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            TablaDeDatos = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(328, 23);
            label1.Name = "label1";
            label1.Size = new Size(121, 38);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(56, 174);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(56, 229);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(317, 229);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 4;
            label5.Text = "Categoría:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(563, 229);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 5;
            label6.Text = "Presentación:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(56, 286);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 6;
            label7.Text = "Necesita receta:";
            // 
            // CbMarca
            // 
            CbMarca.FormattingEnabled = true;
            CbMarca.Location = new Point(149, 228);
            CbMarca.Name = "CbMarca";
            CbMarca.Size = new Size(121, 23);
            CbMarca.TabIndex = 7;
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(410, 229);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(121, 23);
            CbCategoria.TabIndex = 8;
            // 
            // CbPresent
            // 
            CbPresent.FormattingEnabled = true;
            CbPresent.Location = new Point(656, 229);
            CbPresent.Name = "CbPresent";
            CbPresent.Size = new Size(121, 23);
            CbPresent.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(168, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(19, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TxtDescrip
            // 
            TxtDescrip.Location = new Point(149, 174);
            TxtDescrip.Name = "TxtDescrip";
            TxtDescrip.Size = new Size(427, 23);
            TxtDescrip.TabIndex = 11;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(149, 131);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(247, 23);
            TxtNombre.TabIndex = 12;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(729, 396);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 37);
            BtnAgregar.TabIndex = 13;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(729, 489);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(94, 34);
            BtnModificar.TabIndex = 14;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // TablaDeDatos
            // 
            TablaDeDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDeDatos.Location = new Point(56, 335);
            TablaDeDatos.Name = "TablaDeDatos";
            TablaDeDatos.RowTemplate.Height = 25;
            TablaDeDatos.Size = new Size(667, 322);
            TablaDeDatos.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 50, 0, 0, 131072 });
            numericUpDown1.Location = new Point(305, 284);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(77, 23);
            numericUpDown1.TabIndex = 16;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(212, 284);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 17;
            label8.Text = "Precio venta:";
            // 
            // AgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(898, 693);
            Controls.Add(label8);
            Controls.Add(numericUpDown1);
            Controls.Add(TablaDeDatos);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNombre);
            Controls.Add(TxtDescrip);
            Controls.Add(checkBox1);
            Controls.Add(CbPresent);
            Controls.Add(CbCategoria);
            Controls.Add(CbMarca);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProductos";
            Text = "AgregarProducots";
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private ComboBox CbMarca;
        private ComboBox CbCategoria;
        private ComboBox CbPresent;
        private CheckBox checkBox1;
        private TextBox TxtDescrip;
        private TextBox TxtNombre;
        private Button BtnAgregar;
        private Button BtnModificar;
        private DataGridView TablaDeDatos;
        private NumericUpDown numericUpDown1;
        private Label label8;
    }
}