using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic
{
    class MusicFile
    {
        public MusicFile(string name, string path, long size)
        {
            this.Name = name;
            this.Path = path;
            this.Size = size;
        }
        public string Name
        {
            set;
            get;
        }
        public string Path
        {
            set;
            get;
        }
        public string Singer
        {
            set;
            get;
        }
        public long Size
        {
            set;
            get;
        }
    }
}
