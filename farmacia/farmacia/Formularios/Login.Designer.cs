namespace farmacia.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginFill = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            IniciarSesion = new Button();
            txtContraseña = new TextBox();
            panel4 = new Panel();
            txtUser = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            LoginFill.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginFill
            // 
            LoginFill.BackColor = Color.FromArgb(254, 253, 237);
            LoginFill.Controls.Add(panel1);
            LoginFill.Dock = DockStyle.Fill;
            LoginFill.Location = new Point(0, 0);
            LoginFill.Name = "LoginFill";
            LoginFill.Size = new Size(268, 395);
            LoginFill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(IniciarSesion);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 392);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(29, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 6;
            // 
            // IniciarSesion
            // 
            IniciarSesion.Anchor = AnchorStyles.Bottom;
            IniciarSesion.FlatStyle = FlatStyle.Flat;
            IniciarSesion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IniciarSesion.ForeColor = Color.FromArgb(79, 157, 157);
            IniciarSesion.Location = new Point(75, 337);
            IniciarSesion.Name = "IniciarSesion";
            IniciarSesion.Size = new Size(127, 39);
            IniciarSesion.TabIndex = 7;
            IniciarSesion.Text = "Iniciar Sesion";
            IniciarSesion.UseVisualStyleBackColor = true;
            IniciarSesion.Click += IniciarSesion_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtContraseña.BackColor = Color.FromArgb(34, 36, 49);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(75, 270);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(152, 20);
            txtContraseña.TabIndex = 6;
            txtContraseña.Text = "Contraseña";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(29, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(34, 36, 49);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(75, 192);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(152, 20);
            txtUser.TabIndex = 3;
            txtUser.Text = "Usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 56);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 43);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 395);
            Controls.Add(LoginFill);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            LoginFill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginFill;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button IniciarSesion;
        private TextBox txtContraseña;
        private Panel panel4;
        private TextBox txtUser;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}