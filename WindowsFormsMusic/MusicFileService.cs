using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsMusic
{
    class MusicFileService
    {

        private MusicFileService()
        {
            this.InitData();
        }

        //单例模式
        private static MusicFileService T;
        public static MusicFileService Instance()
        {
            if (T == null)
                T = new MusicFileService();
            return T;
        }

        List<MusicFile> Files = new List<MusicFile>();

        //获取所有文件
        public List<MusicFile> GetAllFiles()
        {
            return this.Files;
        }
        //新增
        public bool AddFile(MusicFile newFile)
        {
            foreach (MusicFile file in Files)
            {
                if (file.Name == newFile.Name)
                    return false;
            }
            this.Files.Add(newFile);
            return true;
        }
        //根据音乐名称删除
        public bool DelFile(string name)
        {
            for (int i = 0; i < this.Files.Count; i++)
            {
                if (this.Files[i].Name == name)
                {
                    this.Files.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        //查找
        public MusicFile FindFile(string name)
        {
            for (int i = 0; i < this.Files.Count; i++)
            {
                if (this.Files[i].Name == name)
                {
                    return this.Files[i];
                }
            }
            return null;
        }
        //写数据到文件
        public void Save()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(new FileStream("data1.txt", FileMode.Create));
                foreach (MusicFile file in Files)
                {
                    sw.WriteLine(file.Name + "," + file.Path + "," + file.Size);
                }
            }
            finally
            {

                sw.Close();

            }
        }
        //从文件初始化
        public void InitData()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream("data1.txt", FileMode.OpenOrCreate));
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] datas = line.Split(',');
                    this.Files.Add(new MusicFile(datas[0], datas[1], long.Parse(datas[2])));
                }
            }
            finally
            {
                sr.Close();
            }
        }

    }
}
