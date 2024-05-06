namespace DB
{
    partial class PagarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarEmpleados));
            label1 = new Label();
            btnPagar = new Button();
            label2 = new Label();
            txtBoxBuscar = new TextBox();
            dataGridViewPagarEmp = new DataGridView();
            Dui = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            btnBuscarPagar = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagarEmp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 0;
            label1.Text = "Pagar Empleados";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.ActiveCaption;
            btnPagar.Dock = DockStyle.Bottom;
            btnPagar.FlatAppearance.BorderColor = Color.White;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(0, 324);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(670, 59);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 69);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 2;
            label2.Text = "Buscar Empleado";
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(224, 71);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.Size = new Size(189, 23);
            txtBoxBuscar.TabIndex = 4;
            // 
            // dataGridViewPagarEmp
            // 
            dataGridViewPagarEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagarEmp.Columns.AddRange(new DataGridViewColumn[] { Dui, Nombre, Cargo });
            dataGridViewPagarEmp.Location = new Point(68, 122);
            dataGridViewPagarEmp.Name = "dataGridViewPagarEmp";
            dataGridViewPagarEmp.RowTemplate.Height = 25;
            dataGridViewPagarEmp.Size = new Size(345, 164);
            dataGridViewPagarEmp.TabIndex = 5;
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
            // btnBuscarPagar
            // 
            btnBuscarPagar.FlatAppearance.BorderSize = 0;
            btnBuscarPagar.FlatStyle = FlatStyle.Flat;
            btnBuscarPagar.Image = (Image)resources.GetObject("btnBuscarPagar.Image");
            btnBuscarPagar.Location = new Point(431, 63);
            btnBuscarPagar.Name = "btnBuscarPagar";
            btnBuscarPagar.Size = new Size(35, 37);
            btnBuscarPagar.TabIndex = 6;
            btnBuscarPagar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(447, 223);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 7;
            label3.Text = "Total a Pagar: $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(447, 265);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 8;
            label4.Text = "$";
            // 
            // PagarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(670, 383);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBuscarPagar);
            Controls.Add(dataGridViewPagarEmp);
            Controls.Add(txtBoxBuscar);
            Controls.Add(label2);
            Controls.Add(btnPagar);
            Controls.Add(label1);
            Name = "PagarEmpleados";
            Text = "Pagar Empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagarEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPagar;
        private Label label2;
        private TextBox txtBoxBuscar;
        private DataGridView dataGridViewPagarEmp;
        private DataGridViewTextBoxColumn Dui;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private Button btnBuscarPagar;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
    }
}