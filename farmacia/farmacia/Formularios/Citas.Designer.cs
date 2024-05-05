namespace farmacia.Formularios
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDetalles = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            colorDialog1 = new ColorDialog();
            cBhospital = new ComboBox();
            cbDoctor = new ComboBox();
            tabalCitas = new DataGridView();
            CNum = new DataGridViewTextBoxColumn();
            cCliente = new DataGridViewTextBoxColumn();
            CDoc = new DataGridViewTextBoxColumn();
            cEspecialidad = new DataGridViewTextBoxColumn();
            CFecha = new DataGridViewTextBoxColumn();
            cDetalles = new DataGridViewTextBoxColumn();
            button2 = new Button();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            txtFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)tabalCitas).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Location = new Point(29, 225);
            label5.Name = "label5";
            label5.Size = new Size(98, 29);
            label5.TabIndex = 16;
            label5.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Location = new Point(29, 277);
            label3.Name = "label3";
            label3.Size = new Size(98, 29);
            label3.TabIndex = 14;
            label3.Text = "Detalles Adicionales:";
            // 
            // label4
            // 
            label4.Location = new Point(29, 117);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 15;
            label4.Text = "Hospital:";
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(133, 274);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(242, 106);
            txtDetalles.TabIndex = 22;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(29, 64);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(98, 29);
            Nombre.TabIndex = 12;
            Nombre.Text = "Cliente";
            // 
            // label2
            // 
            label2.Location = new Point(29, 171);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 13;
            label2.Text = "Doctor:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(133, 66);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 27);
            txtCliente.TabIndex = 18;
            // 
            // cBhospital
            // 
            cBhospital.FormattingEnabled = true;
            cBhospital.Location = new Point(133, 118);
            cBhospital.Name = "cBhospital";
            cBhospital.Size = new Size(419, 28);
            cBhospital.TabIndex = 23;
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(133, 168);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(542, 28);
            cbDoctor.TabIndex = 24;
            // 
            // tabalCitas
            // 
            tabalCitas.BackgroundColor = SystemColors.ButtonHighlight;
            tabalCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabalCitas.Columns.AddRange(new DataGridViewColumn[] { CNum, cCliente, CDoc, cEspecialidad, CFecha, cDetalles });
            tabalCitas.Location = new Point(470, 367);
            tabalCitas.Name = "tabalCitas";
            tabalCitas.RowHeadersWidth = 51;
            tabalCitas.RowTemplate.Height = 29;
            tabalCitas.Size = new Size(806, 268);
            tabalCitas.TabIndex = 25;
            // 
            // CNum
            // 
            CNum.HeaderText = "No";
            CNum.MinimumWidth = 6;
            CNum.Name = "CNum";
            CNum.Width = 125;
            // 
            // cCliente
            // 
            cCliente.HeaderText = "Hospital";
            cCliente.MinimumWidth = 6;
            cCliente.Name = "cCliente";
            cCliente.Width = 125;
            // 
            // CDoc
            // 
            CDoc.HeaderText = "Doctor";
            CDoc.MinimumWidth = 6;
            CDoc.Name = "CDoc";
            CDoc.Width = 125;
            // 
            // cEspecialidad
            // 
            cEspecialidad.HeaderText = "Especialidad";
            cEspecialidad.MinimumWidth = 6;
            cEspecialidad.Name = "cEspecialidad";
            cEspecialidad.Width = 125;
            // 
            // CFecha
            // 
            CFecha.HeaderText = "Fecha";
            CFecha.MinimumWidth = 6;
            CFecha.Name = "CFecha";
            CFecha.Width = 125;
            // 
            // cDetalles
            // 
            cDetalles.HeaderText = "Detalles Adicionales";
            cDetalles.MinimumWidth = 6;
            cDetalles.Name = "cDetalles";
            cDetalles.Width = 125;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1149, 271);
            button2.Name = "button2";
            button2.Size = new Size(107, 67);
            button2.TabIndex = 28;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(441, 294);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(722, 27);
            txtBuscar.TabIndex = 27;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(79, 436);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(307, 67);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "   Agregar Cita";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(133, 225);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(296, 27);
            txtFecha.TabIndex = 31;
            txtFecha.Value = new DateTime(2024, 5, 3, 0, 0, 0, 0);
            txtFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1325, 711);
            Controls.Add(txtFecha);
            Controls.Add(btnAgregar);
            Controls.Add(button2);
            Controls.Add(txtBuscar);
            Controls.Add(tabalCitas);
            Controls.Add(cbDoctor);
            Controls.Add(cBhospital);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtDetalles);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Name = "Citas";
            Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)tabalCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtDetalles;
        private Label Nombre;
        private Label label2;
        private TextBox txtCliente;
        private ColorDialog colorDialog1;
        private ComboBox cBhospital;
        private ComboBox cbDoctor;
        private DataGridView tabalCitas;
        private DataGridViewTextBoxColumn CNum;
        private DataGridViewTextBoxColumn cCliente;
        private DataGridViewTextBoxColumn CDoc;
        private DataGridViewTextBoxColumn cEspecialidad;
        private DataGridViewTextBoxColumn CFecha;
        private DataGridViewTextBoxColumn cDetalles;
        private Button button2;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private DateTimePicker txtFecha;
    }
}