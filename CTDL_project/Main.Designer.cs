namespace CTDL_project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pa_nhapTay = new MetroFramework.Controls.MetroPanel();
            this.btn_enQueue = new MetroFramework.Controls.MetroLink();
            this.txt_giaTri = new MetroFramework.Controls.MetroTextBox();
            this.pa_openFile = new MetroFramework.Controls.MetroPanel();
            this.btn_openFile = new MetroFramework.Controls.MetroLink();
            this.txt_openFile = new MetroFramework.Controls.MetroTextBox();
            this.pa_tuyChon = new MetroFramework.Controls.MetroPanel();
            this.cb_tuyChon = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_code = new MetroFramework.Controls.MetroComboBox();
            this.txt_code = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_about = new MetroFramework.Controls.MetroLink();
            this.btn_clear = new MetroFramework.Controls.MetroLink();
            this.btn_deQueue = new MetroFramework.Controls.MetroLink();
            this.btn_showQueue = new MetroFramework.Controls.MetroLink();
            this.exit = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            this.pa_nhapTay.SuspendLayout();
            this.pa_openFile.SuspendLayout();
            this.pa_tuyChon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pa_nhapTay);
            this.groupBox1.Controls.Add(this.pa_openFile);
            this.groupBox1.Controls.Add(this.pa_tuyChon);
            this.groupBox1.Location = new System.Drawing.Point(23, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chọn";
            // 
            // pa_nhapTay
            // 
            this.pa_nhapTay.Controls.Add(this.btn_enQueue);
            this.pa_nhapTay.Controls.Add(this.txt_giaTri);
            this.pa_nhapTay.HorizontalScrollbarBarColor = true;
            this.pa_nhapTay.HorizontalScrollbarHighlightOnWheel = false;
            this.pa_nhapTay.HorizontalScrollbarSize = 10;
            this.pa_nhapTay.Location = new System.Drawing.Point(6, 63);
            this.pa_nhapTay.Name = "pa_nhapTay";
            this.pa_nhapTay.Size = new System.Drawing.Size(226, 49);
            this.pa_nhapTay.TabIndex = 3;
            this.pa_nhapTay.VerticalScrollbarBarColor = true;
            this.pa_nhapTay.VerticalScrollbarHighlightOnWheel = false;
            this.pa_nhapTay.VerticalScrollbarSize = 10;
            // 
            // btn_enQueue
            // 
            this.btn_enQueue.Image = global::CTDL_project.Properties.Resources.iconfinder_settings_3830984;
            this.btn_enQueue.ImageSize = 35;
            this.btn_enQueue.Location = new System.Drawing.Point(176, 5);
            this.btn_enQueue.Name = "btn_enQueue";
            this.btn_enQueue.Size = new System.Drawing.Size(47, 41);
            this.btn_enQueue.TabIndex = 3;
            this.btn_enQueue.UseSelectable = true;
            this.btn_enQueue.Click += new System.EventHandler(this.btn_enQueue_Click);
            // 
            // txt_giaTri
            // 
            // 
            // 
            // 
            this.txt_giaTri.CustomButton.Image = null;
            this.txt_giaTri.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txt_giaTri.CustomButton.Name = "";
            this.txt_giaTri.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_giaTri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_giaTri.CustomButton.TabIndex = 1;
            this.txt_giaTri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_giaTri.CustomButton.UseSelectable = true;
            this.txt_giaTri.CustomButton.Visible = false;
            this.txt_giaTri.Lines = new string[0];
            this.txt_giaTri.Location = new System.Drawing.Point(3, 12);
            this.txt_giaTri.MaxLength = 32767;
            this.txt_giaTri.Name = "txt_giaTri";
            this.txt_giaTri.PasswordChar = '\0';
            this.txt_giaTri.PromptText = "Nhập giá trị . . .";
            this.txt_giaTri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_giaTri.SelectedText = "";
            this.txt_giaTri.SelectionLength = 0;
            this.txt_giaTri.SelectionStart = 0;
            this.txt_giaTri.ShortcutsEnabled = true;
            this.txt_giaTri.Size = new System.Drawing.Size(162, 25);
            this.txt_giaTri.TabIndex = 2;
            this.txt_giaTri.UseSelectable = true;
            this.txt_giaTri.WaterMark = "Nhập giá trị . . .";
            this.txt_giaTri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_giaTri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_giaTri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_giaTri_KeyDown);
            // 
            // pa_openFile
            // 
            this.pa_openFile.Controls.Add(this.btn_openFile);
            this.pa_openFile.Controls.Add(this.txt_openFile);
            this.pa_openFile.HorizontalScrollbarBarColor = true;
            this.pa_openFile.HorizontalScrollbarHighlightOnWheel = false;
            this.pa_openFile.HorizontalScrollbarSize = 10;
            this.pa_openFile.Location = new System.Drawing.Point(6, 118);
            this.pa_openFile.Name = "pa_openFile";
            this.pa_openFile.Size = new System.Drawing.Size(226, 44);
            this.pa_openFile.TabIndex = 4;
            this.pa_openFile.VerticalScrollbarBarColor = true;
            this.pa_openFile.VerticalScrollbarHighlightOnWheel = false;
            this.pa_openFile.VerticalScrollbarSize = 10;
            // 
            // btn_openFile
            // 
            this.btn_openFile.Image = global::CTDL_project.Properties.Resources.iconfinder_folders_3830989;
            this.btn_openFile.ImageSize = 35;
            this.btn_openFile.Location = new System.Drawing.Point(179, 5);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(44, 36);
            this.btn_openFile.TabIndex = 3;
            this.btn_openFile.UseSelectable = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txt_openFile
            // 
            // 
            // 
            // 
            this.txt_openFile.CustomButton.Image = null;
            this.txt_openFile.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txt_openFile.CustomButton.Name = "";
            this.txt_openFile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_openFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_openFile.CustomButton.TabIndex = 1;
            this.txt_openFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_openFile.CustomButton.UseSelectable = true;
            this.txt_openFile.CustomButton.Visible = false;
            this.txt_openFile.Lines = new string[0];
            this.txt_openFile.Location = new System.Drawing.Point(3, 11);
            this.txt_openFile.MaxLength = 32767;
            this.txt_openFile.Name = "txt_openFile";
            this.txt_openFile.PasswordChar = '\0';
            this.txt_openFile.PromptText = "Nhập đường dẫn . . .";
            this.txt_openFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_openFile.SelectedText = "";
            this.txt_openFile.SelectionLength = 0;
            this.txt_openFile.SelectionStart = 0;
            this.txt_openFile.ShortcutsEnabled = true;
            this.txt_openFile.Size = new System.Drawing.Size(162, 25);
            this.txt_openFile.TabIndex = 2;
            this.txt_openFile.UseSelectable = true;
            this.txt_openFile.WaterMark = "Nhập đường dẫn . . .";
            this.txt_openFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_openFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pa_tuyChon
            // 
            this.pa_tuyChon.Controls.Add(this.cb_tuyChon);
            this.pa_tuyChon.HorizontalScrollbarBarColor = true;
            this.pa_tuyChon.HorizontalScrollbarHighlightOnWheel = false;
            this.pa_tuyChon.HorizontalScrollbarSize = 10;
            this.pa_tuyChon.Location = new System.Drawing.Point(6, 19);
            this.pa_tuyChon.Name = "pa_tuyChon";
            this.pa_tuyChon.Size = new System.Drawing.Size(226, 38);
            this.pa_tuyChon.TabIndex = 2;
            this.pa_tuyChon.VerticalScrollbarBarColor = true;
            this.pa_tuyChon.VerticalScrollbarHighlightOnWheel = false;
            this.pa_tuyChon.VerticalScrollbarSize = 10;
            // 
            // cb_tuyChon
            // 
            this.cb_tuyChon.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_tuyChon.FormattingEnabled = true;
            this.cb_tuyChon.ItemHeight = 19;
            this.cb_tuyChon.Items.AddRange(new object[] {
            "Nhập từng giá trị",
            "Đọc giá trị từ File"});
            this.cb_tuyChon.Location = new System.Drawing.Point(3, 6);
            this.cb_tuyChon.Name = "cb_tuyChon";
            this.cb_tuyChon.PromptText = "Phương thức nhập";
            this.cb_tuyChon.Size = new System.Drawing.Size(220, 25);
            this.cb_tuyChon.TabIndex = 3;
            this.cb_tuyChon.UseSelectable = true;
            this.cb_tuyChon.SelectedIndexChanged += new System.EventHandler(this.cb_tuyChon_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_code);
            this.groupBox2.Controls.Add(this.txt_code);
            this.groupBox2.Location = new System.Drawing.Point(509, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể hiện code";
            // 
            // cb_code
            // 
            this.cb_code.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cb_code.FormattingEnabled = true;
            this.cb_code.ItemHeight = 19;
            this.cb_code.Items.AddRange(new object[] {
            "EnQueue",
            "DeQueue"});
            this.cb_code.Location = new System.Drawing.Point(6, 19);
            this.cb_code.Name = "cb_code";
            this.cb_code.PromptText = "Lựa chọn thao tác";
            this.cb_code.Size = new System.Drawing.Size(292, 25);
            this.cb_code.TabIndex = 3;
            this.cb_code.UseSelectable = true;
            this.cb_code.SelectedIndexChanged += new System.EventHandler(this.cb_code_SelectedIndexChanged);
            // 
            // txt_code
            // 
            this.txt_code.FormattingEnabled = true;
            this.txt_code.Location = new System.Drawing.Point(6, 54);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(292, 108);
            this.txt_code.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_about);
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.btn_deQueue);
            this.groupBox3.Controls.Add(this.btn_showQueue);
            this.groupBox3.Location = new System.Drawing.Point(267, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 172);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng điều khiển";
            // 
            // btn_about
            // 
            this.btn_about.Image = global::CTDL_project.Properties.Resources.iconfinder_note_3830986;
            this.btn_about.ImageSize = 40;
            this.btn_about.Location = new System.Drawing.Point(73, 89);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(56, 58);
            this.btn_about.TabIndex = 3;
            this.btn_about.UseSelectable = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::CTDL_project.Properties.Resources.iconfinder_retweet_3830998;
            this.btn_clear.ImageSize = 40;
            this.btn_clear.Location = new System.Drawing.Point(6, 89);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 58);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_deQueue
            // 
            this.btn_deQueue.Image = global::CTDL_project.Properties.Resources.iconfinder_close_3830967;
            this.btn_deQueue.ImageSize = 40;
            this.btn_deQueue.Location = new System.Drawing.Point(73, 25);
            this.btn_deQueue.Name = "btn_deQueue";
            this.btn_deQueue.Size = new System.Drawing.Size(56, 58);
            this.btn_deQueue.TabIndex = 1;
            this.btn_deQueue.UseSelectable = true;
            this.btn_deQueue.Click += new System.EventHandler(this.btn_deQueue_Click);
            // 
            // btn_showQueue
            // 
            this.btn_showQueue.Image = global::CTDL_project.Properties.Resources.iconfinder_play_3830993;
            this.btn_showQueue.ImageSize = 40;
            this.btn_showQueue.Location = new System.Drawing.Point(6, 25);
            this.btn_showQueue.Name = "btn_showQueue";
            this.btn_showQueue.Size = new System.Drawing.Size(56, 58);
            this.btn_showQueue.TabIndex = 0;
            this.btn_showQueue.UseSelectable = true;
            this.btn_showQueue.Click += new System.EventHandler(this.btn_showQueue_Click);
            // 
            // exit
            // 
            this.exit.Image = global::CTDL_project.Properties.Resources.icons8_shutdown_64;
            this.exit.ImageSize = 36;
            this.exit.Location = new System.Drawing.Point(790, 15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 36);
            this.exit.TabIndex = 7;
            this.exit.UseSelectable = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 554);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Cấu trúc dữ liệu hàng đợi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.pa_nhapTay.ResumeLayout(false);
            this.pa_openFile.ResumeLayout(false);
            this.pa_tuyChon.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroPanel pa_tuyChon;
        private MetroFramework.Controls.MetroComboBox cb_tuyChon;
        private MetroFramework.Controls.MetroPanel pa_openFile;
        private MetroFramework.Controls.MetroLink btn_openFile;
        private MetroFramework.Controls.MetroTextBox txt_openFile;
        private System.Windows.Forms.ListBox txt_code;
        private MetroFramework.Controls.MetroPanel pa_nhapTay;
        private MetroFramework.Controls.MetroTextBox txt_giaTri;
        private MetroFramework.Controls.MetroLink btn_showQueue;
        private MetroFramework.Controls.MetroLink btn_deQueue;
        private MetroFramework.Controls.MetroLink btn_clear;
        private MetroFramework.Controls.MetroLink btn_about;
        private MetroFramework.Controls.MetroLink btn_enQueue;
        private MetroFramework.Controls.MetroComboBox cb_code;
    }
}

