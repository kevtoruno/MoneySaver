using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using System.Runtime.InteropServices;
using UI.Forms;
using UI.Forms.PeriodsForms;

namespace UI
{
    public partial class InitialMenu : BaseForm
    {
        public InitialMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InitialMenu_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(object childFormObject)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form childForm = childFormObject as Form;

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(childForm);
            this.PanelContenedor.Tag = childForm;
            childForm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetRequiredService<FrmClientList>());
        }

        private void btnControlAhorro_Click(object sender, EventArgs e)
        {     
            OpenChildForm(Program.ServiceProvider.GetRequiredService<FrmSavingAccountList>());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.SubMenuAdminPanel.Visible == true)
                this.SubMenuAdminPanel.Visible = false;
            else
                this.SubMenuAdminPanel.Visible = true;

        }

        private void btnMainPeriods_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetRequiredService<FrmPeriodsList>());
        }
    }
}