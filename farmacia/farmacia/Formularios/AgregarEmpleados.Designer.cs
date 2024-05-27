namespace DB
{
    partial class AgregarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            txtBoxDireccion = new TextBox();
            txtBoxTelefono = new TextBox();
            txtBoxEdad = new TextBox();
            txtBoxNombre = new TextBox();
            label8 = new Label();
            comboBoxCargo = new ComboBox();
            comboBoxSucursal = new ComboBox();
            label9 = new Label();
            txtBuscar = new TextBox();
            label10 = new Label();
            btnPagarEmp = new Button();
            btnRegisHora = new Button();
            tablaEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tablaEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(253, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 113);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(360, 172);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Edad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(360, 232);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 230);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Dock = DockStyle.Bottom;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(1303, 60);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBoxDireccion
            // 
            txtBoxDireccion.Location = new Point(135, 172);
            txtBoxDireccion.Name = "txtBoxDireccion";
            txtBoxDireccion.Size = new Size(176, 23);
            txtBoxDireccion.TabIndex = 10;
            // 
            // txtBoxTelefono
            // 
            txtBoxTelefono.Location = new Point(135, 230);
            txtBoxTelefono.Name = "txtBoxTelefono";
            txtBoxTelefono.Size = new Size(176, 23);
            txtBoxTelefono.TabIndex = 11;
            // 
            // txtBoxEdad
            // 
            txtBoxEdad.Location = new Point(421, 167);
            txtBoxEdad.Name = "txtBoxEdad";
            txtBoxEdad.Size = new Size(181, 23);
            txtBoxEdad.TabIndex = 13;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(135, 105);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(176, 23);
            txtBoxNombre.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(64, 172);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Direccion:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(421, 227);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(181, 23);
            comboBoxCargo.TabIndex = 17;
            // 
            // comboBoxSucursal
            // 
            comboBoxSucursal.FormattingEnabled = true;
            comboBoxSucursal.Location = new Point(135, 276);
            comboBoxSucursal.Name = "comboBoxSucursal";
            comboBoxSucursal.Size = new Size(176, 23);
            comboBoxSucursal.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(64, 278);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 21;
            label9.Text = "Sucursal";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(79, 80, 95);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(807, 21);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(486, 16);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(736, 16);
            label10.Name = "label10";
            label10.Size = new Size(60, 21);
            label10.TabIndex = 24;
            label10.Text = "Buscar";
            // 
            // btnPagarEmp
            // 
            btnPagarEmp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPagarEmp.BackColor = Color.FromArgb(0, 141, 218);
            btnPagarEmp.FlatAppearance.BorderColor = Color.FromArgb(7, 65, 115);
            btnPagarEmp.FlatStyle = FlatStyle.Flat;
            btnPagarEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagarEmp.ForeColor = Color.White;
            btnPagarEmp.Image = (Image)resources.GetObject("btnPagarEmp.Image");
            btnPagarEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagarEmp.Location = new Point(994, 230);
            btnPagarEmp.Name = "btnPagarEmp";
            btnPagarEmp.Padding = new Padding(10, 0, 0, 0);
            btnPagarEmp.Size = new Size(183, 56);
            btnPagarEmp.TabIndex = 25;
            btnPagarEmp.Text = "Pagar\r\nEmpleados";
            btnPagarEmp.UseVisualStyleBackColor = false;
            btnPagarEmp.Click += btnPagarEmp_Click;
            // 
            // btnRegisHora
            // 
            btnRegisHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegisHora.BackColor = Color.FromArgb(0, 141, 218);
            btnRegisHora.FlatAppearance.BorderColor = Color.FromArgb(7, 65, 115);
            btnRegisHora.FlatStyle = FlatStyle.Flat;
            btnRegisHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisHora.ForeColor = Color.White;
            btnRegisHora.Image = (Image)resources.GetObject("btnRegisHora.Image");
            btnRegisHora.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegisHora.Location = new Point(736, 232);
            btnRegisHora.Name = "btnRegisHora";
            btnRegisHora.Padding = new Padding(10, 0, 0, 0);
            btnRegisHora.Size = new Size(183, 55);
            btnRegisHora.TabIndex = 26;
            btnRegisHora.Text = "Registrar\r\nHora";
            btnRegisHora.UseVisualStyleBackColor = false;
            btnRegisHora.Click += btnRegisHora_Click;
            // 
            // tablaEmpleados
            // 
            tablaEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaEmpleados.BackgroundColor = Color.FromArgb(79, 80, 95);
            tablaEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tablaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tablaEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEmpleados.EnableHeadersVisualStyles = false;
            tablaEmpleados.GridColor = SystemColors.ActiveCaption;
            tablaEmpleados.Location = new Point(736, 75);
            tablaEmpleados.Margin = new Padding(3, 2, 3, 2);
            tablaEmpleados.Name = "tablaEmpleados";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tablaEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tablaEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(79, 80, 95);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            tablaEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tablaEmpleados.RowTemplate.Height = 29;
            tablaEmpleados.Size = new Size(558, 140);
            tablaEmpleados.TabIndex = 44;
            tablaEmpleados.CellContentClick += tablaEmpleados_CellClick;
            // 
            // AgregarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1303, 383);
            Controls.Add(tablaEmpleados);
            Controls.Add(btnRegisHora);
            Controls.Add(btnPagarEmp);
            Controls.Add(label10);
            Controls.Add(txtBuscar);
            Controls.Add(comboBoxSucursal);
            Controls.Add(label9);
            Controls.Add(comboBoxCargo);
            Controls.Add(label8);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxEdad);
            Controls.Add(txtBoxTelefono);
            Controls.Add(txtBoxDireccion);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEmpleados";
            Text = "Agregar Empleados";
            ((System.ComponentModel.ISupportInitialize)tablaEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Button btnAgregar;
        private TextBox txtBoxDireccion;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxEdad;
        private TextBox txtBoxNombre;
        private Label label8;
        private ComboBox comboBoxCargo;
        private ComboBox comboBoxSucursal;
        private Label label9;
        private TextBox txtBuscar;
        private Label label10;
        private Button btnPagarEmp;
        private Button btnRegisHora;
        private DataGridView tablaEmpleados;
    }
}