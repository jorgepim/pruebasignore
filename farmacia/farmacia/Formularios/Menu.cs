using farmacia.Clases.Entidades;
using PharmaSync.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia.Formularios.multimedia
{
    public partial class Menu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Menu()
        {
            InitializeComponent();
            random = new Random();
            btnCerrar.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Emoji", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCerrar.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previusBtn in panelMenu.Controls)
            {
                if(previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(22, 121, 171);
                    previusBtn.ForeColor = Color.Black;
                    previusBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes(), sender);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Factura(), sender);
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Membresia(), sender);
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Sucursales(), sender);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Citas(), sender);
            ActiveButton(sender);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();    
            reset();
        }
        public void reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitulo.BackColor = Color.FromArgb(7, 65, 115);
            panelLogo.BackColor = Color.FromArgb(73, 105, 137);
            currentButton = null;
            btnCerrar.Visible = false;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void btnCerrarWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
