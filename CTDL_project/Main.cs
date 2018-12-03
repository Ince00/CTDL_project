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
        int i = 0;
        int Khoang_cach;//khoảng cách 2 node liên tiếp
        int Canh_le;//canh lề node
        int Kich_thuoc; // kích thước node
        int Co_chu; //kích thước chữ
        bool Da_tao_mang = false;
        #endregion

        #region Queue
        public void tao_Mang()
        {
            myQueue.Enqueue(item);
            lenghtQueue = myQueue.lenghtQueue();


            Node = new TextBox[lenghtQueue];
            Kich_thuoc = 50;
            Co_chu = 25;
            Khoang_cach = 40;
            Canh_le = (1024 - Kich_thuoc * lenghtQueue - Khoang_cach * (lenghtQueue - 1)) / 2;



            Node temp = myQueue.front;

            while (temp != null)
            {
                Node[i] = new TextBox();
                Node[i].Multiline = true;
                Node[i].Text = temp.data.ToString();
                Node[i].TextAlign = HorizontalAlignment.Center;
                Node[i].Width = Kich_thuoc;
                Node[i].Height = Kich_thuoc;
                Node[i].Location = new Point(Canh_le + (Kich_thuoc + Khoang_cach) * i, 130);
                Node[i].BackColor = Color.OrangeRed;
                Node[i].ForeColor = Color.White;
                Node[i].Font = new Font(this.Font, FontStyle.Bold);
                Node[i].Font = new Font("Arial", Co_chu, FontStyle.Bold);
                Node[i].ReadOnly = true;
                this.Controls.Add(Node[i]);
                i += 1;
                temp = temp.next;
            }
            Da_tao_mang = true; //Xác nhận đã tạo mảng
        }
        #endregion

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
                MetroFramework.MetroMessageBox.Show(this, "Số phần tử vừa nhập vào không hợp lệ!", "Thông báo");
                this.txt_giaTri.Clear();
                this.txt_giaTri.Focus();
                return;
            }
            myQueue.Enqueue(item);
            MetroFramework.MetroMessageBox.Show(this, "Đã thêm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
