using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class Musice : MetroFramework.Forms.MetroForm
    {
        public Musice()
        {
            InitializeComponent();
        }


        private void Stop_Click(object sender, EventArgs e)
        {

            this.musiceMain.stopPlay(this.playingItem);            //TODO:暂停音乐
        }
        private void Play_or_Click(object sender, EventArgs e)
        {
            if (playingItem == null)
            {
                int a = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text);
                this.playingItem = this.musicMenu.getItemByIndex(a);
                this.musiceMain.playMusic(this.playingItem);
                this.Play.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("Stop.BackgroundImage")));

            }
            else
            {

                this.musiceMain.stopPlay(this.playingItem);
                this.Play.BackgroundImage = ((System.Drawing.Image)(this.resources.GetObject("Play.BackgroundImage")));

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
