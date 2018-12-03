using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CTDL_project
{

    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        #region Khai báo
        LinkListQueue myQueue = new LinkListQueue();
        TextBox[] Node;
        int item;
        int lenghtQueue;
        bool daTaoNode = false;
        int j = 0;
        //int x = 685;
        #endregion

        #region Queue
        public void tao_Node()
        {
            xoa_Node();
            int x = 645;
            lenghtQueue = myQueue.lenghtQueue();
            Node = new TextBox[lenghtQueue];
            Node temp = myQueue.front;

            for (int i = 0; i < lenghtQueue; i++)
            {
                Node[i] = new TextBox();
                Node[i].Multiline = true;
                Node[i].Text = temp.data.ToString();
                Node[i].TextAlign = HorizontalAlignment.Center;
                Node[i].Width = 40;
                Node[i].Height = 40;
                Node[i].Location = new Point(x, 185);
                Node[i].BackColor = Color.Coral;
                Node[i].ForeColor = Color.White;
                Node[i].Font = new Font(this.Font, FontStyle.Bold);
                Node[i].Font = new Font("Arial", 20, FontStyle.Bold);
                Node[i].ReadOnly = true;
                this.Controls.Add(Node[i]);
                x -= 60;
                temp = temp.next;
            }
            j = lenghtQueue;
            daTaoNode = true;
        }

        public void xoa_Node()
        {
            if (daTaoNode == true)
            {
                for (int i = 0; i < j; i++)
                {
                    this.Controls.Remove(Node[i]);
                }
            }
        }
        #endregion

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult tl =
                     MetroFramework.MetroMessageBox.Show(this, "Thoát khỏi chương trình ?",
                     "Cảnh báo",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.ShowDialog();
        }

        private void btn_enQueue_Click(object sender, EventArgs e)
        {
            this.txt_giaTri.Focus();
            this.txt_giaTri.SelectAll();
            try
            {
                item = Convert.ToInt32(txt_giaTri.Text);

            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập giá trị cần thêm vào Queue!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_giaTri.Clear();
                this.txt_giaTri.Focus();
                return;
            }
            myQueue.Enqueue(item);
            tao_Node();
            //MetroFramework.MetroMessageBox.Show(this, "Đã thêm thành công!", "Thông báo",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txt_giaTri.Clear();
            this.txt_giaTri.Focus();
        }

        private void txt_giaTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_enQueue.PerformClick();
            }
        }

        private void btn_showQueue_Click(object sender, EventArgs e)
        {
            if (myQueue.front == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is empty!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tao_Node();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pa_nhapTay.Enabled = false;
            pa_openFile.Enabled = false;
        }

        private void cb_tuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tuyChon.SelectedIndex == 0)
            {
                pa_nhapTay.Enabled = true;
                pa_openFile.Enabled = false;
            }
            if (cb_tuyChon.SelectedIndex == 1)
            {
                pa_nhapTay.Enabled = false;
                pa_openFile.Enabled = true;
            }
        }

        private void btn_deQueue_Click(object sender, EventArgs e)
        {
            Node temp = myQueue.front;
            if (temp == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is empty!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (temp != null)
            {
                myQueue.Dequeue();
            }
            tao_Node();
        }
    }
}
