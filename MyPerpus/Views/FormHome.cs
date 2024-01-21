using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPerpus.Views
{
    public partial class FormHome : Form
    {
        private Panel? currentSubMenuPanel;

        public FormHome()
        {
            InitializeComponent();
        }

        private void ActivateButton(object senderBtn, Panel? subMenuPanel)
        {
            if (currentSubMenuPanel != null && currentSubMenuPanel != subMenuPanel)
            {
                currentSubMenuPanel.Visible = false;
            }
            if (subMenuPanel != null)
            {
                currentSubMenuPanel = subMenuPanel;
                currentSubMenuPanel.Visible = true;
            }
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelMaster);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, null);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Formanggota formUser = new Formanggota();
            changePanel(formUser);
            ActivateButton(sender, panelMaster);
        }

        private void btnPeminjam_Click(object sender, EventArgs e)
        {
            Formpeminjam formPeminjam = new Formpeminjam();
            changePanel(formPeminjam);
            ActivateButton(sender, panelMaster);
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Formpengembalian formPengembalian = new Formpengembalian();
            changePanel(formPengembalian);
            ActivateButton(sender, panelMaster);
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            Formbuku formBuku = new Formbuku();
            changePanel(formBuku);
            ActivateButton(sender, panelMaster);
        }

        private void changePanel(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelAppName_Click(object sender, EventArgs e)
        {

        }

        private void toolStripUserActive_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
