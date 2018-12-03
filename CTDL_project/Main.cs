using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CTDL_project
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult tl =
                     MetroFramework.MetroMessageBox.Show(this, "Thoát khỏi chương trình ?",
                     "Cảnh báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.ShowDialog();
        }

        private void cb_thaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaoTac.SelectedIndex==0)
            {
                pa_tuyChon.Enabled = true;
            }
        }
    }
}
