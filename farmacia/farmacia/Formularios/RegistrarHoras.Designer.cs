namespace farmacia.Formularios
{
    partial class RegistrarHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarHoras));
            dataGridViewRegHoras = new DataGridView();
            Dui = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtBoxHoras = new TextBox();
            label3 = new Label();
            comboBoxTipoHora = new ComboBox();
            btnRegistrarHora = new Button();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegHoras).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRegHoras
            // 
            dataGridViewRegHoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegHoras.Columns.AddRange(new DataGridViewColumn[] { Dui, Nombre, Cargo });
            dataGridViewRegHoras.Location = new Point(18, 87);
            dataGridViewRegHoras.Name = "dataGridViewRegHoras";
            dataGridViewRegHoras.RowTemplate.Height = 25;
            dataGridViewRegHoras.Size = new Size(344, 274);
            dataGridViewRegHoras.TabIndex = 0;
            // 
            // Dui
            // 
            Dui.HeaderText = "Dui";
            Dui.Name = "Dui";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(422, 145);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 1;
            label1.Text = "Horas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(465, 47);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 2;
            label2.Text = "Registrar Horas";
            // 
            // txtBoxHoras
            // 
            txtBoxHoras.Location = new Point(518, 144);
            txtBoxHoras.Name = "txtBoxHoras";
            txtBoxHoras.Size = new Size(126, 23);
            txtBoxHoras.TabIndex = 3;
            txtBoxHoras.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(392, 228);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 4;
            label3.Text = "Tipo Horas:";
            // 
            // comboBoxTipoHora
            // 
            comboBoxTipoHora.FormattingEnabled = true;
            comboBoxTipoHora.Location = new Point(518, 227);
            comboBoxTipoHora.Name = "comboBoxTipoHora";
            comboBoxTipoHora.Size = new Size(126, 23);
            comboBoxTipoHora.TabIndex = 5;
            // 
            // btnRegistrarHora
            // 
            btnRegistrarHora.BackColor = SystemColors.ActiveCaption;
            btnRegistrarHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarHora.ForeColor = Color.White;
            btnRegistrarHora.Location = new Point(392, 316);
            btnRegistrarHora.Name = "btnRegistrarHora";
            btnRegistrarHora.Size = new Size(252, 45);
            btnRegistrarHora.TabIndex = 6;
            btnRegistrarHora.Text = "Registrar";
            btnRegistrarHora.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(18, 45);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.Size = new Size(254, 23);
            txtBoxBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(278, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 37);
            btnBuscar.TabIndex = 8;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 20);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 9;
            label4.Text = "Buscar Empleado";
            // 
            // RegistrarHoras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(670, 383);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(btnRegistrarHora);
            Controls.Add(comboBoxTipoHora);
            Controls.Add(label3);
            Controls.Add(txtBoxHoras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewRegHoras);
            Name = "RegistrarHoras";
            Text = "RegistrarHoras";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegHoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRegHoras;
        private DataGridViewTextBoxColumn Dui;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private Label label1;
        private Label label2;
        private TextBox txtBoxHoras;
        private Label label3;
        private ComboBox comboBoxTipoHora;
        private Button btnRegistrarHora;
        private TextBox txtBoxBuscar;
        private Button btnBuscar;
        private Label label4;
    }
}