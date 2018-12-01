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
    }
}
