using farmacia.Clases.DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace farmacia.Formularios


{
  
    partial class Citas:Form
    {


    
  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDetalles = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            cBhospital = new ComboBox();
            cbDoctor = new ComboBox();
            tabalCitas = new DataGridView();
            CNum = new DataGridViewTextBoxColumn();
            cHospital = new DataGridViewTextBoxColumn();
            CDoc = new DataGridViewTextBoxColumn();
            cEspecialidad = new DataGridViewTextBoxColumn();
            CFecha = new DataGridViewTextBoxColumn();
            cDetalles = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            txtFecha = new DateTimePicker();
            cbCliente = new ComboBox();
            button2 = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabalCitas).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 225);
            label5.Name = "label5";
            label5.Size = new Size(98, 29);
            label5.TabIndex = 16;
            label5.Text = "Fecha:";
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 277);
            label3.Name = "label3";
            label3.Size = new Size(98, 29);
            label3.TabIndex = 14;
            label3.Text = "Detalles Adicionales:";
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 117);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 15;
            label4.Text = "Hospital:";
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.FromArgb(79, 80, 95);
            txtDetalles.BorderStyle = BorderStyle.None;
            txtDetalles.ForeColor = Color.White;
            txtDetalles.Location = new Point(133, 274);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(267, 106);
            txtDetalles.TabIndex = 22;
            // 
            // Nombre
            // 
            Nombre.ForeColor = Color.White;
            Nombre.Location = new Point(29, 64);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(98, 29);
            Nombre.TabIndex = 12;
            Nombre.Text = "Cliente";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 171);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 13;
            label2.Text = "Doctor:";
            // 
            // cBhospital
            // 
            cBhospital.BackColor = Color.FromArgb(79, 80, 95);
            cBhospital.ForeColor = Color.White;
            cBhospital.FormattingEnabled = true;
            cBhospital.Location = new Point(133, 118);
            cBhospital.Name = "cBhospital";
            cBhospital.Size = new Size(419, 28);
            cBhospital.TabIndex = 23;
            // 
            // cbDoctor
            // 
            cbDoctor.BackColor = Color.FromArgb(79, 80, 95);
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(133, 168);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(542, 28);
            cbDoctor.TabIndex = 24;
            // 
            // tabalCitas
            // 
            tabalCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabalCitas.BackgroundColor = Color.FromArgb(79, 80, 95);
            tabalCitas.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tabalCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tabalCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabalCitas.Columns.AddRange(new DataGridViewColumn[] { CNum, cHospital, CDoc, cEspecialidad, CFecha, cDetalles });
            tabalCitas.EnableHeadersVisualStyles = false;
            tabalCitas.GridColor = SystemColors.ActiveCaption;
            tabalCitas.Location = new Point(470, 367);
            tabalCitas.Name = "tabalCitas";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tabalCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            tabalCitas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(79, 80, 95);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            tabalCitas.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // cHospital
            // 
            cHospital.HeaderText = "Hospital";
            cHospital.MinimumWidth = 6;
            cHospital.Name = "cHospital";
            cHospital.Width = 125;
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
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(79, 436);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(307, 67);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "   Agregar Cita";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(133, 225);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(296, 27);
            txtFecha.TabIndex = 31;
            txtFecha.Value = new DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // cbCliente
            // 
            cbCliente.BackColor = Color.FromArgb(79, 80, 95);
            cbCliente.ForeColor = Color.White;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(133, 61);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(419, 28);
            cbCliente.TabIndex = 32;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1169, 279);
            button2.Name = "button2";
            button2.Size = new Size(64, 50);
            button2.TabIndex = 28;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(79, 80, 95);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(470, 294);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(693, 20);
            txtBuscar.TabIndex = 27;
          
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1325, 711);
            Controls.Add(cbCliente);
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
        private ColorDialog colorDialog1;
        private ComboBox cBhospital;
        private ComboBox cbDoctor;
        private DataGridView tabalCitas;
        private Button btnAgregar;
        private DateTimePicker txtFecha;
        private DataGridViewTextBoxColumn CNum;
        private DataGridViewTextBoxColumn cHospital;
        private DataGridViewTextBoxColumn CDoc;
        private DataGridViewTextBoxColumn cEspecialidad;
        private DataGridViewTextBoxColumn CFecha;
        private DataGridViewTextBoxColumn cDetalles;
        private ComboBox cbCliente;
        private Button button2;
        private TextBox txtBuscar;
    }
}