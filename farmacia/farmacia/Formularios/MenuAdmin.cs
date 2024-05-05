using DB;
using farmacia.Formularios;
using System.Runtime.InteropServices;

namespace PharmaSync.formularios 
{
    public partial class MenuAdmin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;


        public MenuAdmin()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnConvenio_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AgregarConvenios());
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarLotes());
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarEmpleados());
        }

        private void btnPagarEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new PagarEmpleados());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            reset();
        }

        public void reset()
        {
            //DisableButton();
            labelTitle.Text = "HOME ADMIN";
            panelTitulo.BackColor = Color.FromArgb(7, 65, 115);
            currentButton = null;
            btnCerrar.Visible = true;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = farmacia.ThemeColor.ChangeColorBrightness(color, -0.3);
                    farmacia.ThemeColor.PrimaryColor = color;
                    farmacia.ThemeColor.SecondaryColor = farmacia.ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCerrar.Visible = true;
                }
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(farmacia.ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(farmacia.ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = farmacia.ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            foreach (Control previusBtn in panelMenu.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(22, 121, 171);
                    previusBtn.ForeColor = Color.Black;
                    previusBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarTodo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisHora_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrarHoras());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
