using QuartzTypeLib;
using SoundLiveStream.Services;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundLiveStream
{
    public partial class Main : Form
    {
        private Point _mouseLoc;
        UIPage tagPage;
        Utilities.MP3Player player = new Utilities.MP3Player();
        private readonly CategoryService categoryService = new CategoryService();
        private readonly SoundService soundService = new SoundService();
        public Main()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void uiNavBarMain_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void uiNavBarMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadCategory();

        }

        private void LoadSound(int categoryId)
        {
            var sounds = soundService.GetByCategory(categoryId);
            if (sounds == null)
            {
                MessageBox.Show("Khong co du lieu");
            }

            UIPanel panelSound;
            PictureBox pictureBox1;
            UILabel lbTitileSound;

            var flowLayoutPanelSound = new FlowLayoutPanel()
            {

                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(0, 0),
                Name = "flowLayoutPanelSound",
                BackColor = System.Drawing.Color.White,
                Size = new System.Drawing.Size(802, 364),
                TabIndex = 1
            };
            foreach (var item in sounds)
            {
                lbTitileSound = new UILabel()
                {
                    Cursor = System.Windows.Forms.Cursors.Hand,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(46, 0),
                    Name = "lbTitileSound",
                    Size = new System.Drawing.Size(342, 44),
                    Style = Sunny.UI.UIStyle.Custom,
                    TabIndex = item.Id,
                    Text = item.Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                };
                pictureBox1 = new PictureBox()
                {
                    Dock = System.Windows.Forms.DockStyle.Left,
                    Image = global::SoundLiveStream.Properties.Resources.mp3__1_,
                    Location = new System.Drawing.Point(0, 0),
                    Name = "pictureBox1",
                    Size = new System.Drawing.Size(46, 44),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabIndex = 0,
                    TabStop = false,
                };
                panelSound = new UIPanel()
                {

                    FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255))))),
                    Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(4, 5),
                    Margin = new System.Windows.Forms.Padding(4, 5, 4, 5),
                    MinimumSize = new System.Drawing.Size(1, 1),
                    Name = "pannelSound",
                    Size = new System.Drawing.Size(388, 44),
                    Style = Sunny.UI.UIStyle.Custom,
                    TabIndex = 0,
                    Text = null,
                    TextAlignment = System.Drawing.ContentAlignment.MiddleCenter,
                };
                panelSound.Controls.Add(lbTitileSound);
                panelSound.Controls.Add(pictureBox1);

                flowLayoutPanelSound.Controls.Add(panelSound);
                tagPage.Controls.Add(flowLayoutPanelSound);
                lbTitileSound.Click += delegate (object sender, EventArgs e)
                {

                    lbTitileSound_Click(sender, e, item.Id);
                };

            }
        }

        private void lbTitileSound_Click(object sender, EventArgs e, int id)
        {
            MessageBox.Show("Ban dang click bai hat: " + id);
            player.Open(@"E:\Co-Le-Anh-Khong-Ve-Quynh-Hieu-Bang");
        }

        private void LoadCategory()
        {
            var categories = categoryService.GetAll();
            var tagControl = new UITabControl();

            foreach (var item in categories)
            {
                tagPage = new UIPage()
                {
                    Name = "tagPage",
                    Tag = item.Id,
                    Text = item.Name
                };

                uiTabControlSound.AddPages(tagPage);

                uiTabControlSound.Click += delegate (object sender, EventArgs e)
                 {

                     tagPage_Click(sender, e, item.Id);
                 };
            }


        }
        private void tagPage_Click(object sender, EventArgs e, int id)
        {
            LoadSound(id);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
