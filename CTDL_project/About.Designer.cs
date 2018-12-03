namespace CTDL_project
{
    partial class About
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
            this.exit = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Image = global::CTDL_project.Properties.Resources.iconfinder_next_arrow_3831001;
            this.exit.ImageSize = 36;
            this.exit.Location = new System.Drawing.Point(463, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 45);
            this.exit.TabIndex = 8;
            this.exit.UseSelectable = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 260);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Name = "About";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Thông tin nhóm ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink exit;
    }
}