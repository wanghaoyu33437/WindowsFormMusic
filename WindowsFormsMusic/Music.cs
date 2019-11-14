using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class Music : MetroFramework.Forms.MetroForm
    {
        private PictureBox pictureBox1;
        private Button Play;
        private Button LoadMusic;
        private Button CheckMusic;
        private Button MyPage;
        private ListView listView1;
        private MusiceMain musiceMain = new MusiceMain();
        private MusicMenu musicMenu = new MusicMenu();
        private MenuItem playingItem = null;
        System.ComponentModel.ComponentResourceManager resources = null;
        public Music()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.LoadMusic = new System.Windows.Forms.Button();
            this.CheckMusic = new System.Windows.Forms.Button();
            this.MyPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            this.listView1.Columns.Add("序号", 50, HorizontalAlignment.Left);
            this.listView1.Columns.Add("歌曲名", 224, HorizontalAlignment.Left);

            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 198);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.BackColor = System.Drawing.Color.White;
            this.Play.BackgroundImage = global::WindowsFormsMusic.Properties.Resources.播放;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Location = new System.Drawing.Point(146, 314);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(49, 49);
            this.Play.TabIndex = 4;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_or_Click);
            // 
            // LoadMusic
            // 
            this.LoadMusic.BackColor = System.Drawing.Color.White;
            this.LoadMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadMusic.FlatAppearance.BorderSize = 0;
            this.LoadMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadMusic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoadMusic.Location = new System.Drawing.Point(339, 92);
            this.LoadMusic.Name = "LoadMusic";
            this.LoadMusic.Size = new System.Drawing.Size(97, 29);
            this.LoadMusic.TabIndex = 8;
            this.LoadMusic.Text = "录入音乐";
            this.LoadMusic.UseVisualStyleBackColor = false;
            this.LoadMusic.Click += new System.EventHandler(this.LoadMusic_Click_1);
            // 
            // CheckMusic
            // 
            this.CheckMusic.BackColor = System.Drawing.Color.White;
            this.CheckMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckMusic.FlatAppearance.BorderSize = 0;
            this.CheckMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckMusic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckMusic.Location = new System.Drawing.Point(339, 144);
            this.CheckMusic.Name = "CheckMusic";
            this.CheckMusic.Size = new System.Drawing.Size(97, 29);
            this.CheckMusic.TabIndex = 9;
            this.CheckMusic.Text = "查看音乐";
            this.CheckMusic.UseVisualStyleBackColor = false;
            this.CheckMusic.Click += new System.EventHandler(this.CheckMusic_Click_1);
            // 
            // MyPage
            // 
            this.MyPage.BackColor = System.Drawing.Color.White;
            this.MyPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MyPage.FlatAppearance.BorderSize = 0;
            this.MyPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MyPage.Location = new System.Drawing.Point(339, 210);
            this.MyPage.Name = "MyPage";
            this.MyPage.Size = new System.Drawing.Size(97, 29);
            this.MyPage.TabIndex = 10;
            this.MyPage.Text = "我的主页";
            this.MyPage.UseVisualStyleBackColor = false;
            this.MyPage.Click += new System.EventHandler(this.MyPage_Click_1);
            // 
            // Music
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 433);
            this.Controls.Add(this.MyPage);
            this.Controls.Add(this.CheckMusic);
            this.Controls.Add(this.LoadMusic);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Music";
            this.Text = "BoseMusic";
            this.Load += new System.EventHandler(this.Music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Stop_Click(object sender, EventArgs e)
        {

            this.musiceMain.stopPlay(this.playingItem);
            //TODO:暂停音乐
        }
        private void Play_or_Click(object sender, EventArgs e)
        {
            if (playingItem == null)
            {
                int a = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text);
                this.playingItem = this.musicMenu.getItemByIndex(a);
                this.musiceMain.playMusic(this.playingItem);
                this.Play.BackgroundImage = global::WindowsFormsMusic.Properties.Resources.暂停;

            }
            else
            {

                this.musiceMain.stopPlay(this.playingItem);
                this.Play.BackgroundImage = global::WindowsFormsMusic.Properties.Resources.播放; 

                playingItem = null;
            }
        }
        private void LoadMusic_Click_1(object sender, EventArgs e)
        {
            //TODO:录入音乐
            this.musiceMain.LoadFiles();
            this.showMusicMenu();
        }
        private void showMusicMenu()
        {

            this.listView1.BeginUpdate();
            this.listView1.Items.Clear();
            this.musicMenu = this.musiceMain.ShowFiles();
            for (int i = 0; i < this.musicMenu.getItemSize(); i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = this.musicMenu.getItemByIndex(i).Id + "";
                lvi.SubItems.Add(this.musicMenu.getItemByIndex(i).Name);
                listView1.Items.Add(lvi);

            }

            this.listView1.EndUpdate();
        }

        private void CheckMusic_Click_1(object sender, EventArgs e)
        {
            //TODO:查看音乐
        }

        private void MyPage_Click_1(object sender, EventArgs e)
        {
            //TODO:我的主页
          
        }

        private void Music_Load(object sender, EventArgs e)
        {
            this.showMusicMenu();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
