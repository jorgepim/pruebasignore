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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxNombreConve = new TextBox();
            txtBoxDireccionConve = new TextBox();
            txtBoxCorreoConve = new TextBox();
            btnAgregarConve = new Button();
            BtnModificar = new Button();
            BtnMedico = new Button();
            MaskTel = new MaskedTextBox();
            TablaDeDatos = new DataGridView();
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
            // TablaDeDatos
            // 
            TablaDeDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TablaDeDatos.BackgroundColor = Color.FromArgb(79, 80, 95);
            TablaDeDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TablaDeDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TablaDeDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDeDatos.EnableHeadersVisualStyles = false;
            TablaDeDatos.GridColor = SystemColors.ActiveCaption;
            TablaDeDatos.Location = new Point(139, 307);
            TablaDeDatos.Margin = new Padding(3, 2, 3, 2);
            TablaDeDatos.Name = "TablaDeDatos";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TablaDeDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            TablaDeDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(79, 80, 95);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            TablaDeDatos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            TablaDeDatos.RowTemplate.Height = 29;
            TablaDeDatos.Size = new Size(494, 250);
            TablaDeDatos.TabIndex = 43;
            TablaDeDatos.Click += TablaDeDatos_Click;
            // 
            // AgregarConvenios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(799, 665);
            Controls.Add(TablaDeDatos);
            Controls.Add(MaskTel);
            Controls.Add(BtnMedico);
            Controls.Add(BtnModificar);
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
        private Button BtnModificar;
        private Button BtnMedico;
        private MaskedTextBox MaskTel;
        private DataGridView TablaDeDatos;
    }
}