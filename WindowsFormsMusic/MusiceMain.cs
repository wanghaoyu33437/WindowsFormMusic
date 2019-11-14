using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;

namespace WindowsFormsMusic
{
    class MusiceMain
    {
        static Menu mainMenu = null;
        private MusicMenu musicMenu = null;
       
        static clsMCI cm = null;
        [STAThread]
        //static void Main()
        //{
        //    mainMenu = new Menu("主目录");
        //    this.musicMenu = new this.musicMenu("音乐列表", -1);
        //    this.musicMenu.Ano = "上下箭头选择 Enter键播放/确认";

        //    mainMenu.addItem(new MenuItem(1, "录入音乐", LoadFiles));
        //    mainMenu.addItem(new MenuItem(2, "查看音乐", ShowFiles));
        //    mainMenu.addItem(new MenuItem(3, "删除音乐"));
        //    mainMenu.addItem(new MenuItem(4, "我的主页"));
        //    mainMenu.addItem(new MenuItem(5, "退出登录", Logout));

        //    mainMenu.Show();
        //}
        static void LoadFiles(MenuItem item)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();
            df.ShowDialog();
            string selectPath = df.SelectedPath;
            if ("" == selectPath)
            {
                mainMenu.Show();
                return;
            }
            DirectoryInfo dInfo = new DirectoryInfo(selectPath);
            foreach (FileInfo f in dInfo.GetFiles("*.mp3"))
            {
                MusicFileService.Instance().AddFile(new MusicFile(f.Name, f.FullName, f.Length));
            }
            MusicFileService.Instance().Save();
            mainMenu.Show();
        }
        //整合功能
        public void LoadFiles()
        {
            FolderBrowserDialog df = new FolderBrowserDialog();
            df.ShowDialog();
            string selectPath = df.SelectedPath;
            if ("" == selectPath)
            {
                return;
            }
            DirectoryInfo dInfo = new DirectoryInfo(selectPath);
            foreach (FileInfo f in dInfo.GetFiles("*.mp3"))
            {
                MusicFileService.Instance().AddFile(new MusicFile(f.Name, f.FullName, f.Length));
            }
            MusicFileService.Instance().Save();
            //mainMenu.Show();
        }
        public  void ShowFiles(MenuItem item)
        {
            this.musicMenu.Clear();

            List<MusicFile> files = MusicFileService.Instance().GetAllFiles();
            for (int i = 0; i < files.Count; i++)
            {
                this.musicMenu.addItem(new MenuItem(i, files[i].Name, playMusic));
            }
            this.musicMenu.addItem(new MenuItem(files.Count, "返回主菜单", returnMainMenu));
            this.musicMenu.addItem(new MenuItem(files.Count + 1, "下一首", nextPlay));
            this.musicMenu.addItem(new MenuItem(files.Count + 2, "停止播放", stopPlay));
            this.musicMenu.addItem(new MenuItem(files.Count + 3, "上一首", previousPlay));
            if (this.musicMenu.playingIndex != -1) this.musicMenu.CurrentItem = this.musicMenu.playingIndex;
            this.musicMenu.Show();
        }
        //展示音乐整合后
        public MusicMenu ShowFiles()
        {
            this.musicMenu = new MusicMenu();
            List<MusicFile> files = MusicFileService.Instance().GetAllFiles();
            for (int i = 0; i < files.Count; i++)
            {
                this.musicMenu.addItem(new MenuItem(i, files[i].Name));
            }
            if (this.musicMenu.playingIndex != -1) this.musicMenu.CurrentItem = this.musicMenu.playingIndex;
            return this.musicMenu;
        }
        //播放音乐
        public  void playMusic(MenuItem item)
        {
            //歌曲播放选中
            this.musicMenu.playingIndex = item.Id;
            //MessageBox.Show("播放音乐"+item.Name);
            MusicFile file = MusicFileService.Instance().FindFile(item.Name);
            if (null == file)
            {
                this.musicMenu.Show();
                return;
            }
            //停止旧的歌曲
            if (null != cm)
                cm.StopT();
            //播放
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();

        }

        //返回主页面
        static void returnMainMenu(MenuItem item)
        {
            mainMenu.Show();
        }

        //停止播放
        public void stopPlay(MenuItem item)
        {
            if (null != cm)
                cm.StopT();
            this.musicMenu.playingIndex = -1;
        }

        public  void nextPlay(MenuItem item)
        {
            this.musicMenu.playingIndex = (this.musicMenu.playingIndex + 1) % (this.musicMenu.getItemSize() - 4);
            string name = this.musicMenu.getItemByIndex(this.musicMenu.playingIndex).Name;
            MusicFile file = MusicFileService.Instance().FindFile(name);
            if (cm != null)
                cm.StopT();
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();
            this.musicMenu.Show();
        }
        public  void previousPlay(MenuItem item)
        {
            int size = this.musicMenu.getItemSize() - 4;
            this.musicMenu.playingIndex = (this.musicMenu.playingIndex + size - 1) % size;
            string name = this.musicMenu.getItemByIndex(this.musicMenu.playingIndex).Name;
            MusicFile file = MusicFileService.Instance().FindFile(name);
            if (cm != null)
                cm.StopT();
            cm = new clsMCI();
            cm.FileName = file.Path;
            cm.play();
            this.musicMenu.Show();
        }
        //退出
        static void Logout(MenuItem item)
        {
        }
    }
}
