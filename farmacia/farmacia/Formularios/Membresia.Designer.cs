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
            tablaClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            cNombre = new DataGridViewTextBoxColumn();
            CDui = new DataGridViewTextBoxColumn();
            cDirec = new DataGridViewTextBoxColumn();
            CTele = new DataGridViewTextBoxColumn();
            cPeriodo = new DataGridViewTextBoxColumn();
            cTipoM = new DataGridViewTextBoxColumn();
            label4 = new Label();
            Nombre = new Label();
            txtDui = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtTel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbPeriodo = new ComboBox();
            cbMembresia = new ComboBox();
            btnAgregar = new Button();
            button1 = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            SuspendLayout();
            // 
            // tablaClientes
            // 
            tablaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaClientes.BackgroundColor = SystemColors.ButtonHighlight;
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, cNombre, CDui, cDirec, CTele, cPeriodo, cTipoM });
            tablaClientes.Location = new Point(513, 454);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.RowTemplate.Height = 29;
            tablaClientes.Size = new Size(919, 278);
            tablaClientes.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // cNombre
            // 
            cNombre.HeaderText = "Nombre";
            cNombre.MinimumWidth = 6;
            cNombre.Name = "cNombre";
            cNombre.Width = 125;
            // 
            // CDui
            // 
            CDui.HeaderText = "DUI";
            CDui.MinimumWidth = 6;
            CDui.Name = "CDui";
            CDui.Width = 125;
            // 
            // cDirec
            // 
            cDirec.HeaderText = "Dirección";
            cDirec.MinimumWidth = 6;
            cDirec.Name = "cDirec";
            cDirec.Width = 125;
            // 
            // CTele
            // 
            CTele.HeaderText = "Telefono";
            CTele.MinimumWidth = 6;
            CTele.Name = "CTele";
            CTele.Width = 125;
            // 
            // cPeriodo
            // 
            cPeriodo.HeaderText = "Periodo";
            cPeriodo.MinimumWidth = 6;
            cPeriodo.Name = "cPeriodo";
            cPeriodo.Width = 125;
            // 
            // cTipoM
            // 
            cTipoM.HeaderText = "Tipo de membresia";
            cTipoM.MinimumWidth = 6;
            cTipoM.Name = "cTipoM";
            cTipoM.Width = 125;
            // 
            // label4
            // 
            label4.Location = new Point(43, 184);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 23;
            label4.Text = "DUI:";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(43, 64);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(98, 29);
            Nombre.TabIndex = 21;
            Nombre.Text = "Nombre:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(92, 182);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(266, 27);
            txtDui.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(463, 27);
            txtNombre.TabIndex = 24;
            // 
            // label3
            // 
            label3.Location = new Point(388, 185);
            label3.Name = "label3";
            label3.Size = new Size(98, 29);
            label3.TabIndex = 26;
            label3.Text = "Telefono:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(492, 181);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(216, 27);
            txtTel.TabIndex = 27;
            // 
            // label1
            // 
            label1.Location = new Point(33, 266);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
            label1.TabIndex = 29;
            label1.Text = "Periodo:";
            // 
            // label2
            // 
            label2.Location = new Point(33, 322);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 30;
            label2.Text = "Membresia:";
            // 
            // cbPeriodo
            // 
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Location = new Point(137, 263);
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(308, 28);
            cbPeriodo.TabIndex = 31;
            // 
            // cbMembresia
            // 
            cbMembresia.FormattingEnabled = true;
            cbMembresia.Location = new Point(137, 319);
            cbMembresia.Name = "cbMembresia";
            cbMembresia.Size = new Size(308, 28);
            cbMembresia.TabIndex = 32;
            // 
            // btnAgregar
            // 
            btnAgregar.AccessibleName = "btnAgregar";
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(64, 395);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(307, 67);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "   Agregar ";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1351, 372);
            button1.Name = "button1";
            button1.Size = new Size(65, 67);
            button1.TabIndex = 35;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(789, 395);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(545, 27);
            txtBuscar.TabIndex = 34;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Membresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1474, 744);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(cbMembresia);
            Controls.Add(cbPeriodo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtTel);
            Controls.Add(label4);
            Controls.Add(Nombre);
            Controls.Add(txtDui);
            Controls.Add(txtNombre);
            Controls.Add(tablaClientes);
            Name = "Membresia";
            Text = "Membresia";
            Load += Membresia_Load;
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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