namespace DB
{
    partial class AgregarConvenios
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
            txtBoxNombreConve = new TextBox();
            txtBoxDireccionConve = new TextBox();
            txtBoxCorreoConve = new TextBox();
            btnAgregarConve = new Button();
            TablaDeDatos = new DataGridView();
            BtnModificar = new Button();
            BtnMedico = new Button();
            MaskTel = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 32);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar Convenios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "Hospital";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 176);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(334, 99);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 245);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // txtBoxNombreConve
            // 
            txtBoxNombreConve.Location = new Point(116, 93);
            txtBoxNombreConve.Name = "txtBoxNombreConve";
            txtBoxNombreConve.Size = new Size(196, 23);
            txtBoxNombreConve.TabIndex = 5;
            // 
            // txtBoxDireccionConve
            // 
            txtBoxDireccionConve.Location = new Point(117, 170);
            txtBoxDireccionConve.Name = "txtBoxDireccionConve";
            txtBoxDireccionConve.Size = new Size(431, 23);
            txtBoxDireccionConve.TabIndex = 6;
            // 
            // txtBoxCorreoConve
            // 
            txtBoxCorreoConve.Location = new Point(117, 239);
            txtBoxCorreoConve.Name = "txtBoxCorreoConve";
            txtBoxCorreoConve.Size = new Size(431, 23);
            txtBoxCorreoConve.TabIndex = 7;
            // 
            // btnAgregarConve
            // 
            btnAgregarConve.BackColor = SystemColors.ActiveCaption;
            btnAgregarConve.Dock = DockStyle.Bottom;
            btnAgregarConve.FlatAppearance.BorderSize = 0;
            btnAgregarConve.FlatStyle = FlatStyle.Flat;
            btnAgregarConve.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarConve.ForeColor = Color.White;
            btnAgregarConve.Location = new Point(0, 610);
            btnAgregarConve.Name = "btnAgregarConve";
            btnAgregarConve.Size = new Size(799, 55);
            btnAgregarConve.TabIndex = 9;
            btnAgregarConve.Text = "Agregar";
            btnAgregarConve.UseVisualStyleBackColor = false;
            btnAgregarConve.Click += btnAgregarConve_Click;
            // 
            // TablaDeDatos
            // 
            TablaDeDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDeDatos.Location = new Point(49, 299);
            TablaDeDatos.Name = "TablaDeDatos";
            TablaDeDatos.RowTemplate.Height = 25;
            TablaDeDatos.Size = new Size(676, 268);
            TablaDeDatos.TabIndex = 10;
            TablaDeDatos.Click += TablaDeDatos_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(650, 88);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 11;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnMedico
            // 
            BtnMedico.Location = new Point(650, 169);
            BtnMedico.Name = "BtnMedico";
            BtnMedico.Size = new Size(75, 23);
            BtnMedico.TabIndex = 13;
            BtnMedico.Text = "Medicos";
            BtnMedico.UseVisualStyleBackColor = true;
            BtnMedico.Click += BtnMedico_Click;
            // 
            // MaskTel
            // 
            MaskTel.Location = new Point(398, 99);
            MaskTel.Mask = "9999-9999";
            MaskTel.Name = "MaskTel";
            MaskTel.Size = new Size(64, 23);
            MaskTel.TabIndex = 14;
            MaskTel.TextAlign = HorizontalAlignment.Center;
            // 
            // AgregarConvenios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(799, 665);
            Controls.Add(MaskTel);
            Controls.Add(BtnMedico);
            Controls.Add(BtnModificar);
            Controls.Add(TablaDeDatos);
            Controls.Add(btnAgregarConve);
            Controls.Add(txtBoxCorreoConve);
            Controls.Add(txtBoxDireccionConve);
            Controls.Add(txtBoxNombreConve);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarConvenios";
            Text = "agregar convenios";
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxNombreConve;
        private TextBox txtBoxDireccionConve;
        private TextBox txtBoxCorreoConve;
        private Button btnAgregarConve;
        private DataGridView TablaDeDatos;
        private Button BtnModificar;
        private Button BtnMedico;
        private MaskedTextBox MaskTel;
    }
}