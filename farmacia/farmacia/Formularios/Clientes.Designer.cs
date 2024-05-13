namespace farmacia.Formularios
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            btnAgregar = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            TxtDirec = new TextBox();
            txtDui = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            Nombre = new Label();
            txtBuscar = new TextBox();
            lblClientes = new Label();
            tablaClientes = new DataGridView();
            button1 = new Button();
            btnMembresia = new Button();
            btnFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(61, 248);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(184, 50);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "   Agregar Cliente";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 159);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 191);
            label3.Name = "label3";
            label3.Size = new Size(86, 22);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 93);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 3;
            label4.Text = "DUI:";
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.FromArgb(79, 80, 95);
            txtTel.BorderStyle = BorderStyle.None;
            txtTel.ForeColor = Color.White;
            txtTel.Location = new Point(144, 191);
            txtTel.Margin = new Padding(3, 2, 3, 2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(150, 16);
            txtTel.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(79, 80, 95);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(144, 157);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 16);
            txtEmail.TabIndex = 9;
            // 
            // TxtDirec
            // 
            TxtDirec.BackColor = Color.FromArgb(79, 80, 95);
            TxtDirec.BorderStyle = BorderStyle.None;
            TxtDirec.ForeColor = Color.White;
            TxtDirec.Location = new Point(144, 122);
            TxtDirec.Margin = new Padding(3, 2, 3, 2);
            TxtDirec.Name = "TxtDirec";
            TxtDirec.Size = new Size(150, 16);
            TxtDirec.TabIndex = 8;
            // 
            // txtDui
            // 
            txtDui.BackColor = Color.FromArgb(79, 80, 95);
            txtDui.BorderStyle = BorderStyle.None;
            txtDui.ForeColor = Color.White;
            txtDui.Location = new Point(144, 93);
            txtDui.Margin = new Padding(3, 2, 3, 2);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(150, 16);
            txtDui.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(79, 80, 95);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(144, 60);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 16);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.White;
            Nombre.Location = new Point(25, 57);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(86, 22);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(79, 80, 95);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(463, 78);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(318, 16);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblClientes
            // 
            lblClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientes.ForeColor = Color.White;
            lblClientes.Location = new Point(345, 73);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(99, 20);
            lblClientes.TabIndex = 20;
            lblClientes.Text = "Clientes";
            // 
            // tablaClientes
            // 
            tablaClientes.AllowUserToOrderColumns = true;
            tablaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaClientes.BackgroundColor = Color.FromArgb(34, 36, 49);
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Location = new Point(317, 159);
            tablaClientes.Margin = new Padding(3, 2, 3, 2);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.RowTemplate.Height = 29;
            tablaClientes.Size = new Size(566, 254);
            tablaClientes.TabIndex = 19;
            tablaClientes.CellClick += tablaClientes_CellClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(811, 58);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(48, 50);
            button1.TabIndex = 22;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnMembresia
            // 
            btnMembresia.FlatAppearance.BorderSize = 0;
            btnMembresia.FlatStyle = FlatStyle.Flat;
            btnMembresia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMembresia.ForeColor = Color.White;
            btnMembresia.Image = (Image)resources.GetObject("btnMembresia.Image");
            btnMembresia.Location = new Point(25, 336);
            btnMembresia.Margin = new Padding(3, 2, 3, 2);
            btnMembresia.Name = "btnMembresia";
            btnMembresia.Size = new Size(154, 50);
            btnMembresia.TabIndex = 23;
            btnMembresia.Text = " Membresias";
            btnMembresia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembresia.UseVisualStyleBackColor = true;
            btnMembresia.Click += btnMembresia_Click;
            // 
            // btnFactura
            // 
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFactura.ForeColor = Color.White;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.Location = new Point(25, 391);
            btnFactura.Margin = new Padding(3, 2, 3, 2);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(114, 50);
            btnFactura.TabIndex = 24;
            btnFactura.Text = "Factura";
            btnFactura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += AbrirFactura;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(895, 472);
            Controls.Add(btnFactura);
            Controls.Add(btnMembresia);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblClientes);
            Controls.Add(label4);
            Controls.Add(tablaClientes);
            Controls.Add(txtTel);
            Controls.Add(txtBuscar);
            Controls.Add(txtEmail);
            Controls.Add(TxtDirec);
            Controls.Add(Nombre);
            Controls.Add(txtDui);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Nombre;
        private TextBox txtTel;
        private TextBox txtEmail;
        private TextBox TxtDirec;
        private TextBox txtDui;
        private TextBox txtNombre;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblClientes;
        private DataGridView tablaClientes;
        private Button button1;
        private Button btnMembresia;
        private Button btnFactura;
    }
}