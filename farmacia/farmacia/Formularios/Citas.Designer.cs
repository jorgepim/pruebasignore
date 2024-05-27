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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cBhospital = new System.Windows.Forms.ComboBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.tabalCitas = new System.Windows.Forms.DataGridView();
            this.CNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabalCitas)).BeginInit();
            this.SuspendLayout();
=======
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)tabalCitas).BeginInit();
            SuspendLayout();
>>>>>>> 7cc36f2d26db914b4cae68488a0bc2dec055f96a
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Detalles Adicionales:";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hospital:";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalles.ForeColor = System.Drawing.Color.White;
            this.txtDetalles.Location = new System.Drawing.Point(133, 274);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(267, 106);
            this.txtDetalles.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(29, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(98, 29);
            this.Nombre.TabIndex = 12;
            this.Nombre.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Doctor:";
            // 
            // cBhospital
            // 
            this.cBhospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cBhospital.ForeColor = System.Drawing.Color.White;
            this.cBhospital.FormattingEnabled = true;
            this.cBhospital.Location = new System.Drawing.Point(133, 118);
            this.cBhospital.Name = "cBhospital";
            this.cBhospital.Size = new System.Drawing.Size(419, 28);
            this.cBhospital.TabIndex = 23;
            // 
            // cbDoctor
            // 
            this.cbDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(133, 168);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(419, 28);
            this.cbDoctor.TabIndex = 24;
            // 
            // tabalCitas
            // 
<<<<<<< HEAD
            this.tabalCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabalCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.tabalCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabalCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabalCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabalCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNum,
            this.cHospital,
            this.CDoc,
            this.cEspecialidad,
            this.CFecha,
            this.cDetalles});
            this.tabalCitas.EnableHeadersVisualStyles = false;
            this.tabalCitas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabalCitas.Location = new System.Drawing.Point(470, 367);
            this.tabalCitas.Name = "tabalCitas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabalCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabalCitas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tabalCitas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabalCitas.RowTemplate.Height = 29;
            this.tabalCitas.Size = new System.Drawing.Size(806, 268);
            this.tabalCitas.TabIndex = 25;
=======
            tabalCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabalCitas.BackgroundColor = Color.FromArgb(79, 80, 95);
            tabalCitas.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tabalCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tabalCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabalCitas.Columns.AddRange(new DataGridViewColumn[] { CNum, cHospital, CDoc, cEspecialidad, CFecha, cDetalles });
            tabalCitas.EnableHeadersVisualStyles = false;
            tabalCitas.GridColor = SystemColors.ActiveCaption;
            tabalCitas.Location = new Point(470, 367);
            tabalCitas.Name = "tabalCitas";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 36, 49);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabalCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabalCitas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(79, 80, 95);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            tabalCitas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tabalCitas.RowTemplate.Height = 29;
            tabalCitas.Size = new Size(806, 268);
            tabalCitas.TabIndex = 25;
>>>>>>> 7cc36f2d26db914b4cae68488a0bc2dec055f96a
            // 
            // CNum
            // 
            this.CNum.HeaderText = "No";
            this.CNum.MinimumWidth = 6;
            this.CNum.Name = "CNum";
            this.CNum.Width = 125;
            // 
            // cHospital
            // 
            this.cHospital.HeaderText = "Hospital";
            this.cHospital.MinimumWidth = 6;
            this.cHospital.Name = "cHospital";
            this.cHospital.Width = 125;
            // 
            // CDoc
            // 
            this.CDoc.HeaderText = "Doctor";
            this.CDoc.MinimumWidth = 6;
            this.CDoc.Name = "CDoc";
            this.CDoc.Width = 125;
            // 
            // cEspecialidad
            // 
            this.cEspecialidad.HeaderText = "Especialidad";
            this.cEspecialidad.MinimumWidth = 6;
            this.cEspecialidad.Name = "cEspecialidad";
            this.cEspecialidad.Width = 125;
            // 
            // CFecha
            // 
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.MinimumWidth = 6;
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 125;
            // 
            // cDetalles
            // 
            this.cDetalles.HeaderText = "Detalles Adicionales";
            this.cDetalles.MinimumWidth = 6;
            this.cDetalles.Name = "cDetalles";
            this.cDetalles.Width = 125;
            // 
<<<<<<< HEAD
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1169, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 50);
            this.button2.TabIndex = 28;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(470, 294);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(693, 20);
            this.txtBuscar.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(79, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(307, 67);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "   Agregar Cita";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
=======
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(93, 488);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(307, 67);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "   Agregar Cita";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
>>>>>>> 7cc36f2d26db914b4cae68488a0bc2dec055f96a
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(133, 225);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(296, 27);
            this.txtFecha.TabIndex = 31;
            this.txtFecha.Value = new System.DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cbCliente.ForeColor = System.Drawing.Color.White;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(133, 61);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(419, 28);
            this.cbCliente.TabIndex = 32;
            // 
            // Citas
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1325, 711);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.tabalCitas);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.cBhospital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Name = "Citas";
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.tabalCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1325, 711);
            Controls.Add(cbCliente);
            Controls.Add(txtFecha);
            Controls.Add(btnAgregar);
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
>>>>>>> 7cc36f2d26db914b4cae68488a0bc2dec055f96a
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
    }
}