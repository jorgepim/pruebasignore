namespace farmacia.Formularios
{
    partial class AgregarMedicos
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
            TxtNombre = new TextBox();
            CBEspecialidades = new ComboBox();
            MaskTel = new MaskedTextBox();
            TablaDeDatos = new DataGridView();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(284, 19);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 0;
            label1.Text = "Agregar Médicos";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(49, 114);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(503, 114);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 2;
            label3.Text = "Especialidad:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(49, 164);
            label4.Name = "label4";
            label4.Size = new Size(65, 29);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(120, 114);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(344, 23);
            TxtNombre.TabIndex = 4;
            // 
            // CBEspecialidades
            // 
            CBEspecialidades.FormattingEnabled = true;
            CBEspecialidades.Location = new Point(596, 114);
            CBEspecialidades.Name = "CBEspecialidades";
            CBEspecialidades.Size = new Size(121, 23);
            CBEspecialidades.TabIndex = 5;
            // 
            // MaskTel
            // 
            MaskTel.Location = new Point(120, 163);
            MaskTel.Mask = "9999-9999";
            MaskTel.Name = "MaskTel";
            MaskTel.Size = new Size(58, 23);
            MaskTel.TabIndex = 6;
            MaskTel.TextAlign = HorizontalAlignment.Center;
            // 
            // TablaDeDatos
            // 
            TablaDeDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDeDatos.Location = new Point(49, 233);
            TablaDeDatos.Name = "TablaDeDatos";
            TablaDeDatos.RowTemplate.Height = 25;
            TablaDeDatos.Size = new Size(541, 268);
            TablaDeDatos.TabIndex = 7;
            TablaDeDatos.Click += TablaDeDatos_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(642, 233);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(642, 297);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 9;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // AgregarMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(759, 539);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(TablaDeDatos);
            Controls.Add(MaskTel);
            Controls.Add(CBEspecialidades);
            Controls.Add(TxtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarMedicos";
            Text = "AgregarMedicos";
            ((System.ComponentModel.ISupportInitialize)TablaDeDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtNombre;
        private ComboBox CBEspecialidades;
        private MaskedTextBox MaskTel;
        private DataGridView TablaDeDatos;
        private Button BtnAgregar;
        private Button BtnModificar;
    }
}