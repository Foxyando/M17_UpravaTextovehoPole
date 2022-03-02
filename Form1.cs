using System;
using System.Windows.Forms;

namespace M17_UpravaTextovehoPole
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtBasen.Text = "Sviť, měsíčku, polehoučku \r\n skrz ten hustý mrak,\r\n jakpak se ti Brixen líbí? \r\n -Neškareď se tak!";

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult vyberFont = fontDialog.ShowDialog();
            if (vyberFont == DialogResult.OK)
            {
                txtBasen.Font = fontDialog.Font;
            }
        }

        private void btnBarvaPisma_Click(object sender, EventArgs e)
        {
            DialogResult vyberBarvaTextu = colorDialog.ShowDialog();
            if (vyberBarvaTextu == DialogResult.OK)
            {
                txtBasen.ForeColor = colorDialog.Color;
            }
        }

        private void btnBarvaPozadi_Click(object sender, EventArgs e)
        {
            DialogResult vyberBarvaTextu = colorDialog.ShowDialog();
            if (vyberBarvaTextu == DialogResult.OK)
            {
                txtBasen.BackColor = colorDialog.Color;
            }
        }

        private void btnSmazaniTextovehoPole_Click(object sender, EventArgs e)
        {
            DialogResult smazaniTextu = MessageBox.Show("Opravdu chceš smazat text?", "Upozornění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (smazaniTextu)
            {
                case DialogResult.Yes:
                    txtBasen.Text = "";
                    break;
                default:
                    break;
            }
        }
    }

}
