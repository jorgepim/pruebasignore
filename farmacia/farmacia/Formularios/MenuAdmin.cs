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

        public void reset()
        {
            //DisableButton();
            labelTitle.Text = "HOME ADMIN";
            panelTitulo.BackColor = Color.FromArgb(7, 65, 115);
            currentButton = null;
            btnCerrar.Visible = true;
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarConvenios());
        }

        private void btnLotes_Click_1(object sender, EventArgs e)
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

        private void btnRegisHora_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RegistrarHoras());
        }

        private void btnCerrarTodo_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            reset();
        }
    }
}
