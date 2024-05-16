namespace farmacia.Formularios
{
    partial class Sucursales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            TXTProducto = new TextBox();
            label1 = new Label();
            CBDepartamento = new ComboBox();
            TablaSucursales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TablaSucursales).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 4;
            label2.Text = "Producto";
            // 
            // TXTProducto
            // 
            TXTProducto.BackColor = Color.FromArgb(79, 80, 95);
            TXTProducto.ForeColor = Color.White;
            TXTProducto.Location = new Point(70, 126);
            TXTProducto.Name = "TXTProducto";
            TXTProducto.Size = new Size(476, 23);
            TXTProducto.TabIndex = 5;
            TXTProducto.TextChanged += TXTProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(603, 200);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 7;
            label1.Text = "Departamento:";
            // 
            // CBDepartamento
            // 
            CBDepartamento.BackColor = Color.FromArgb(79, 80, 95);
            CBDepartamento.FormattingEnabled = true;
            CBDepartamento.Location = new Point(603, 240);
            CBDepartamento.Name = "CBDepartamento";
            CBDepartamento.Size = new Size(172, 23);
            CBDepartamento.TabIndex = 8;
            CBDepartamento.SelectedIndexChanged += CBDepartamento_SelectedIndexChanged;
            // 
            // TablaSucursales
            // 
            TablaSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            TablaSucursales.DefaultCellStyle = dataGridViewCellStyle1;
            TablaSucursales.Location = new Point(70, 173);
            TablaSucursales.Name = "TablaSucursales";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TablaSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TablaSucursales.RowTemplate.Height = 25;
            TablaSucursales.Size = new Size(476, 247);
            TablaSucursales.TabIndex = 9;
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(895, 472);
            Controls.Add(TablaSucursales);
            Controls.Add(CBDepartamento);
            Controls.Add(label1);
            Controls.Add(TXTProducto);
            Controls.Add(label2);
            ForeColor = Color.White;
            Name = "Sucursales";
            Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)TablaSucursales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox TXTProducto;
        private Label label1;
        private ComboBox CBDepartamento;
        private DataGridView TablaSucursales;
    }
}