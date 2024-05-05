namespace farmacia.Formularios
{
    partial class Membresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresia));
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDirec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.cbMembresia = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaClientes
            // 
            this.tablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cNombre,
            this.CDui,
            this.cDirec,
            this.CTele,
            this.cPeriodo,
            this.cTipoM});
            this.tablaClientes.Location = new System.Drawing.Point(513, 454);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.RowHeadersWidth = 51;
            this.tablaClientes.RowTemplate.Height = 29;
            this.tablaClientes.Size = new System.Drawing.Size(919, 278);
            this.tablaClientes.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.Width = 125;
            // 
            // CDui
            // 
            this.CDui.HeaderText = "DUI";
            this.CDui.MinimumWidth = 6;
            this.CDui.Name = "CDui";
            this.CDui.Width = 125;
            // 
            // cDirec
            // 
            this.cDirec.HeaderText = "Dirección";
            this.cDirec.MinimumWidth = 6;
            this.cDirec.Name = "cDirec";
            this.cDirec.Width = 125;
            // 
            // CTele
            // 
            this.CTele.HeaderText = "Telefono";
            this.CTele.MinimumWidth = 6;
            this.CTele.Name = "CTele";
            this.CTele.Width = 125;
            // 
            // cPeriodo
            // 
            this.cPeriodo.HeaderText = "Periodo";
            this.cPeriodo.MinimumWidth = 6;
            this.cPeriodo.Name = "cPeriodo";
            this.cPeriodo.Width = 125;
            // 
            // cTipoM
            // 
            this.cTipoM.HeaderText = "Tipo de membresia";
            this.cTipoM.MinimumWidth = 6;
            this.cTipoM.Name = "cTipoM";
            this.cTipoM.Width = 125;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "DUI:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(43, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(98, 29);
            this.Nombre.TabIndex = 21;
            this.Nombre.Text = "Nombre:";
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDui.ForeColor = System.Drawing.Color.White;
            this.txtDui.Location = new System.Drawing.Point(230, 181);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(266, 20);
            this.txtDui.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(43, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(463, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(544, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Telefono:";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.Location = new System.Drawing.Point(648, 182);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(216, 20);
            this.txtTel.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Membresia:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cbPeriodo.ForeColor = System.Drawing.Color.White;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(230, 252);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(266, 28);
            this.cbPeriodo.TabIndex = 31;
            // 
            // cbMembresia
            // 
            this.cbMembresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.cbMembresia.ForeColor = System.Drawing.Color.White;
            this.cbMembresia.FormattingEnabled = true;
            this.cbMembresia.Location = new System.Drawing.Point(230, 319);
            this.cbMembresia.Name = "cbMembresia";
            this.cbMembresia.Size = new System.Drawing.Size(266, 28);
            this.cbMembresia.TabIndex = 32;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "btnAgregar";
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(64, 395);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(307, 67);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "   Agregar ";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1351, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 67);
            this.button1.TabIndex = 35;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(789, 395);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(545, 27);
            this.txtBuscar.TabIndex = 34;
            // 
            // Membresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1474, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbMembresia);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tablaClientes);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Membresia";
            this.Text = "Membresia";
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tablaClientes;
        private Label label4;
        private Label Nombre;
        private TextBox txtDui;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtTel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cNombre;
        private DataGridViewTextBoxColumn CDui;
        private DataGridViewTextBoxColumn cDirec;
        private DataGridViewTextBoxColumn CTele;
        private DataGridViewTextBoxColumn cPeriodo;
        private DataGridViewTextBoxColumn cTipoM;
        private Label label1;
        private Label label2;
        private ComboBox cbPeriodo;
        private ComboBox cbMembresia;
        private Button btnAgregar;
        private Button button1;
        private TextBox txtBuscar;
    }
}