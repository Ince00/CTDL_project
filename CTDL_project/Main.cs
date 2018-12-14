﻿using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CTDL_project
{

    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        #region Khai báo biến

        LinkListQueue myQueue = new LinkListQueue();
        int khoangCach = 600;

        #endregion

        #region Các hàm tiện ích

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
                    loop_Count--;
                }
                t.Refresh();
            });
        }



        #endregion

        #region Xử lí các sự kiện 

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MetroFramework.MetroMessageBox.Show(this, "Thoát khỏi chương trình ?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void btn_enQueue_Click(object sender, EventArgs e)
        {
            this.txt_giaTri.Focus();
            this.txt_giaTri.SelectAll();
            try
            {
                TextBox node = new TextBox();
                node.Text = txt_giaTri.Text;
                node.TextAlign = HorizontalAlignment.Center;
                node.Width = 40;
                node.Height = 40;
                node.Location = new Point(0, 75);
                node.BackColor = Color.Coral;
                node.ForeColor = Color.White;
                node.Font = new Font("Arial", 20, FontStyle.Bold);
                node.ReadOnly = true;
                this.Controls.Add(node);

                myQueue.Enqueue(node);

                Node_qua_phai(node, 50);
                Node_di_xuong(node, 90);
                Node_qua_phai(node, khoangCach -= 60);

                this.txt_giaTri.Clear();
                this.txt_giaTri.Focus();
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.ToString(), "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Node temp = myQueue.front;
                while (temp != null)
                {
                    Node_qua_phai(temp.data, 50);
                    Node_di_xuong(temp.data, 90);
                    Node_qua_phai(temp.data, khoangCach -= 60);

                    temp = temp.next;
                }
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.ToString(), "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            try
            {
                if (myQueue.front != null)
                {
                    //int kcXoa = 60;
                    Node_qua_phai(myQueue.front.data, 50);
                    Node_di_xuong(myQueue.front.data, 90);
                    Node_qua_phai(myQueue.front.data, 200);
                    this.Controls.Remove(myQueue.front.data);
                    myQueue.front.data.Dispose();
                    myQueue.Dequeue();
                }
                if (myQueue.front == null)
                {
                    khoangCach = 600;
                    MetroFramework.MetroMessageBox.Show(this, "Hàng đợi rỗng !", "THÔNG BÁO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.ToString(), "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                Node temp = myQueue.front;
                if (temp != null)
                {
                    int kcBienMat = 50;
                    while (temp != null)
                    {
                        Node_qua_phai(temp.data, kcBienMat);
                        Node_di_xuong(temp.data, 90);
                        Node_qua_phai(temp.data, 200);

                        Controls.Remove(temp.data);
                        temp.data.Dispose();
                        kcBienMat += 60;
                        temp = temp.next;
                    }
                    myQueue.ClearQueue();
                }
                if (temp == null)
                {
                    khoangCach = 600;
                }


            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.ToString(), "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                        TextBox node = new TextBox();
                        node.Text = input[i].ToString();
                        node.TextAlign = HorizontalAlignment.Center;
                        node.Width = 40;
                        node.Height = 40;
                        node.Location = new Point(0, 75);
                        node.BackColor = Color.Coral;
                        node.ForeColor = Color.White;
                        node.Font = new Font("Arial", 20, FontStyle.Bold);
                        node.ReadOnly = true;
                        this.Controls.Add(node);

                        myQueue.Enqueue(node);
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

        private void txt_giaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MetroFramework.MetroMessageBox.Show(this, "Chỉ nhập số !", "Cảnh báo",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            txt_giaTri.Clear();
            txt_giaTri.Focus();
        }

        #endregion
    }
}


