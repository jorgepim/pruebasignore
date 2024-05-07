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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            txtBoxApellido = new TextBox();
            txtBoxDireccion = new TextBox();
            txtBoxTelefono = new TextBox();
            txtBoxEdad = new TextBox();
            txtBoxNombre = new TextBox();
            label8 = new Label();
            comboBoxCargo = new ComboBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(361, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
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
            label6.Location = new Point(395, 175);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Edad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(360, 240);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 235);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            label5.Click += label5_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Dock = DockStyle.Bottom;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(670, 60);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(421, 105);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(181, 23);
            txtBoxApellido.TabIndex = 9;
            // 
            // txtBoxDireccion
            // 
            txtBoxDireccion.Location = new Point(130, 167);
            txtBoxDireccion.Name = "txtBoxDireccion";
            txtBoxDireccion.Size = new Size(206, 23);
            txtBoxDireccion.TabIndex = 10;
            // 
            // txtBoxTelefono
            // 
            txtBoxTelefono.Location = new Point(125, 227);
            txtBoxTelefono.Name = "txtBoxTelefono";
            txtBoxTelefono.Size = new Size(145, 23);
            txtBoxTelefono.TabIndex = 11;
            // 
            // txtBoxEdad
            // 
            txtBoxEdad.Location = new Point(437, 167);
            txtBoxEdad.Name = "txtBoxEdad";
            txtBoxEdad.Size = new Size(88, 23);
            txtBoxEdad.TabIndex = 13;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(125, 105);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(181, 23);
            txtBoxNombre.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(64, 175);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Direccion:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(437, 235);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(121, 23);
            comboBoxCargo.TabIndex = 17;
            // 
            // AgregarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(670, 383);
            Controls.Add(comboBoxCargo);
            Controls.Add(label8);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxEdad);
            Controls.Add(txtBoxTelefono);
            Controls.Add(txtBoxDireccion);
            Controls.Add(txtBoxApellido);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEmpleados";
            Text = "Agregar Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Button btnAgregar;
        private TextBox txtBoxApellido;
        private TextBox txtBoxDireccion;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxEdad;
        private TextBox txtBoxNombre;
        private Label label8;
        private ComboBox comboBoxCargo;
    }
}