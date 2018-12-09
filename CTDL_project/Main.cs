using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
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
        TextBox[] Node = new TextBox[100];
        int item;
        int i = 0;
        int x = 40;
        int j = 0;
        int quaTrai = 0;
        int quaPhai = 605;
        bool daTaoNode = false;
        #endregion

        #region Queue
        public void tao_Node(int item)
        {
            Node[i] = new TextBox();
            Node[i].Multiline = true;
            Node[i].Text = item.ToString();
            Node[i].TextAlign = HorizontalAlignment.Center;
            Node[i].Width = 40;
            Node[i].Height = 40;
            Node[i].Location = new Point(x, 75);
            Node[i].BackColor = Color.Coral;
            Node[i].ForeColor = Color.White;
            Node[i].Font = new Font(this.Font, FontStyle.Bold);
            Node[i].Font = new Font("Arial", 20, FontStyle.Bold);
            Node[i].ReadOnly = true;
            this.Controls.Add(Node[i]);
            x += 10;
            daTaoNode = true;
        }


        //public void tao_Node()
        //{
        //    Node = new TextBox[100];
        //    Node temp = myQueue.front;


        //    Node[i] = new TextBox();
        //    Node[i].Multiline = true;
        //    Node[i].Text = temp.data.ToString();
        //    Node[i].TextAlign = HorizontalAlignment.Center;
        //    Node[i].Width = 40;
        //    Node[i].Height = 40;
        //    Node[i].Location = new Point(x, 75);
        //    Node[i].BackColor = Color.Coral;
        //    Node[i].ForeColor = Color.White;
        //    Node[i].Font = new Font(this.Font, FontStyle.Bold);
        //    Node[i].Font = new Font("Arial", 20, FontStyle.Bold);
        //    Node[i].ReadOnly = true;
        //    this.Controls.Add(Node[i]);
        //    i++;
        //    x += 60;
        //    temp = temp.next;


        //    daTaoNode = true;
        //}

        public void xoa_Node()
        {
            if (daTaoNode == true)
            {
                for (int i = 0; i < myQueue.lenghtQueue(); i++)
                {
                    this.Controls.Remove(Node[i]);
                }
            }
        }

        public static int[] StringToIntArray(string input)
        {
            string[] fields = input.Split(new char[] { ' ', '\n', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] x = new int[fields.Length];
            x = new int[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                int.TryParse(fields[i], out x[i]);
            }
            return x;
        }
        #endregion

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MetroFramework.MetroMessageBox.Show(this, "Thoát khỏi chương trình ?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            //this.Hide();
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
                myQueue.Enqueue(item);
                tao_Node(item);
                i++;
                this.txt_giaTri.Clear();
                this.txt_giaTri.Focus();
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập giá trị cần thêm vào Queue!", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_giaTri.Clear();
                this.txt_giaTri.Focus();
                return;
            }
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
            try
            {
                if (myQueue.front == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Queue is empty!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (myQueue.front != null)
                {
                    Node_qua_trai(Node[j], quaTrai);
                    Node_di_xuong(Node[j], 90);
                    Node_qua_phai(Node[j], quaPhai);
                    quaTrai += 10;
                    quaPhai -= 60;
                    j++;
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập giá trị cần thêm vào Queue!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void Node_di_xuong(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Top += 1;
                    //Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }
        public void Node_qua_phai(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Left += 1;
                    //Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
        }
        public void Node_qua_trai(Control t, int S)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                int loop_Count = S;
                while (loop_Count > 0)
                {
                    Application.DoEvents();
                    t.Left -= 1;
                    //Tre(Toc_do);
                    loop_Count--;
                }
                t.Refresh();
            });
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
                // Node_qua_trai(Node)
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (myQueue.front == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is empty ?", "Cảnh báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (myQueue.front != null)
            {
                DialogResult tl = MetroFramework.MetroMessageBox.Show(this, "Delete Queue ?", "Cảnh báo",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tl == DialogResult.Yes)
                {
                    myQueue.ClearQueue();
                    xoa_Node();
                }
            }
        }

        private void cb_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_code.SelectedIndex == 0)
            {
                txt_code.Items.Clear();
                txt_code.Items.Add("internal void Enqueue(int item)");
                txt_code.Items.Add(" {");
                txt_code.Items.Add("     Node newNode = new Node(item);");
                txt_code.Items.Add("     if (this.rear == null)");
                txt_code.Items.Add("     {");
                txt_code.Items.Add("         this.front = this.rear = newNode");
                txt_code.Items.Add("     }");
                txt_code.Items.Add("     else ");
                txt_code.Items.Add("     {");
                txt_code.Items.Add("         this.rear.next = newNode;");
                txt_code.Items.Add("         this.rear = newNode;");
                txt_code.Items.Add("     }");
                txt_code.Items.Add(" }");
            }
            if (cb_code.SelectedIndex == 1)
            {
                txt_code.Items.Clear();
                txt_code.Items.Add("internal void Dequeue() ");
                txt_code.Items.Add(" {");
                txt_code.Items.Add("     if (this.front == null)");
                txt_code.Items.Add("     {");
                txt_code.Items.Add("         return;");
                txt_code.Items.Add("     }");
                txt_code.Items.Add("     Node temp = this.front;");
                txt_code.Items.Add("     this.front = this.front.next;");
                txt_code.Items.Add("     if (this.front == null)");
                txt_code.Items.Add("     {");
                txt_code.Items.Add("         this.rear = null;");
                txt_code.Items.Add("     }");
                txt_code.Items.Add(" }");
            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (myQueue.front != null)
                {
                    DialogResult tl = MetroFramework.MetroMessageBox.Show(this, "Delete Queue ?", "Cảnh báo",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (tl == DialogResult.Yes)
                    {
                        myQueue.ClearQueue();
                        //tao_Node();
                    }
                }
                // mở file
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txt_openFile.Text = openFileDialog1.FileName;
                    int[] input = StringToIntArray(File.ReadAllText(txt_openFile.Text).Trim());
                    for (int i = 0; i < input.Length; i++)
                    {
                        myQueue.Enqueue(input[i]);
                    }
                    //tao_Node();
                    MetroFramework.MetroMessageBox.Show(this, "Đọc file thành công !", "Thông báo",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Không Thể Thực Hiện Thao Tác", "Lỗi",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
