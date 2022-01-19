namespace SoundLiveStream
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbClose = new System.Windows.Forms.Label();
            this.lbMinimux = new System.Windows.Forms.Label();
            this.uiNavBarMain = new Sunny.UI.UINavBar();
            this.lbTitlePhamMem = new Sunny.UI.UILabel();
            this.uiTabControlMenuHome = new Sunny.UI.UITabControlMenu();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tabPageSoundHot = new System.Windows.Forms.TabPage();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.lbUserName = new Sunny.UI.UILabel();
            this.btnLogout = new Sunny.UI.UIButton();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.tabPageAddSound = new System.Windows.Forms.TabPage();
            this.uiTabControlSound = new Sunny.UI.UITabControl();
            this.tabControlPage = new System.Windows.Forms.TabPage();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitileSound = new Sunny.UI.UILabel();
            this.pannelSound = new Sunny.UI.UIPanel();
            this.uiNavBarMain.SuspendLayout();
            this.uiTabControlMenuHome.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiTabControlSound.SuspendLayout();
            this.tabControlPage.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pannelSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClose.ForeColor = System.Drawing.Color.Red;
            this.lbClose.Location = new System.Drawing.Point(992, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 25);
            this.lbClose.TabIndex = 1;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // lbMinimux
            // 
            this.lbMinimux.AutoSize = true;
            this.lbMinimux.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMinimux.ForeColor = System.Drawing.Color.Red;
            this.lbMinimux.Location = new System.Drawing.Point(949, 0);
            this.lbMinimux.Name = "lbMinimux";
            this.lbMinimux.Size = new System.Drawing.Size(20, 25);
            this.lbMinimux.TabIndex = 1;
            this.lbMinimux.Text = "-";
            // 
            // uiNavBarMain
            // 
            this.uiNavBarMain.Controls.Add(this.lbTitlePhamMem);
            this.uiNavBarMain.Controls.Add(this.lbMinimux);
            this.uiNavBarMain.Controls.Add(this.lbClose);
            this.uiNavBarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBarMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiNavBarMain.Location = new System.Drawing.Point(0, 0);
            this.uiNavBarMain.Name = "uiNavBarMain";
            this.uiNavBarMain.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiNavBarMain.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiNavBarMain.Size = new System.Drawing.Size(1019, 33);
            this.uiNavBarMain.Style = Sunny.UI.UIStyle.Green;
            this.uiNavBarMain.TabIndex = 2;
            this.uiNavBarMain.Text = "uiNavBar1";
            this.uiNavBarMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiNavBarMain_MouseDown);
            this.uiNavBarMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uiNavBarMain_MouseMove);
            // 
            // lbTitlePhamMem
            // 
            this.lbTitlePhamMem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitlePhamMem.ForeColor = System.Drawing.Color.White;
            this.lbTitlePhamMem.Location = new System.Drawing.Point(3, 2);
            this.lbTitlePhamMem.Name = "lbTitlePhamMem";
            this.lbTitlePhamMem.Size = new System.Drawing.Size(239, 23);
            this.lbTitlePhamMem.TabIndex = 3;
            this.lbTitlePhamMem.Text = "Phần Mềm Sound Hỗ Trợ Live Stream ";
            this.lbTitlePhamMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTabControlMenuHome
            // 
            this.uiTabControlMenuHome.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenuHome.Controls.Add(this.tabPageHome);
            this.uiTabControlMenuHome.Controls.Add(this.tabPageCategory);
            this.uiTabControlMenuHome.Controls.Add(this.tabPageSoundHot);
            this.uiTabControlMenuHome.Controls.Add(this.tabPageAddSound);
            this.uiTabControlMenuHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenuHome.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenuHome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControlMenuHome.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenuHome.Location = new System.Drawing.Point(0, 33);
            this.uiTabControlMenuHome.Multiline = true;
            this.uiTabControlMenuHome.Name = "uiTabControlMenuHome";
            this.uiTabControlMenuHome.SelectedIndex = 0;
            this.uiTabControlMenuHome.Size = new System.Drawing.Size(1019, 626);
            this.uiTabControlMenuHome.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenuHome.TabIndex = 3;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.uiTabControlSound);
            this.tabPageHome.Controls.Add(this.uiTitlePanel1);
            this.tabPageHome.Location = new System.Drawing.Point(201, 0);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(818, 626);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Location = new System.Drawing.Point(201, 0);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Size = new System.Drawing.Size(818, 626);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Danh Mục";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // tabPageSoundHot
            // 
            this.tabPageSoundHot.Location = new System.Drawing.Point(201, 0);
            this.tabPageSoundHot.Name = "tabPageSoundHot";
            this.tabPageSoundHot.Size = new System.Drawing.Size(818, 626);
            this.tabPageSoundHot.TabIndex = 2;
            this.tabPageSoundHot.Text = "Sound Hot";
            this.tabPageSoundHot.UseVisualStyleBackColor = true;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelFooter.Controls.Add(this.btnLogout);
            this.panelFooter.Controls.Add(this.lbUserName);
            this.panelFooter.Controls.Add(this.uiAvatar1);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.ForeColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Location = new System.Drawing.Point(0, 582);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1019, 77);
            this.panelFooter.TabIndex = 4;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiAvatar1.Location = new System.Drawing.Point(0, 0);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 77);
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUserName.ForeColor = System.Drawing.Color.Cyan;
            this.lbUserName.Location = new System.Drawing.Point(66, 11);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(159, 23);
            this.lbUserName.Style = Sunny.UI.UIStyle.Custom;
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Xin Chào! Admin";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(79, 37);
            this.btnLogout.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.uiMarkLabel2);
            this.uiTitlePanel1.Controls.Add(this.uiMarkLabel1);
            this.uiTitlePanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 8);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.Size = new System.Drawing.Size(810, 123);
            this.uiTitlePanel1.TabIndex = 0;
            this.uiTitlePanel1.Text = "Thông báo";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiMarkLabel1.Location = new System.Drawing.Point(19, 49);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(783, 23);
            this.uiMarkLabel1.TabIndex = 0;
            this.uiMarkLabel1.Text = "Thông báo cập nhập phiên bản mới";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiMarkLabel2.Location = new System.Drawing.Point(19, 85);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(783, 23);
            this.uiMarkLabel2.TabIndex = 1;
            this.uiMarkLabel2.Text = "Thông báo mới nhất";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageAddSound
            // 
            this.tabPageAddSound.Location = new System.Drawing.Point(201, 0);
            this.tabPageAddSound.Name = "tabPageAddSound";
            this.tabPageAddSound.Size = new System.Drawing.Size(818, 626);
            this.tabPageAddSound.TabIndex = 3;
            this.tabPageAddSound.Text = "Thêm Âm Thanh";
            this.tabPageAddSound.UseVisualStyleBackColor = true;
            // 
            // uiTabControlSound
            // 
            this.uiTabControlSound.Controls.Add(this.tabControlPage);
            this.uiTabControlSound.Controls.Add(this.tabPage2);
            this.uiTabControlSound.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlSound.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControlSound.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControlSound.Location = new System.Drawing.Point(4, 139);
            this.uiTabControlSound.MainPage = "";
            this.uiTabControlSound.Name = "uiTabControlSound";
            this.uiTabControlSound.SelectedIndex = 0;
            this.uiTabControlSound.Size = new System.Drawing.Size(802, 404);
            this.uiTabControlSound.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlSound.TabIndex = 1;
            this.uiTabControlSound.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // tabControlPage
            // 
            this.tabControlPage.Controls.Add(this.pannelSound);
            this.tabControlPage.Location = new System.Drawing.Point(0, 40);
            this.tabControlPage.Name = "tabControlPage";
            this.tabControlPage.Size = new System.Drawing.Size(802, 364);
            this.tabControlPage.TabIndex = 0;
            this.tabControlPage.Text = "tabPage1";
            this.tabControlPage.UseVisualStyleBackColor = true;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel1.Location = new System.Drawing.Point(4, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(388, 44);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::SoundLiveStream.Properties.Resources.mp3__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiPanel1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(802, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(46, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(342, 44);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Anh Nhớ Em.mp3";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SoundLiveStream.Properties.Resources.mp3__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitileSound
            // 
            this.lbTitileSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitileSound.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitileSound.Location = new System.Drawing.Point(46, 0);
            this.lbTitileSound.Name = "lbTitileSound";
            this.lbTitileSound.Size = new System.Drawing.Size(342, 44);
            this.lbTitileSound.TabIndex = 2;
            this.lbTitileSound.Text = "Anh Nhớ Em.mp3";
            this.lbTitileSound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pannelSound
            // 
            this.pannelSound.Controls.Add(this.lbTitileSound);
            this.pannelSound.Controls.Add(this.pictureBox1);
            this.pannelSound.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.pannelSound.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pannelSound.Location = new System.Drawing.Point(4, 5);
            this.pannelSound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pannelSound.MinimumSize = new System.Drawing.Size(1, 1);
            this.pannelSound.Name = "pannelSound";
            this.pannelSound.Size = new System.Drawing.Size(388, 44);
            this.pannelSound.TabIndex = 0;
            this.pannelSound.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 659);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.uiTabControlMenuHome);
            this.Controls.Add(this.uiNavBarMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sound Live Stream";
            this.uiNavBarMain.ResumeLayout(false);
            this.uiNavBarMain.PerformLayout();
            this.uiTabControlMenuHome.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTabControlSound.ResumeLayout(false);
            this.tabControlPage.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pannelSound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbMinimux;
        private Sunny.UI.UINavBar uiNavBarMain;
        private Sunny.UI.UILabel lbTitlePhamMem;
        private Sunny.UI.UITabControlMenu uiTabControlMenuHome;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageSoundHot;
        private Sunny.UI.UITabControl uiTabControlSound;
        private System.Windows.Forms.TabPage tabControlPage;
        private Sunny.UI.UIPanel pannelSound;
        private Sunny.UI.UILabel lbTitileSound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.TabPage tabPageAddSound;
        private System.Windows.Forms.Panel panelFooter;
        private Sunny.UI.UIButton btnLogout;
        private Sunny.UI.UILabel lbUserName;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}
